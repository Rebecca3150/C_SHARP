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
    public partial class 出库单详情 : Skin_Mac
    {

        public static String id="";

        private SqlConnection conn;
        private SqlCommand command;

        public 出库单详情()
        {
            InitializeComponent();
            conn = new SqlConnection(@"data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");

        }

        private void 出库单详情_Load(object sender, EventArgs e)
        {
            if (id == "")
            {
                label1.Text = "未指定编号！";
            }
            else
            {
                label1.Text = "销售订单编号： " + id;
                conn.Open();//开启连接

                String sql = "select * from sales_form where sales_id='" + id + "'";
                command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    ListViewItem item = listView1.Items.Add((listView1.Items.Count + 1) + "");
                    item.SubItems.Add(Convert.ToString(reader["goods_id"]));
                    item.SubItems.Add(Convert.ToString(reader["good_name"]));
                    item.SubItems.Add(Convert.ToString(reader["original_price"]));
                    item.SubItems.Add(Convert.ToString(reader["price"]));
                    item.SubItems.Add(Convert.ToString(reader["num"]));
                    item.EnsureVisible();//让listView始终显示最新的一行数据
                }
                reader.Close();
                conn.Close();
            }
           
        }
    }
}
