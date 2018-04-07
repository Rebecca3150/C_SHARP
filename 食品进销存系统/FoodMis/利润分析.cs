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
    public partial class 利润分析 : UserControl
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataSet dataSet;

        public 利润分析()
        {
            InitializeComponent();
            conn = new SqlConnection(@"data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");
        }

        private void 利润分析_Load(object sender, EventArgs e)
        {
            int chengben = 0;//总成本
           int profit = 0;//总盈利

            //LV.Items[2].SubItems[0].Text=2 
            conn.Open();
            List<int> id = new List<int>();
            string sql1 = "select * from money";
            command = new SqlCommand(sql1, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = listView1.Items.Add((listView1.Items.Count + 1) + "");
                item.SubItems.Add(Convert.ToString(reader["goods_id"]));
                item.SubItems.Add(Convert.ToString(reader["purchased_num"]));
                item.SubItems.Add(Convert.ToString(reader["no_num"]));
                item.SubItems.Add(Convert.ToString(reader["profit"]));
                item.SubItems.Add("空");
                item.SubItems.Add("0");
                id.Add(Convert.ToInt32(reader["goods_id"]));//GOODS_ID数组

                item.EnsureVisible();//让listView始终显示最新的一行数据
            }
            reader.Close();
         
            
            
            
            //取出listView中的值
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    ListViewItem item = listView1.Items[i];
                    //;//goods_id

                    string sql = "select * from commodity_stock where goods_id='" + Convert.ToInt32(item.SubItems[1].Text) + "'";
                    adapter = new SqlDataAdapter(sql, conn);
                    dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    item.SubItems[5].Text = dataSet.Tables[0].Rows[0]["commodity_name"].ToString();
                    item.SubItems[6].Text = dataSet.Tables[0].Rows[0]["original_price"].ToString();
                   
                }
                conn.Close();

                //取出listView中的值为了得到总成本
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    ListViewItem item = listView1.Items[i];
                    int cc2 = Convert.ToInt32(item.SubItems[2].Text);//已买数量
                    chengben += Convert.ToInt32(item.SubItems[6].Text) * cc2;

                    int profit2 = Convert.ToInt32(item.SubItems[4].Text);
                    int ch = Convert.ToInt32(item.SubItems[6].Text);
                    int xy = (profit2 / cc2+ch)*cc2;
                    profit += xy;

                }





         




            //chart1
            List<string> xData = new List<string>() { "成本", "盈利" };
            List<int> yData = new List<int>() { chengben, profit };
            chart1.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            chart1.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
            chart1.Series[0].Points.DataBindXY(xData, yData);


            
             //chart2的初始化
             int num = 0;
             List<string> xxData = new List<string>();
            List<int> yyData = new List<int>();
            string name = "";
            int mon = 0;
              for (int i = 0; i < listView1.Items.Count; i++)
                {
                    ListViewItem item = listView1.Items[i];
                   //goods_id
                    name=  item.SubItems[5].Text;
                    mon = Convert.ToInt32(item.SubItems[4].Text);
                     xxData.Add(name);
                     yyData.Add(mon);
                }
             chart2.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
              chart2.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
              chart2.Series[0].Points.DataBindXY(xxData, yyData);
        }





        private void button_up_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear(); 

            listView1.Items.Clear();
            int chengben = 0;//总成本
            int profit = 0;//总盈利

            //LV.Items[2].SubItems[0].Text=2 
            conn.Open();
            List<int> id = new List<int>();
            string sql1 = "select * from money";
            command = new SqlCommand(sql1, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = listView1.Items.Add((listView1.Items.Count + 1) + "");
                item.SubItems.Add(Convert.ToString(reader["goods_id"]));
                item.SubItems.Add(Convert.ToString(reader["purchased_num"]));
                item.SubItems.Add(Convert.ToString(reader["no_num"]));
                item.SubItems.Add(Convert.ToString(reader["profit"]));
                item.SubItems.Add("空");
                item.SubItems.Add("0");
                id.Add(Convert.ToInt32(reader["goods_id"]));//GOODS_ID数组

                item.EnsureVisible();//让listView始终显示最新的一行数据
            }
            reader.Close();




            //取出listView中的值
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                ListViewItem item = listView1.Items[i];
                //;//goods_id

                string sql = "select * from commodity_stock where goods_id='" + Convert.ToInt32(item.SubItems[1].Text) + "'";
                adapter = new SqlDataAdapter(sql, conn);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                item.SubItems[5].Text = dataSet.Tables[0].Rows[0]["commodity_name"].ToString();
                item.SubItems[6].Text = dataSet.Tables[0].Rows[0]["original_price"].ToString();
            }
            conn.Close();


            //取出listView中的值为了得到总成本
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                ListViewItem item = listView1.Items[i];
                int cc2 = Convert.ToInt32(item.SubItems[2].Text);//已买数量
                chengben += Convert.ToInt32(item.SubItems[6].Text) * cc2;

                int profit2 = Convert.ToInt32(item.SubItems[4].Text);
                int ch = Convert.ToInt32(item.SubItems[6].Text);
                int xy = (profit2 / cc2 + ch) * cc2;
                profit += xy;

            }









            //chart1
            List<string> xData = new List<string>() { "成本", "盈利" };
            List<int> yData = new List<int>() { chengben, profit };
            chart1.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            chart1.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
            chart1.Series[0].Points.DataBindXY(xData, yData);



            //chart2的初始化
            int num = 0;
            List<string> xxData = new List<string>();
            List<int> yyData = new List<int>();
            string name = "";
            int mon = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                ListViewItem item = listView1.Items[i];
                //goods_id
                name = item.SubItems[5].Text;
                mon = Convert.ToInt32(item.SubItems[4].Text);
                xxData.Add(name);
                yyData.Add(mon);
            }
            chart2.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            chart2.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
            chart2.Series[0].Points.DataBindXY(xxData, yyData);


        }

      

      
    }
}
