namespace FoodMis
{
    partial class 库存盘点
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listView_stock = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_up = new DevExpress.XtraEditors.SimpleButton();
            this.Button_select = new DevExpress.XtraEditors.SimpleButton();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listView_stock);
            this.groupBox1.Controls.Add(this.button_up);
            this.groupBox1.Controls.Add(this.Button_select);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 612);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(34, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "库存盘点";
            // 
            // listView_stock
            // 
            this.listView_stock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listView_stock.FullRowSelect = true;
            this.listView_stock.Location = new System.Drawing.Point(42, 189);
            this.listView_stock.Name = "listView_stock";
            this.listView_stock.Size = new System.Drawing.Size(909, 390);
            this.listView_stock.TabIndex = 16;
            this.listView_stock.UseCompatibleStateImageBehavior = false;
            this.listView_stock.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "商品编号";
            this.columnHeader9.Width = 104;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "商品数量";
            this.columnHeader10.Width = 97;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "商品名称";
            this.columnHeader11.Width = 152;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "商品原价";
            this.columnHeader12.Width = 108;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "商品零售价";
            this.columnHeader13.Width = 112;
            // 
            // button_up
            // 
            this.button_up.Location = new System.Drawing.Point(874, 141);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(77, 29);
            this.button_up.TabIndex = 15;
            this.button_up.Text = "刷新";
            this.button_up.Click += new System.EventHandler(this.button_up_Click);
            // 
            // Button_select
            // 
            this.Button_select.Location = new System.Drawing.Point(791, 141);
            this.Button_select.Name = "Button_select";
            this.Button_select.Size = new System.Drawing.Size(77, 29);
            this.Button_select.TabIndex = 14;
            this.Button_select.Text = "查询";
            this.Button_select.Click += new System.EventHandler(this.Button_select_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(258, 141);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(362, 25);
            this.textBox_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品名称：";
            // 
            // 库存盘点
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "库存盘点";
            this.Size = new System.Drawing.Size(1019, 643);
            this.Load += new System.EventHandler(this.库存盘点_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_stock;
        private DevExpress.XtraEditors.SimpleButton button_up;
        private DevExpress.XtraEditors.SimpleButton Button_select;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
    }
}
