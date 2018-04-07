using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CCWin;

namespace FoodMis
{
    public partial class LoginForm : Skin_Mac
    {
        public LoginForm()
        {
            InitializeComponent();
            conn = new SqlConnection(@"data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");

        }

        private SqlConnection conn;
        private SqlCommand command;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            int a=0;//0代表超级管理员  1代表管理员    2代表库存管理员     3代表采购员    4代表销售员
            String u = "";
            String p = "";
            int s=0;
            string sql = "";
            int num=0;//未查询到的次数
           

            String username = textBox_username.Text;
            String password = textBox_password.Text;

            conn.Open();

            //查询admin表
            sql = "select * from admin where username='" + username + "' and password='"+password+"'";
            //6.选择Command的适合方法
            command = new SqlCommand(sql, conn);
             SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
             {
                 u = Convert.ToString(reader["username"]);
                 p = Convert.ToString(reader["password"]);
                 s = Convert.ToInt32(reader["status"]);


                 if (u == "admin" && p == "admin" && s == 1)
                 {
                     a = 0;//身份为超级管理员

                     FSupMainForm.Username = textBox_username.Text;
                     FSupMainForm.Password = textBox_password.Text;

                 }
                 else
                 {
                     if (s == 0)
                     {
                         a = 1;//身份为普通管理员
                         FAdminForm.Username = textBox_username.Text;
                         FAdminForm.Password = textBox_password.Text;
                     }
                     else
                     {
                         a = 2;//身份为仓库管理员
                         FKucunForm.Username = textBox_username.Text;
                         FKucunForm.Password = textBox_password.Text;
                     }

                  }

                
                
                /*
                this.Visible = false;
                //设置窗体DialogResult值
                this.DialogResult = DialogResult.OK;
                this.Close();   //关闭窗体
            */
             }else{

                 num++;
               
            }
           reader.Close();
            
            
            //查询采购员表
           sql = "select * from buyer where number='" + username + "' and password='" + password + "'";
           //6.选择Command的适合方法
           command = new SqlCommand(sql, conn);
           SqlDataReader reader2 = command.ExecuteReader();
           if (reader2.Read())
           {
                   a = 3;//身份为采购员
                   FBuyerForm.NAME = Convert.ToString(reader2["buyer_name"]);
                   FBuyerForm.Username = textBox_username.Text;
                   FBuyerForm.Password = textBox_password.Text;
           }
           else
           {
               num++;
           }
           reader2.Close();



           //查询销售员表
           sql = "select * from salesperson where number='" + username + "' and password='" + password + "'";
           //6.选择Command的适合方法
           command = new SqlCommand(sql, conn);
           SqlDataReader reader3 = command.ExecuteReader();
           if (reader3.Read())
           {
               a = 4;//身份为销售员
               FSaleForm.NAME = Convert.ToString(reader3["salesperson_name"]);
               FSaleForm.Username = textBox_username.Text;
               FSaleForm.Password = textBox_password.Text;
           }
           else
           {
               num++;
           }
           reader3.Close();
            conn.Close();



            //判断
            if (num == 3)
            {
                //密码有误或其他错误
                 MessageBox.Show("登录失败！");
            }
            else
            {
                Program.s = a;

                this.Visible = false;
                //设置窗体DialogResult值
                this.DialogResult = DialogResult.OK;
                this.Close();   //关闭窗体
            }
          
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void link_add_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
        }

    
    }
}
