using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Data.SqlClient;

namespace FoodMis
{
    public partial class Print : UserControl
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

        public Print()
        {
            InitializeComponent();
            conn = new SqlConnection(@"data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");
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

                    }

                    catch
                    {

                        System.Windows.Forms.MessageBox.Show("系统找不到指定目录下的文件： " + DATAWORDPATH + tempFileName + WORDPOSTFIX);

                        return;

                    }

                    //让生成的excel文件可见

                    myWord.Visible = true;

                }

                catch (Exception ex)
                {

                    System.Windows.Forms.MessageBox.Show("向word文件中写入数据出错： " + ex.Message);

                }

            }

            else
            {

                System.Windows.Forms.MessageBox.Show("No Data");

            }
        }
        private void Print_Load(object sender, EventArgs e)
        {

        }
    }
}
