namespace FoodMis
{
    partial class AddPurchasing
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
            this.PurchasingName = new System.Windows.Forms.Label();
            this.Salesperson_name = new System.Windows.Forms.ComboBox();
            this.Buyer_name = new System.Windows.Forms.ComboBox();
            this.Purchasing_name = new System.Windows.Forms.ComboBox();
            this.Num = new System.Windows.Forms.TextBox();
            this.BuyerName = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.SalespersonName = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.save = new DevExpress.XtraEditors.SimpleButton();
            this.reset = new DevExpress.XtraEditors.SimpleButton();
            this.AddPayment = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // PurchasingName
            // 
            this.PurchasingName.AutoSize = true;
            this.PurchasingName.Location = new System.Drawing.Point(80, 141);
            this.PurchasingName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PurchasingName.Name = "PurchasingName";
            this.PurchasingName.Size = new System.Drawing.Size(82, 15);
            this.PurchasingName.TabIndex = 30;
            this.PurchasingName.Text = "采购物名称";
            this.PurchasingName.Click += new System.EventHandler(this.PurchasingName_Click);
            // 
            // Salesperson_name
            // 
            this.Salesperson_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Salesperson_name.FormattingEnabled = true;
            this.Salesperson_name.Location = new System.Drawing.Point(218, 74);
            this.Salesperson_name.Margin = new System.Windows.Forms.Padding(4);
            this.Salesperson_name.Name = "Salesperson_name";
            this.Salesperson_name.Size = new System.Drawing.Size(335, 23);
            this.Salesperson_name.TabIndex = 29;
            this.Salesperson_name.SelectedIndexChanged += new System.EventHandler(this.Salesperson_name_SelectedIndexChanged);
            // 
            // Buyer_name
            // 
            this.Buyer_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Buyer_name.FormattingEnabled = true;
            this.Buyer_name.Location = new System.Drawing.Point(218, 348);
            this.Buyer_name.Margin = new System.Windows.Forms.Padding(4);
            this.Buyer_name.Name = "Buyer_name";
            this.Buyer_name.Size = new System.Drawing.Size(336, 23);
            this.Buyer_name.TabIndex = 28;
            this.Buyer_name.SelectedIndexChanged += new System.EventHandler(this.Buyer_name_SelectedIndexChanged);
            // 
            // Purchasing_name
            // 
            this.Purchasing_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Purchasing_name.FormattingEnabled = true;
            this.Purchasing_name.Location = new System.Drawing.Point(218, 136);
            this.Purchasing_name.Margin = new System.Windows.Forms.Padding(4);
            this.Purchasing_name.Name = "Purchasing_name";
            this.Purchasing_name.Size = new System.Drawing.Size(337, 23);
            this.Purchasing_name.TabIndex = 27;
            this.Purchasing_name.SelectedIndexChanged += new System.EventHandler(this.Purchasing_name_SelectedIndexChanged);
            // 
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(219, 292);
            this.Num.Margin = new System.Windows.Forms.Padding(4);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(335, 25);
            this.Num.TabIndex = 24;
            // 
            // BuyerName
            // 
            this.BuyerName.AutoSize = true;
            this.BuyerName.Location = new System.Drawing.Point(80, 348);
            this.BuyerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BuyerName.Name = "BuyerName";
            this.BuyerName.Size = new System.Drawing.Size(82, 15);
            this.BuyerName.TabIndex = 22;
            this.BuyerName.Text = "采购员名称";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(77, 295);
            this.number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(85, 15);
            this.number.TabIndex = 21;
            this.number.Text = "数      量";
            // 
            // SalespersonName
            // 
            this.SalespersonName.AutoSize = true;
            this.SalespersonName.Location = new System.Drawing.Point(80, 78);
            this.SalespersonName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalespersonName.Name = "SalespersonName";
            this.SalespersonName.Size = new System.Drawing.Size(82, 15);
            this.SalespersonName.TabIndex = 19;
            this.SalespersonName.Text = "供应商名称";
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(235, 15);
            this.add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(188, 31);
            this.add.TabIndex = 18;
            this.add.Text = "添加采购信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "单      价";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(218, 185);
            this.textBox_price.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.ReadOnly = true;
            this.textBox_price.Size = new System.Drawing.Size(335, 25);
            this.textBox_price.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "设置零售价";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 237);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 25);
            this.textBox1.TabIndex = 35;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(120, 392);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(177, 35);
            this.save.TabIndex = 36;
            this.save.Text = "保存此采购信息";
            this.save.Click += new System.EventHandler(this.save_Click_1);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(303, 392);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(80, 35);
            this.reset.TabIndex = 37;
            this.reset.Text = "重置";
            this.reset.Click += new System.EventHandler(this.reset_Click_1);
            // 
            // AddPayment
            // 
            this.AddPayment.Location = new System.Drawing.Point(389, 392);
            this.AddPayment.Name = "AddPayment";
            this.AddPayment.Size = new System.Drawing.Size(166, 35);
            this.AddPayment.TabIndex = 38;
            this.AddPayment.Text = "添加相应付款单";
            this.AddPayment.Click += new System.EventHandler(this.AddPayment2_Click);
            // 
            // AddPurchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddPayment);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PurchasingName);
            this.Controls.Add(this.Salesperson_name);
            this.Controls.Add(this.Buyer_name);
            this.Controls.Add(this.Purchasing_name);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.BuyerName);
            this.Controls.Add(this.number);
            this.Controls.Add(this.SalespersonName);
            this.Controls.Add(this.add);
            this.Name = "AddPurchasing";
            this.Size = new System.Drawing.Size(1035, 455);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PurchasingName;
        private System.Windows.Forms.ComboBox Salesperson_name;
        private System.Windows.Forms.ComboBox Buyer_name;
        private System.Windows.Forms.ComboBox Purchasing_name;
        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.Label BuyerName;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label SalespersonName;
        private System.Windows.Forms.Label add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton save;
        private DevExpress.XtraEditors.SimpleButton reset;
        private DevExpress.XtraEditors.SimpleButton AddPayment;
    }
}
