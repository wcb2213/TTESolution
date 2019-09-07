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
using System.IO;

namespace TTESlution
{
    public partial class Form4 : Form
    {
        private static string mysqlCon = "Server=localhost;Uid=root;Pwd=221358;Database=ex1";//选择数据库，用户名及密码
        private MySqlConnection conn;
        public static string database_name;
        public static string parameters;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(mysqlCon);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (database1.Text== "" | txtHeight.Text == "" | txtSpeed.Text == "" | txtSLongitude.Text == "" | txtSLatitude.Text == "" | txtDLongitude.Text == "" | txtDLatitude.Text == ""
                | txt_time1.Text == "" | txt_time2.Text == "" | txt_time3.Text == "")
            {
                MessageBox.Show("请补全输入数据");
            }
            else
            {
                database_name = database1.Text;
                //撤除表格
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "truncate table " + database_name;
                    //cmd.CommandText = "delete from tx1";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                //载入等待时间，上升（下降）时间，平飞时间
                int time1 = int.Parse(txt_time1.Text);
                int time2 = int.Parse(txt_time2.Text);
                int time3 = int.Parse(txt_time3.Text);

                //总时间为500秒
                var time = new List<double>();
                for (int i = 0; i < 500; i++)
                {
                    time.Add((double)i);
                }

                // 一 生成指令
                var command = command_compute(time1, time2, time3);

                // 二 生成高度的函数  3种
                var listHeight = height_compute(double.Parse(txtHeight.Text), time1, time2, time3);
                

                // 三 生成速度的函数
                var listSpeed = speed_compute(double.Parse(txtSpeed.Text), time1, time2, time3);
                

                // 四 生成经纬度
                double aLongitude = double.Parse(txtSLongitude.Text);
                double aLatitude = double.Parse(txtSLatitude.Text);
                double desLongitude = double.Parse(txtDLongitude.Text);
                double desLatitude = double.Parse(txtDLatitude.Text);


                //生成经度 1种
                var listLongitude = new List<double>();
                double d1 = (desLongitude - aLongitude) / (time2*2+time3-1);
                for (int i = 0; i < time1; i++)
                {
                    listLongitude.Add(aLongitude);
                }
                for (double i = 0; i < time2 * 2 + time3; i++)
                {
                    listLongitude.Add(Math.Round(aLongitude + d1 * i, 4));
                }
                for (int i = 0; i < 500-time1-time2*2-time3; i++)
                {
                    listLongitude.Add(desLongitude);
                }

                //生成纬度 3种
                var listLatitude = latitude_compute(aLongitude, aLatitude, desLongitude, desLatitude, database_name, time1, time2, time3);


                // 五 显示表格
                form_forms(time, command, listSpeed, listHeight, listLongitude, listLatitude);
            }
        }

        private List<double> command_compute(int time1, int time2, int time3)
        {
            // 1代表等待，2代表上升，3代表平飞，4代表下降，5代表导弹已击中目的地
            var command = new List<double>();
            for (int i = 0; i < time1; i++)
            {
                command.Add((double)1);
            }
            for (int i = 0; i < time2; i++)
            {
                command.Add((double)2);
            }
            for (int i = 0; i < time3; i++)
            {
                command.Add((double)3);
            }
            for (int i = 0; i < time2; i++)
            {
                command.Add((double)4);
            }
            for (int i = 0; i < 500 - time1 - time2 * 2 - time3; i++)
            {
                command.Add((double)5);
            }
            //foreach (var num in listHeight)
            //{
            //    Console.WriteLine(num);
            //}
            return command;
        }

        private List<double> height_compute(double heightNum, int time1, int time2, int time3)
        {
            // 生成高度的函数 3种
            var listHeight = new List<double>();
            double b = heightNum / (time2 / 2);
            for (int i = 0; i < time1; i++)
            {
                listHeight.Add(0);
            }

            Func<double, double> funcHeight;
            if (database_name == "tx1") //10:50:250:50:140
            {
                funcHeight = x => -Math.Pow(x, 2) * b / (time2 * 2) + b * x;
                for (double i = 0; i < time2; i++)
                {

                    listHeight.Add(Math.Round(funcHeight(i), 2));
                }
                for (int i = 0; i < time3; i++)
                {
                    listHeight.Add(double.Parse(txtHeight.Text));
                }
                for (int i = 0; i < time2; i++)
                {
                    listHeight.Add(Math.Round(funcHeight(time2 + i), 2));
                }
            }
            else if (database_name == "tx2") //30:100:200:100:70
            {
                funcHeight = x => -Math.Pow(x, 2) * b / (time2 * 2) + b * x;
                for (double i = 0; i < time2; i++)
                {
                    listHeight.Add(Math.Round(funcHeight(i), 2));
                }
                for (int i = 0; i < time3; i++)
                {
                    listHeight.Add(double.Parse(txtHeight.Text));
                }
                for (int i = 0; i < time2; i++)
                {
                    listHeight.Add(Math.Round(funcHeight(time2 + i), 2));
                }
            }
            else if (database_name == "tx3") //60:150:100:150:40
            {
                funcHeight = x => -Math.Pow(x, 2) * b / (time2 * 2) + b * x;
                for (double i = 0; i < time2; i++)
                {
                    listHeight.Add(Math.Round(funcHeight(i), 2));
                }
                for (int i = 0; i < time3; i++)
                {
                    listHeight.Add(double.Parse(txtHeight.Text));
                }
                for (int i = 0; i < time2; i++)
                {
                    listHeight.Add(Math.Round(funcHeight(time2 + i), 2));
                }
            }

            for (int i = 0; i < 500 - time1 - time2 * 2 - time3; i++)
            {
                listHeight.Add(0);
            }
            return listHeight;
        }

