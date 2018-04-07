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
    public partial class X销售情况 : UserControl
    {
        private SqlConnection conn;
        private SqlCommand command;


        public X销售情况()
        {
            InitializeComponent();
            //显示所有订单
            conn = new SqlConnection(@" data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");
      
        }

        private void X销售情况_Load(object sender, EventArgs e)
        {
            conn.Open();

            string sql1 = "select * from sales";
            command = new SqlCommand(sql1, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = listView1.Items.Add((listView1.Items.Count + 1) + "");
                item.SubItems.Add(Convert.ToString(reader["id"]));
                item.SubItems.Add(Convert.ToString(reader["customer_name"]));
                item.SubItems.Add(Convert.ToString(reader["salesperson_name"]));
                item.SubItems.Add(Convert.ToString(reader["money"]));
                item.SubItems.Add(Convert.ToString(reader["date"]));
            
                item.EnsureVisible();//让listView始终显示最新的一行数据
            }
            reader.Close();


            conn.Close();
        }
    }
}
