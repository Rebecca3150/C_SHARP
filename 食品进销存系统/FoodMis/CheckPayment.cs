using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Word = Microsoft.Office.Interop.Word;


namespace FoodMis
{
    public partial class CheckPayment : UserControl
    {
        private const string DATAWORDPATH = @"E:\";
        private const string IMAGEWORDPATH = @"E:\folder\doc\imagedoc\";
        private const string IMAGEPATH = @"E:\folder\image\";
        private const string EXCELPATH = @"E:\folder\excel\";
        private const string TXTPATH = @"E:\folder\txt\";
        private const string IMAGEPOSTFIX = ".bmp";
        private const string WORDPOSTFIX = ".doc";
        private const string EXCELPOSTFIX = ".xls";
        private const string TXTPOSTFIX = ".txt";
        private const int DATADISTANCE = 5;
        private const int TABDISTANCE = 8;

        private SqlConnection conn;
        private SqlDataAdapter adapter;
        DataSet dataSet;

        int i, start;//i为总行数，start为起始位置
        int size = 4;//定义一个每页显示的行数

        public CheckPayment()
        {
            InitializeComponent();
            conn = new SqlConnection(@"data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");

            Initialize();
        }

        public void Initialize()
        {
            string sql = "select id,purchasing_id,supplier_name,buyer_name,type,a_money,y_money,status,info from payment";
            conn.Open();
            adapter = new SqlDataAdapter(sql, conn);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            dataGridView1.Columns[0].HeaderText = "付款单编号";
            dataGridView1.Columns[1].HeaderText = "关联采购订单号";
            dataGridView1.Columns[2].HeaderText = "供应商";
            dataGridView1.Columns[3].HeaderText = "付款人";
            dataGridView1.Columns[4].HeaderText = "结算方式";
            dataGridView1.Columns[5].HeaderText = "总金额";
            dataGridView1.Columns[6].HeaderText = "已付金额";
            dataGridView1.Columns[7].HeaderText = "结算状态";
            dataGridView1.Columns[8].HeaderText = "备注信息";

            i = dataSet.Tables[0].Rows.Count;//总的行数或者记录数
            show(0, size);//每页显示4条记录
            start = 0;//第一行

            conn.Close();
        }


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


                dataGridView1.Columns[0].HeaderText = "付款单编号";
                dataGridView1.Columns[1].HeaderText = "关联采购订单号";
                dataGridView1.Columns[2].HeaderText = "供应商";
                dataGridView1.Columns[3].HeaderText = "付款人";
                dataGridView1.Columns[4].HeaderText = "结算方式";
                dataGridView1.Columns[5].HeaderText = "总金额";
                dataGridView1.Columns[6].HeaderText = "已付金额";
                dataGridView1.Columns[7].HeaderText = "结算状态";
                dataGridView1.Columns[8].HeaderText = "备注信息";

            }
            dataSet = null;//清空数据集
        }



        private void CheckPayment_Load(object sender, EventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
        {
            ExportToWord(dataGridView1);
        }

        public string GetTempFileName()
        {
            return DateTime.Now.ToString("yyyyMMddhhmmssfff");
        }


        public void ExportToWord(DataGridView ds)
        {

            if (ds.Rows.Count != 0)
            {

                string tempFileName = null;

                object filename = null;

                object tableBehavior = Word.WdDefaultTableBehavior.wdWord9TableBehavior;

                object autoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitFixed;

                object unit = Word.WdUnits.wdStory;

                object extend = System.Reflection.Missing.Value;

                object breakType = (int)Word.WdBreakType.wdSectionBreakNextPage;

                object count = 1;

                object character = Word.WdUnits.wdCharacter;

                object Nothing = System.Reflection.Missing.Value;

                try
                {
                    tempFileName = GetTempFileName();

                    //生成.doc文件完整路径名

                    filename = DATAWORDPATH + tempFileName + WORDPOSTFIX;

                    //创建一个word文件，文件名用系统时间生成精确到毫秒

                    Word.Application myWord = new Word.ApplicationClass();

                    Word._Document myDoc = new Word.DocumentClass();

                    myDoc = myWord.Documents.Add(ref Nothing, ref Nothing, ref Nothing, ref Nothing);

                    myDoc.Activate();

                    //把dataset中的表插入到word的文件中



                    {

                        myWord.Application.Selection.TypeText("付款单列表的数据如下");

                        //插入空白行 
                        myWord.Application.Selection.TypeParagraph();

                        myWord.Application.Selection.TypeParagraph();

                        Word.Range para = myWord.Application.Selection.Range;

                        myDoc.Tables.Add(para, ds.Rows.Count, ds.Columns.Count, ref tableBehavior, ref autoFitBehavior);


                        for (int column = 0; column < ds.Columns.Count; column++)
                        {

                            myDoc.Tables[1].Cell(1, column + 1).Range.InsertBefore(ds.Columns[column].HeaderText.Trim());

                        }

                        for (int row = 0; row < ds.Rows.Count - 1; row++)
                        {

                            for (int column = 0; column < ds.Columns.Count; column++)
                            {

                                myDoc.Tables[1].Cell(row + 2, column + 1).Range.InsertBefore(ds.Rows[row].Cells[column].Value.ToString().Trim());

                            }

                        }

                        myWord.Application.Selection.EndKey(ref unit, ref extend);

                        myWord.Application.Selection.TypeParagraph();

                        myWord.Application.Selection.TypeParagraph();

                        myWord.Application.Selection.InsertBreak(ref breakType);


                    }

                    myWord.Application.Selection.TypeBackspace();

                    myWord.Application.Selection.Delete(ref character, ref count);

                    myWord.Application.Selection.HomeKey(ref unit, ref extend);

                    //保存word文件到指定的目录下

                    try
                    {

                        myDoc.SaveAs(ref filename, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);
                        myWord.Visible = true;
                        MessageBox.Show("数据导出到word文档成功，路径为：" + filename);

                    }

                    catch
                    {

                        MessageBox.Show("系统找不到指定目录下的文件： " + DATAWORDPATH + tempFileName + WORDPOSTFIX);

                        return;

                    }

                    //让生成的excel文件可见

                    myWord.Visible = true;

                }

                catch (Exception ex)
                {

                    MessageBox.Show("向word文件中写入数据出错： " + ex.Message);

                }

            }

            else
            {

                System.Windows.Forms.MessageBox.Show("No Data！");

            }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
