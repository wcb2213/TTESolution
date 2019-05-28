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
    public partial class Form1 : Form
    {
        private static string mysqlCon = "Server=localhost;Uid=root;Pwd=221358;Database=ex1";//选择数据库，用户名及密码
        private MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(mysqlCon);
            MessageBox.Show("支持增，删，改和查看表格四个功能", "连接成功");

            btnDISP_Click(null, null);
            string 列名 = "类型\t" + "ID\t" + "Speed\t" + "X\t" + "Y";
            lstModifyLog.Items.Add(列名.ToString());
        }

        private void btnDISP_Click(object sender, EventArgs e)
        {
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "insert into tx1(speed, positionX, positionY) values(" + txtSpeed.Text + ", " + txtX.Text + ", " + txtY.Text + ")";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //MessageBox.Show(cmd.ExecuteNonQuery().ToString());
                if (cmd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("添加成功");
                    lstModifyLog.Items.Add("添加\t" + " \t" + txtSpeed.Text + "\t" + txtX.Text + "\t" + txtY.Text);
                    txtID.Text = null;
                    txtSpeed.Text = null;
                    txtX.Text = null;
                    txtY.Text = null;
                    //btnCollectDbTest_Click(null, null);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                btnDISP_Click(null, null);
            }
        }

        private void btnDelect_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "delete from tx1 where ID=" + txtID.Text;
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //MessageBox.Show(cmd.ExecuteNonQuery().ToString());
                if (cmd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("删除成功");
                    lstModifyLog.Items.Add("删除\t" + txtID.Text);
                    txtID.Text = null;
                    txtSpeed.Text = null;
                    txtX.Text = null;
                    txtY.Text = null;
                    //btnCollectDbTest_Click(null, null);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                btnDISP_Click(null, null);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string strSpeed = "", strX = "", strY = "";
            try
            {
                conn.Open();
                string sql = "select * from tx1 where id=" + txtID.Text;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    strSpeed = "speed=" + reader[1].ToString() + ", ";
                    strX = "positionX=" + reader[2].ToString() + ", ";
                    strY = "positionY=" + reader[3].ToString() + " ";
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }

            try
            {
                if (txtSpeed.Text != "")
                {
                    strSpeed = "speed=" + txtSpeed.Text + ", ";
                }
                if (txtX.Text != "")
                {
                    strX = "positionX=" + txtX.Text + ", ";
                }
                if (txtY.Text != "")
                {
                    strY = "positionY=" + txtY.Text + " ";
                }
                conn.Open();
                string sql = "UPDATE tx1 SET " + strSpeed + strX + strY + "WHERE ID=" + txtID.Text;
                //Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //MessageBox.Show(cmd.ExecuteNonQuery().ToString());
                if (cmd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("修改成功");
                    lstModifyLog.Items.Add("修改\t" + txtID.Text + "\t" + txtSpeed.Text + "\t" + txtX.Text + "\t" + txtY.Text);
                    txtID.Text = null;
                    txtSpeed.Text = null;
                    txtX.Text = null;
                    txtY.Text = null;
                    //btnCollectDbTest_Click(null, null);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                btnDISP_Click(null, null);
            }
        }
    }
}
