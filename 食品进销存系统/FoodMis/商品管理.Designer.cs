namespace FoodMis
{
    partial class 商品管理
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
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Button_select = new DevExpress.XtraEditors.SimpleButton();
            this.TextBox_select = new System.Windows.Forms.TextBox();
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.Button_delete = new DevExpress.XtraEditors.SimpleButton();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_goods = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.group_all = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_Nclear = new DevExpress.XtraEditors.SimpleButton();
            this.button_update = new DevExpress.XtraEditors.SimpleButton();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.group_all.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "请输入要查询的商品编号：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Button_select);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.TextBox_select);
            this.groupBox3.Location = new System.Drawing.Point(15, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(988, 68);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询";
            // 
            // Button_select
            // 
            this.Button_select.Location = new System.Drawing.Point(471, 28);
            this.Button_select.Name = "Button_select";
            this.Button_select.Size = new System.Drawing.Size(77, 29);
            this.Button_select.TabIndex = 13;
            this.Button_select.Text = "查询";
            this.Button_select.Click += new System.EventHandler(this.Button_select_Click);
            // 
            // TextBox_select
            // 
            this.TextBox_select.Location = new System.Drawing.Point(218, 30);
            this.TextBox_select.MaxLength = 15;
            this.TextBox_select.Name = "TextBox_select";
            this.TextBox_select.Size = new System.Drawing.Size(236, 25);
            this.TextBox_select.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(822, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "新增";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button_delete
            // 
            this.Button_delete.Location = new System.Drawing.Point(905, 18);
            this.Button_delete.Name = "Button_delete";
            this.Button_delete.Size = new System.Drawing.Size(77, 29);
            this.Button_delete.TabIndex = 25;
            this.Button_delete.Text = "删除";
            this.Button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "商品名称";
            this.columnHeader3.Width = 245;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "编号";
            this.columnHeader2.Width = 203;
            // 
            // listView_goods
            // 
            this.listView_goods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader4});
            this.listView_goods.FullRowSelect = true;
            this.listView_goods.Location = new System.Drawing.Point(6, 53);
            this.listView_goods.Name = "listView_goods";
            this.listView_goods.Size = new System.Drawing.Size(976, 375);
            this.listView_goods.TabIndex = 9;
            this.listView_goods.UseCompatibleStateImageBehavior = false;
            this.listView_goods.View = System.Windows.Forms.View.Details;
            this.listView_goods.SelectedIndexChanged += new System.EventHandler(this.listView_goods_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 31;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "商品单价";
            this.columnHeader6.Width = 214;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "供应厂商编号";
            this.columnHeader4.Width = 182;
            // 
            // group_all
            // 
            this.group_all.Controls.Add(this.simpleButton1);
            this.group_all.Controls.Add(this.button1);
            this.group_all.Controls.Add(this.listView_goods);
            this.group_all.Controls.Add(this.Button_delete);
            this.group_all.Location = new System.Drawing.Point(15, 194);
            this.group_all.Name = "group_all";
            this.group_all.Size = new System.Drawing.Size(988, 434);
            this.group_all.TabIndex = 28;
            this.group_all.TabStop = false;
            this.group_all.Text = "管理商信息";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(739, 18);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(77, 29);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "刷新";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button_Nclear);
            this.groupBox2.Controls.Add(this.button_update);
            this.groupBox2.Controls.Add(this.textBox_price);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_name);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(15, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(988, 92);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改信息";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(84, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 21;
            // 
            // button_Nclear
            // 
            this.button_Nclear.Location = new System.Drawing.Point(628, 31);
            this.button_Nclear.Name = "button_Nclear";
            this.button_Nclear.Size = new System.Drawing.Size(77, 29);
            this.button_Nclear.TabIndex = 20;
            this.button_Nclear.Text = "重置";
            this.button_Nclear.Click += new System.EventHandler(this.button_Nclear_Click_1);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(539, 31);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(77, 29);
            this.button_update.TabIndex = 19;
            this.button_update.Text = "修改";
            this.button_update.Click += new System.EventHandler(this.button_update_Click_1);
            // 
            // textBox_price
            // 
            this.textBox_price.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_price.Location = new System.Drawing.Point(359, 40);
            this.textBox_price.MaxLength = 15;
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(165, 25);
            this.textBox_price.TabIndex = 9;
            this.textBox_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_price_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "商品单价：";
            // 
            // textBox_name
            // 
            this.textBox_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_name.Location = new System.Drawing.Point(87, 40);
            this.textBox_name.MaxLength = 15;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(165, 25);
            this.textBox_name.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "商品名称：";
            // 
            // 商品管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.group_all);
            this.Name = "商品管理";
            this.Size = new System.Drawing.Size(1019, 643);
            this.Load += new System.EventHandler(this.商品管理_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.group_all.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton Button_select;
        private System.Windows.Forms.TextBox TextBox_select;
        private DevExpress.XtraEditors.SimpleButton button1;
        private DevExpress.XtraEditors.SimpleButton Button_delete;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listView_goods;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox group_all;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton button_Nclear;
        private DevExpress.XtraEditors.SimpleButton button_update;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label8;
    }
}
