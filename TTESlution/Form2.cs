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
                cmd.CommandText = "truncate table tx1";
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
                // 一 生成高度的函数  要求 h >= 2500
                double b = double.Parse(txtHeight.Text) / 50 + 50; // h = -x**2 + b*x => b = (h+2500)/50
                //double b = 100;
                Func<double, double> funcHeight = x => -Math.Pow(x, 2) + b * x;

                //200个点 50个上抛 100个平飞 50个下抛
                var listHeight = new List<double>();
                for (double i = 0; i < 50; i++)
                {
                    listHeight.Add(funcHeight(i));
                }
                for (int i = 0; i < 100; i++)
                {
                    listHeight.Add(double.Parse(txtHeight.Text));
                }
                for (int i = 0; i < 50; i++)
                {
                    listHeight.Add(listHeight[49 - i]);
                }
                //foreach (var num in listHeight)
                //{
                //    Console.WriteLine(num);
                //}

                // 二 生成速度的函数
                double a = double.Parse(txtSpeed.Text) / 50; // v = a*t => a = v/50
                //double a = 10;
                Func<double, double> funcSpeed = x => a * x;

                //200个点 50个从零开始的匀加速 100个匀速直线 50个从V开始的匀加速
                var listSpeed = new List<double>();
                for (double i = 0; i < 50; i++)
                {
                    listSpeed.Add(funcSpeed(i));
                }
                for (int i = 0; i < 100; i++)
                {
                    listSpeed.Add(double.Parse(txtSpeed.Text));
                }
                for (int i = 0; i < 50; i++)
                {
                    listSpeed.Add(double.Parse(txtSpeed.Text)+listSpeed[i]);
                }
                //foreach (var num in listSpeed)
                //{
                //    Console.WriteLine(num);
                //}

                // 三 生成经纬度
                double aLongitude = double.Parse(txtSLongitude.Text);
                double aLatitude = double.Parse(txtSLatitude.Text);
                double desLongitude = double.Parse(txtDLongitude.Text);
                double desLatitude = double.Parse(txtDLatitude.Text);
                //double aLongitude = 117.0;
                //double aLatitude = 40.0;
                //double desLongitude = 130.0;
                //double desLatitude = 20.0;

                //200个点 经度均匀变化
                double d1 = (desLongitude - aLongitude) / 199;
                var listLongitude = new List<double>();
                for (double i = 0; i < 200; i++)
                {
                    listLongitude.Add(aLongitude + d1 * i);
                }
                //foreach (var num in listLongitude)
                //{
                //    Console.WriteLine(num);
                //}

                //200个点 纬度 直线
                double d2 = (desLatitude - aLatitude) / 199;
                var listLatitude = new List<double>();
                for (double i = 0; i < 200; i++)
                {
                    listLatitude.Add(aLatitude + d2 * i);
                }
                //foreach (var num in listLatitude)
                //{
                //    Console.WriteLine(num);
                //}

                // 200个点 纬度 C
                // 函数 x**3 可改变3这个数字
                Func<double, double> funcLatitudeC = x => Math.Pow(x / 199, 3);
                double dC = desLatitude - aLatitude;
                var listLatitudeC = new List<double>();
                for (double i = 0; i < 200; i++)
                {
                    listLatitudeC.Add(aLatitude + dC * funcLatitudeC(i));
                }
                //foreach (var num in listLatitudeC)
                //{
                //    Console.WriteLine(num);
                //}

                // 200个点 纬度 S
                // 正弦函数 需保证周期为 （2n+1/2) 取n=1即2.5
                Func<double, double> funcLatitudeS = x => Math.Sin(x / 199 * Math.PI * 2.5);
                double dS = desLatitude - aLatitude;
                var listLatitudeS = new List<double>();
                for (double i = 0; i < 200; i++)
                {
                    listLatitudeS.Add(aLatitude + dS * funcLatitudeS(i));
                }
                //foreach (var num in listLatitudeS)
                //{
                //    Console.WriteLine(num);
                //}

                // 生成表格
                for (int i = 0; i < 200; i++)
                {
                    conn.Open();
                    string sql = "insert into tx1(speed, height, longitude, latitude, latitudec, latitudes) values(" + listSpeed[i].ToString() + ", " + listHeight[i].ToString() + ", "
                                    + listLongitude[i].ToString() + ", " + listLatitude[i].ToString() + ", " + listLatitudeC[i].ToString() + ", " + listLatitudeS[i].ToString() + ")";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                // 显示表格
                try
                {
                    conn.Open();
                    string sql = "select * from tx1";
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
}