        private List<double> speed_compute(double speedNum, int time1, int time2, int time3)
        {
            // 生成速度的函数
            double a = speedNum / time2;
            Func<double, double> funcSpeed = x => a * x;

            var listSpeed = new List<double>();
            for (int i = 0; i < time1; i++)
            {
                listSpeed.Add(0);
            }
            for (double i = 0; i < time2; i++)
            {
                listSpeed.Add(Math.Round(funcSpeed(i), 2));
            }
            for (int i = 0; i < time3; i++)
            {
                listSpeed.Add(Math.Round(speedNum, 2));
            }
            for (int i = 0; i < time2; i++)
            {
                listSpeed.Add(Math.Round(speedNum + funcSpeed(i), 2));
            }
            for (int i = 0; i < 500 - time1 - time2 * 2 - time3; i++)
            {
                listSpeed.Add(0);
            }
            //foreach (var num in listSpeed)
            //{
            //    Console.WriteLine(num);
            //}
            return listSpeed;
        }

        private List<double> latitude_compute(double aLongitude, double aLatitude, double desLongitude, double desLatitude,
            string database_name, int time1, int time2, int time3)
        {
            // 生成纬度的函数
            var listLatitude = new List<double>();
            double d = desLatitude - aLatitude;
            for (int i = 0; i < time1; i++)
            {
                listLatitude.Add(aLatitude);
            }
            Func<double, double> funcLatitude;
            if (database_name == "tx1") //10:50:250:50:140
            {
                funcLatitude = x => x / (time2 * 2 + time3 - 1);
                for (double i = 0; i < time2 * 2 + time3; i++)
                {
                    listLatitude.Add(Math.Round(aLatitude + d * funcLatitude(i), 4));
                }
            }
            else if (database_name == "tx2") //30:100:200:100:70
            {
                funcLatitude = x => Math.Pow(x / (time2 * 2 + time3 - 1), 2);
                for (double i = 0; i < time2 * 2 + time3; i++)
                {
                    listLatitude.Add(Math.Round(aLatitude + d * funcLatitude(i), 4));
                }
            }
            else if (database_name == "tx3") //60:150:100:150:40
            {
                funcLatitude = x => Math.Log(1 + x / (time2 * 2 + time3 - 1) * (Math.E - 1));
                for (double i = 0; i < time2 * 2 + time3; i++)
                {
                    listLatitude.Add(Math.Round(aLatitude + d * funcLatitude(i), 4));
                }
            }
            for (int i = 0; i < 500 - time1 - time2 * 2 - time3; i++)
            {
                listLatitude.Add(desLatitude);
            }
            //foreach (var num in listHeight)
            //{
            //    Console.WriteLine(num);
            //}
            return listLatitude;
        }

        private void form_forms(List<double> time, List<double> command, List<double> listSpeed, List<double> listHeight, List<double> listLongitude, List<double> listLatitude)
        {
            // 生成表格
            conn.Open();
            for (int i = 0; i < 500; i++)
            {
                string sql = "insert into " + database_name + "(time, command, speed, height, longitude, latitude) values(" + time[i].ToString() + ", " + command[i].ToString() + ", " + listSpeed[i].ToString() + ", " + listHeight[i].ToString() + ", "
                                + listLongitude[i].ToString() + ", " + listLatitude[i].ToString() + ")";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
            // 显示表格
            try
            {
                conn.Open();

                string sql = "select * from " + database_name;

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

        private void btn_save_para_Click(object sender, EventArgs e)
        {
            if (database1.Text == "" | txtHeight.Text == "" | txtSpeed.Text == "" | txtSLongitude.Text == "" | txtSLatitude.Text == "" | txtDLongitude.Text == "" | txtDLatitude.Text == ""
                | txt_time1.Text == "" | txt_time2.Text == "" | txt_time3.Text == "")
            {
                MessageBox.Show("请补全输入数据");
            }
            else
            {
                parameters = txtHeight.Text + '\n' + txtSpeed.Text + '\n' + txtSLongitude.Text + '\n' + txtSLatitude.Text + '\n' + txtDLongitude.Text + '\n' + txtDLatitude.Text
                    + '\n' + txt_time1.Text + '\n' + txt_time2.Text + '\n' + txt_time3.Text + '\n' + database1.Text;
                try
                {
                    //string name = this.textBox1.Text; //文件名
                    string path = string.Empty; //文件路径
                    SaveFileDialog save = new SaveFileDialog();
                    if (save.ShowDialog() == DialogResult.OK)
                        path = save.FileName;
                    if (path != string.Empty)
                    {
                        using (System.IO.FileStream file = new System.IO.FileStream(path, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                        {
                            using (System.IO.TextWriter text = new System.IO.StreamWriter(file, System.Text.Encoding.Default))
                            {
                                text.Write(parameters);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void btn_load_para_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                //textBox1.Text = file;
                //MessageBox.Show("已选择文件:" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.IO.StreamReader st;
                st = new System.IO.StreamReader(file, System.Text.Encoding.UTF8);
                //UTF-8通用编码
                string items = st.ReadToEnd();

                string[] str = items.Split(new char[] { '\n' });
                txtHeight.Text = str[0];
                txtSpeed.Text = str[1];
                txtSLongitude.Text = str[2];
                txtSLatitude.Text = str[3];
                txtDLongitude.Text = str[4];
                txtDLatitude.Text = str[5];
                txt_time1.Text = str[6];
                txt_time2.Text = str[7];
                txt_time3.Text = str[8];
                database1.Text = str[9];
                st.Close();
            }
        }
        
    }
}       
