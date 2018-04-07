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
    public partial class X收款单 : UserControl
    {
        private SqlConnection conn;
        private SqlCommand command;
        public static int XS;

        public X收款单()
        {
            InitializeComponent();
            conn = new SqlConnection(@"data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");

        }

        private void X收款单_Load(object sender, EventArgs e)
        {
            conn.Open();

            string sql1 = "select * from receivables";
            command = new SqlCommand(sql1, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = listView1.Items.Add((listView1.Items.Count + 1) + "");
                item.SubItems.Add(Convert.ToString(reader["id"]));
                item.SubItems.Add(Convert.ToString(reader["buyer_name"]));
                item.SubItems.Add(Convert.ToString(reader["info"]));
                item.SubItems.Add(Convert.ToString(reader["sales_id"]));
                item.SubItems.Add(Convert.ToString(reader["salesperson_name"]));
                item.SubItems.Add(Convert.ToString(reader["type"]));
                item.SubItems.Add(Convert.ToString(reader["a_money"]));
                item.SubItems.Add(Convert.ToString(reader["y_money"]));
                item.SubItems.Add(Convert.ToString(reader["status"]));

              

                item.EnsureVisible();//让listView始终显示最新的一行数据
            }
            reader.Close();
            conn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)//如果已经选择了某行数据
            {
                 int id=Convert.ToInt32(listView1.SelectedItems[0].SubItems[1].Text);
                 String buyer_name=listView1.SelectedItems[0].SubItems[2].Text;
                 int sales_id=Convert.ToInt32(listView1.SelectedItems[0].SubItems[4].Text);
                 String salesperson_name=listView1.SelectedItems[0].SubItems[5].Text;
                 int a_money=Convert.ToInt32(listView1.SelectedItems[0].SubItems[7].Text);
                 String show=Convert.ToString(Convert.ToInt32(listView1.SelectedItems[0].SubItems[7].Text)-Convert.ToInt32(listView1.SelectedItems[0].SubItems[8].Text));
                 String status=listView1.SelectedItems[0].SubItems[9].Text;//结算状态
                String type=listView1.SelectedItems[0].SubItems[6].Text;//结算方式
                if(status=="支付完成")//状态：支付完成
                {
                    XS = 2;//支付完成
                }
                if (status == "未支付")//状态：未支付
                {
                    XS = 0;
                    X结算.id = id;
                    X结算.buyer_name = buyer_name;
                    X结算.sales_id = sales_id;
                    X结算.salesperson_name = salesperson_name;
                    X结算.a_money = a_money;
                    X结算.show = show;
                }
                if(status=="正在支付"){//状态：正在支付
                    XS = 1;
                    X结算.id = id;
                    X结算.buyer_name = buyer_name;
                    X结算.sales_id = sales_id;
                    X结算.salesperson_name = salesperson_name;
                    X结算.a_money = a_money;
                    X结算.show = show;
                }

              
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            X结算 js = new X结算();

            if (XS == 2)
            {
                //支付完成
                MessageBox.Show("支付已完成，无需再支付！");
            }
            if (XS == 0)
            {
                //未支付
             
                X结算.SS = 0;
                js.ShowDialog();
            }
            if (XS == 1)
            {
                //正在支付
                X结算.SS = 1;

                js.ShowDialog();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XS = 0;
            listView1.Items.Clear();
            conn.Open();

            string sql1 = "select * from receivables";
            command = new SqlCommand(sql1, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = listView1.Items.Add((listView1.Items.Count + 1) + "");
                item.SubItems.Add(Convert.ToString(reader["id"]));
                item.SubItems.Add(Convert.ToString(reader["buyer_name"]));
                item.SubItems.Add(Convert.ToString(reader["info"]));
                item.SubItems.Add(Convert.ToString(reader["sales_id"]));
                item.SubItems.Add(Convert.ToString(reader["salesperson_name"]));
                item.SubItems.Add(Convert.ToString(reader["type"]));
                item.SubItems.Add(Convert.ToString(reader["a_money"]));
                item.SubItems.Add(Convert.ToString(reader["y_money"]));
                item.SubItems.Add(Convert.ToString(reader["status"]));



                item.EnsureVisible();//让listView始终显示最新的一行数据
            }
            reader.Close();
            conn.Close();

        }
    }
}
