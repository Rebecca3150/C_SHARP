using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace FoodMis
{
    public partial class 采购管理 : Skin_Mac
    {
        public 采购管理()
        {
            InitializeComponent();
        }

        private void checkOrder_Click(object sender, EventArgs e)
        {
            CheckPurchasing checkPurchasing = new CheckPurchasing();
            checkPurchasing.Show();
            mainWindows.Controls.Clear();
            mainWindows.Controls.Add(checkPurchasing);
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            AddPurchasing addPurchasing = new AddPurchasing();
            addPurchasing.Show();
            mainWindows.Controls.Clear();
            mainWindows.Controls.Add(addPurchasing);
        }

        private void checkPayment_Click(object sender, EventArgs e)
        {
            CheckPayment checkPayment = new CheckPayment();
            checkPayment.Show();
            mainWindows.Controls.Clear();
            mainWindows.Controls.Add(checkPayment);
        }

      

        private void 采购管理_Load(object sender, EventArgs e)
        {

        }

        private void 新增ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddReceipt addReceipt = new AddReceipt();
            addReceipt.Show();
            mainWindows.Controls.Clear();
            mainWindows.Controls.Add(addReceipt);
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckPurchasing checkPurchasing = new CheckPurchasing();
            checkPurchasing.Show();
            mainWindows.Controls.Clear();
            mainWindows.Controls.Add(checkPurchasing);
      
        }

        private void 新增ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddPurchasing addPurchasing = new AddPurchasing();
            addPurchasing.Show();
            mainWindows.Controls.Clear();
            mainWindows.Controls.Add(addPurchasing);
   
        }

        private void 查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CheckPayment addPu = new CheckPayment();
            addPu.Show();
            mainWindows.Controls.Clear();
            mainWindows.Controls.Add(addPu);
       
        }

     
    }
}
