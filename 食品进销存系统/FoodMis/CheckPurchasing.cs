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
    public partial class CheckPurchasing : UserControl
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        DataSet dataSet;

        int i, start;//i为总行数，start为起始位置
        int size = 4;//定义一个每页显示的行数


        public CheckPurchasing()
        {
            InitializeComponent();
            conn = new SqlConnection(@"data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");

            Initialize();
        }

        public void Initialize()
        {
            string sql = "select id,purchasing_name,original_price,Num,buyer_name,salesperson_name,date from purchasing ";
            conn.Open();
            adapter = new SqlDataAdapter(sql, conn);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            dataGridView1.Columns[0].HeaderText = "订单编号";
            dataGridView1.Columns[1].HeaderText = "物品名称";
            dataGridView1.Columns[2].HeaderText = "单价";
            dataGridView1.Columns[3].HeaderText = "数量";
            dataGridView1.Columns[4].HeaderText = "采购员";
            dataGridView1.Columns[5].HeaderText = "供应商";
            dataGridView1.Columns[6].HeaderText = "日期";

            i = dataSet.Tables[0].Rows.Count;//总的行数或者记录数
            show(0, size);//每页显示4条记录
            start = 0;//第一行

            conn.Close();
        }

        //每页显示记录数j-i+1条
        public void show(int i, int j)
        {

            //因为沿用的就是check_Click(object sender, EventArgs e)函数中的adapter,因此不必连接数据库 重新查询
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, i, j, "purchasing");//把数据库表中的从i开始一共取j条记录数用来填充数据集
            dataGridView1.DataSource = dataSet.Tables["purchasing"];//ListData为datagridview控件的name属性

            //如果没有查询到数据
            if (dataSet.Tables[0].Rows.Count < 1)
            {
                MessageBox.Show(this, "抱歉,没有查找到相关内容！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dataGridView1.DataSource=null; 可以让dataGridView1还原到最初的样子。
                while (this.dataGridView1.Rows.Count != 1) { this.dataGridView1.Rows.RemoveAt(0); }//此句则可以只是清空数据，但不删除头行 - - 保存列标题
            }
            else
            {

                dataGridView1.DataSource = dataSet.Tables[0];
                dataGridView1.Columns[0].HeaderText = "订单编号";
                dataGridView1.Columns[1].HeaderText = "物品名称";
                dataGridView1.Columns[2].HeaderText = "单价";
                dataGridView1.Columns[3].HeaderText = "数量";
                dataGridView1.Columns[4].HeaderText = "采购员";
                dataGridView1.Columns[5].HeaderText = "供应商";
                dataGridView1.Columns[6].HeaderText = "日期";

            }



            dataSet = null;//清空数据集


        }




        private void CheckPurchasing_Load(object sender, EventArgs e)
        {

        }

        private void check_Click(object sender, EventArgs e)
        {

            string sql = "select id,purchasing_name,original_price,num,buyer_name,salesperson_name,date from purchasing where purchasing_name like '%" + Purchasing_name.Text + "%'";
            conn.Open();
            adapter = new SqlDataAdapter(sql, conn);
            dataSet = new DataSet();
            adapter.Fill(dataSet);

            i = dataSet.Tables[0].Rows.Count;//总的行数或者记录数
            start = 0;//第一行
            show(start, size);//每页显示4条记录


            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (start == 0)
            {
                MessageBox.Show("已经是第一页");

            }
            else
            {
                dataGridView1.DataSource = null;//清空数据
                start = 0;
                show(start, size);//调用show函数
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (start == 0)
            {
                MessageBox.Show("已经是第一页");


            }
            else
            {
                dataGridView1.DataSource = null;
                start -= size;
                show(start, size);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int yuShu = i % size;
            if (yuShu == 0)
            {
                if (start == i - size) MessageBox.Show("已经到达最后一页");
                else
                {
                    dataGridView1.DataSource = null;
                    start += size;//下一次开始取记录的地方
                    show(start, size);
                }
            }
            else if (start == (i - yuShu))
            {
                MessageBox.Show("已经到达最后一页");
            }
            else
            {
                dataGridView1.DataSource = null;
                start += size;//下一次开始取记录的地方
                show(start, size);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int yuShu = i % size;
            if (yuShu == 0)
            {
                if (start == i - size) MessageBox.Show("已经是最后一页");
                else
                {
                    dataGridView1.DataSource = null;
                    start = i - size;//i为总记录数
                    show(start, yuShu);
                }
            }
            else if (start == (i - yuShu))
            {
                MessageBox.Show("已经是最后一页");
            }
            else
            {
                dataGridView1.DataSource = null;
                start = i - yuShu;//i为总记录数
                show(start, yuShu);
            }
        }
    }
}
