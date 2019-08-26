using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TTESlution
{
    public partial class Form2 : Form
    {
        private static string mysqlCon = "Server=localhost;Uid=root;Pwd=221358;Database=ex1";//选择数据库，用户名及密码
        private MySqlConnection conn;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(mysqlCon);
            using (var cmd = conn.CreateCommand())//撤除表格
            {
                conn.Open();
                cmd.CommandText = "truncate table df1";
                //cmd.CommandText = "delete from tx1";
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtHeight.Text == ""  | txtSpeed.Text == "" | txtSLongitude.Text == "" | txtSLatitude.Text == ""  | txtDLongitude.Text == "" | txtDLatitude.Text == "" )
            //if (false)
            {
                MessageBox.Show("请补全输入数据");
            }
            else
            {
                // 一 生成高度的函数
                var listHeight1 = new List<double>();
                listHeight1 = height_compute(double.Parse(txtHeight.Text), 50);
                var listHeight2 = new List<double>();
                listHeight2 = height_compute(double.Parse(txtHeight2.Text), 50);
                var listHeight3 = new List<double>();
                listHeight3 = height_compute(double.Parse(txtHeight3.Text), 50);

                // 二 生成速度的函数
                var listSpeed1 = new List<double>();
                listSpeed1 = speed_compute(double.Parse(txtSpeed.Text), 50);
                var listSpeed2 = new List<double>();
                listSpeed2 = speed_compute(double.Parse(txtSpeed2.Text), 50);
                var listSpeed3 = new List<double>();
                listSpeed3 = speed_compute(double.Parse(txtSpeed3.Text), 50);

                // 三 生成经纬度
                double aLongitude = double.Parse(txtSLongitude.Text);
                double aLatitude = double.Parse(txtSLatitude.Text);
                double desLongitude = double.Parse(txtDLongitude.Text);
                double desLatitude = double.Parse(txtDLatitude.Text);
                //double aLongitude = 117.0;
                //double aLatitude = 40.0;
                //double desLongitude = 130.0;
                //double desLatitude = 20.0;

                double d = (desLongitude - aLongitude) / 199;
                var listLongitude = new List<double>();
                for (double i = 0; i < 200; i++)
                {
                    listLongitude.Add(aLongitude + d * i);
                }

                double d1 = (desLatitude - aLatitude) / 199;
                var listLatitude1 = new List<double>();
                for (double i = 0; i < 200; i++)
                {
                    listLatitude1.Add(aLatitude + d1 * i);
                }

                Func<double, double> funcLatitude2 = x => Math.Pow(x / 199, 2);
                double dC = desLatitude - aLatitude;
                var listLatitude2 = new List<double>();
                for (double i = 0; i < 200; i++)
                {
                    listLatitude2.Add(aLatitude + dC * funcLatitude2(i));
                }

                Func<double, double> funcLatitude3 = x => Math.Log(1 + x / 199 * (Math.E - 1));
                double dS = desLatitude - aLatitude;
                var listLatitude3 = new List<double>();
                for (double i = 0; i < 200; i++)
                {
                    listLatitude3.Add(aLatitude + dS * funcLatitude3(i));
                }

                //生成表格
                form_forms(listHeight1, listHeight2, listHeight3, listSpeed1, listSpeed2, listSpeed3, listLongitude, listLatitude1, listLatitude2, listLatitude3);

            }
        }

        // time指达到最高高度所需要的时间
        private List<double> height_compute(double heightNum, double time)
        {
            // 一 生成高度的函数
            double b = heightNum / time * 2; 
            Func<double, double> funcHeight = x => -Math.Pow(x, 2) * b / time / 2 + b * x;

            //200个点 50个上抛 100个平飞 50个下抛
            var listHeight = new List<double>();
            for (double i = 0; i < time; i++)
            {
                listHeight.Add(funcHeight(i));
            }
            for (int i = 0; i < time * 2; i++)
            {
                listHeight.Add(heightNum);
            }
            for (int i = 0; i < time; i++)
            {
                listHeight.Add(funcHeight(time+i));
            }
            //foreach (var num in listHeight)
            //{
            //    Console.WriteLine(num);
            //}
            return listHeight;
        }

        private List<double> speed_compute(double speedNum, double time)
        {
            // 二 生成速度的函数
            double a = speedNum / time;
            Func<double, double> funcSpeed = x => a * x;

            //200个点 50个从零开始的匀加速 100个匀速直线 50个从V开始的匀加速
            var listSpeed = new List<double>();
            for (double i = 0; i < time; i++)
            {
                listSpeed.Add(funcSpeed(i));
            }
            for (int i = 0; i < time * 2; i++)
            {
                listSpeed.Add(speedNum);
            }
            for (int i = 0; i < time; i++)
            {
                listSpeed.Add(speedNum + funcSpeed(time+i));
            }
            //foreach (var num in listSpeed)
            //{
            //    Console.WriteLine(num);
            //}
            return listSpeed;
        }

        private void form_forms(List<double> listHeight1, List<double> listHeight2, List<double> listHeight3,
                                        List<double> listSpeed1, List<double> listSpeed2, List<double> listSpeed3,
                                        List<double> listLongitude, List<double> listLatitude1, List<double> listLatitude2, List<double> listLatitude3)
        {
            // 生成表格
            for (int i = 0; i < 200; i++)
            {
                conn.Open();
                string sql = "insert into df1(speed1, speed2, speed3, height1, height2, height3, longitude, latitude1, latitude2, latitude3) values("
                            + listSpeed1[i].ToString() + ", " + listSpeed2[i].ToString() + ", " + listSpeed3[i].ToString() + ", " 
                            + listHeight1[i].ToString() + ", " + listHeight2[i].ToString() + ", " + listHeight3[i].ToString() + ", "
                            + listLongitude[i].ToString() + ", " + listLatitude1[i].ToString() + ", " + listLatitude2[i].ToString() + ", " + listLatitude3[i].ToString() + ")";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            // 显示表格
            try
            {
                conn.Open();
                string sql = "select * from df1";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //MySqlDataReader reader = cmd.ExecuteReader();
                //while (reader.Read())
                //{
                //    MessageBox.Show(reader[0].ToString() + reader[1].ToString() + reader[2].ToString() + reader[3].ToString());
                //}
                //reader.Close();
                MySqlDataAdapter dbAdapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dbAdapter.Fill(ds);
                //Console.WriteLine(ds.Tables.ToString());
                dgvDisp.DataSource = ds.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }

    }
}
