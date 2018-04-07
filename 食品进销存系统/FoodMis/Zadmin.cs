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
    public partial class Zadmin : UserControl
    {
        public Zadmin()
        {
            InitializeComponent();
            conn = new SqlConnection(@"data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");

        }

        private SqlConnection conn;
        private SqlCommand command;

        private void buttonClose_Click(object sender, EventArgs e)
        {
            textBox_username.Text = "";
            textBox_password.Text = "";
            textBox_password2.Text = "";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
                string check = "";
                string sql = "";
                int x=-1;
                conn.Open();
                check = textBox_username.Text;
                sql = "select * from view_Check where n1='" + check + "' or n2='" + check + "' or n3='" + check + "'";
                command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
               if(reader.Read())
                {
                    x=1;
                    MessageBox.Show("用户名已存在，请重新选择身份/或重新选择此身份！");
                }
                reader.Close();
                conn.Close();
                if (x == -1)
                {
                            if (textBox_username.Text == "")
                            {
                                MessageBox.Show("用户名为空！");
                            }
                            else if (textBox_password.Text == "")
                            {
                                MessageBox.Show("密码为空！");
                            }
                            else if (textBox_password2.Text == "")
                            {
                                MessageBox.Show("请再次输入密码！");
                            }
                            else if (!textBox_password2.Text.Equals(textBox_password.Text))
                            {
                                MessageBox.Show("前后两次输入的密码不同！");
                            }
                            else
                            {
                                String username = textBox_username.Text;
                                String password = textBox_password.Text;
                                try
                                {
                                    string sql2 = "insert into admin(username,password) values ('" + username + "','" + password + "')";
                                    conn.Open();
                                    command = new SqlCommand(sql2, conn);
                                    command.ExecuteNonQuery();
                                    MessageBox.Show(this, "注册完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    conn.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("错误！提示：" + ex.Message);
                                }
                            }
                }
        }

        private void Zadmin_Load(object sender, EventArgs e)
        {

        }
    }
}
