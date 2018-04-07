using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FoodMis
{
    public partial class Zcaigou : UserControl
    {
        private SqlConnection conn;
        private SqlCommand command;

        public Zcaigou()
        {
            InitializeComponent();
            conn = new SqlConnection(@"data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");

        }

        private void Zcaigou_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int ID = random.Next(1000, 10000);
            textBox1C_number.Text = Convert.ToString(ID);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            textBox1C_name.Text = "";
            textBox1C_phone.Text = "";
            textBox1C_pass.Text = "";
            textBox1C_pass2.Text = "";
            Random random = new Random();
            int ID = random.Next(1000, 10000);
            textBox1C_number.Text = Convert.ToString(ID);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
                string check = "";
                string sql = "";
                int x = 1;
                check=textBox1C_number.Text;
                conn.Open();
                sql = "select * from view_Check where n1='" + check + "' or n2='" + check + "' or n3='" + check + "'";
                command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("用户重复，请重新选择身份/或重新选择此身份！");
                }
                else
                {
                    x = 0;
                }
                reader.Close();
                conn.Close();
                if (x == 0)
                {
                            if (textBox1C_name.Text == "" || textBox1C_phone.Text == "" || textBox1C_pass.Text == "" || textBox1C_pass2.Text == "")
                            {
                                MessageBox.Show("为空!");
                            }
                            else
                            {
                                if (!textBox1C_pass.Text.Equals(textBox1C_pass2.Text))
                                {
                                    MessageBox.Show("前后密码不一致！");
                                }
                                else
                                {
                                    string number = textBox1C_number.Text;
                                    string name = textBox1C_name.Text;
                                    string phone = textBox1C_phone.Text;
                                    string pass = textBox1C_pass.Text;
                                    try
                                    {
                                        string sql2 = "insert into buyer(number,buyer_name,phone,password) values ('" + number + "','" + name + "','" + phone + "','" + pass + "')";
                                        conn.Open();
                                        command = new SqlCommand(sql2, conn);
                                        command.ExecuteNonQuery();
                                        MessageBox.Show(this, "注册完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        conn.Close();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("发生错误！提示：" + ex.Message);
                                    }
                                }
                            }
                  
                }
        }

        private void textBox1C_number_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
