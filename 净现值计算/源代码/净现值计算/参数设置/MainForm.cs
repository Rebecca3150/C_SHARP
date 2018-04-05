using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 净现值计算器
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static double mon=0;
        public static double lv=0;
        public static int Y=0;
     

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SolidBrush b = new SolidBrush(this.dataGridView1.RowHeadersDefaultCellStyle.ForeColor);
            e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), this.dataGridView1.DefaultCellStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            try
            {
                mon = 0;
                Y = 0;
                mon = 0;
                textBox_mon.Text = "";
                textBox_lv.Text = "";

                while (dataGridView1.RowCount > 0)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }
            }
            catch
            {
                MessageBox.Show("重置完毕！");
            }
           
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            double M = 0;
            double s=0;
            double r=0;
            int j = 0;
            double lirun = 0;
            lv = Convert.ToDouble(textBox_lv.Text);
            mon = Convert.ToDouble(textBox_mon.Text);
            Y = dataGridView1.RowCount;//总年数
            if (Y > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++) 
                { 
                  //获取每年的年利润
                       s=Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                       //MessageBox.Show("第"+i+"年="+s);
                       j = i + 1;
                       r = Math.Pow((1 + lv * 0.01), j);
                       M+= s / r;
                       lirun += s;

                }


                double result = 0;
                result = M - mon;
                lirun = lirun - mon;
                MessageBox.Show("这"+Y+"年净利润为："+lirun+",净现值为："+result);

            }
            else
            {
                MessageBox.Show("请输入年利润记录了！");
            }
        }

        private void textBox_mon_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判斷只能輸入數字和Backspace
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;

            //判断可输入小数点，但小数点不能放在数字的前面，且要保证只能输入一个小数点在正确的位置
            if ((int)e.KeyChar == 46)                       //小数点    
            {
                if (textBox_mon.Text.Length <= 0)
                    e.Handled = true;           //小数点不能在第一位    
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(textBox_mon.Text, out oldf);
                    b2 = float.TryParse(textBox_mon.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                    else
                        e.Handled = false;
                }
            }
        }

        private void textBox_lv_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判斷只能輸入數字和Backspace
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;

            //判断可输入小数点，但小数点不能放在数字的前面，且要保证只能输入一个小数点在正确的位置
            if ((int)e.KeyChar == 46)                       //小数点    
            {
                if (textBox_lv.Text.Length <= 0)
                    e.Handled = true;           //小数点不能在第一位    
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(textBox_lv.Text, out oldf);
                    b2 = float.TryParse(textBox_lv.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                    else
                        e.Handled = false;
                }
            }
        }
       
        //定义输入框控件
        TextBox control;


        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        { //只对TextBox类型的单元格进行验证

            if (e.Control.GetType().BaseType.Name == "TextBox")
            {

                control = new TextBox();

                control = (TextBox)e.Control;

                if (control.Text == "0")    //需要限制输入数字的单元格
                {

                    control.KeyPress += new KeyPressEventHandler(control_KeyPress);

                }

                else
                {

                    //非数字类型单元格

                    control.Leave += new EventHandler(control_Leave);

                }

            }

        }


        void control_KeyPress(object sender, KeyPressEventArgs e)
        {

            //限制只能输入-9的数字，退格键，小数点和回车

            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || e.KeyChar == 13 || e.KeyChar == 8 || e.KeyChar == 46)
            {

                e.Handled = false;

            }

            else
            {

                e.Handled = true;

                MessageBox.Show("只能输入数字！");

            }

        }



        void control_Leave(object sender, EventArgs e)
        {

            //如果需要限制字符串输入长度
            /*
            if (control.Text.Length != 11)
            {

                MessageBox.Show("只能为11位！");

                control.Focus();

            }
            */
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox_mon_TextChanged(object sender, EventArgs e)
        {

        }

      

     
    }
}
