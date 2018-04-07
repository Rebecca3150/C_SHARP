namespace FoodMis
{
    partial class AddPayment
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
            this.Status = new System.Windows.Forms.ComboBox();
            this.jieSuanStatus = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.payMethod = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.TextBox();
            this.Supplier_name = new System.Windows.Forms.TextBox();
            this.Buyer_name = new System.Windows.Forms.TextBox();
            this.otherInfo = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.A_money = new System.Windows.Forms.TextBox();
            this.BuyerName = new System.Windows.Forms.Label();
            this.totalMoney = new System.Windows.Forms.Label();
            this.SalespersonName = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "已结算"});
            this.Status.Location = new System.Drawing.Point(288, 249);
            this.Status.Margin = new System.Windows.Forms.Padding(4);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(337, 23);
            this.Status.TabIndex = 55;
            // 
            // jieSuanStatus
            // 
            this.jieSuanStatus.AutoSize = true;
            this.jieSuanStatus.Location = new System.Drawing.Point(180, 255);
            this.jieSuanStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.jieSuanStatus.Name = "jieSuanStatus";
            this.jieSuanStatus.Size = new System.Drawing.Size(67, 15);
            this.jieSuanStatus.TabIndex = 54;
            this.jieSuanStatus.Text = "结算状态";
            // 
            // type
            // 
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "现金",
            "支票",
            "信用卡",
            "网上支付"});
            this.type.Location = new System.Drawing.Point(288, 168);
            this.type.Margin = new System.Windows.Forms.Padding(4);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(337, 23);
            this.type.TabIndex = 53;
            // 
            // payMethod
            // 
            this.payMethod.AutoSize = true;
            this.payMethod.Location = new System.Drawing.Point(180, 172);
            this.payMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.payMethod.Name = "payMethod";
            this.payMethod.Size = new System.Drawing.Size(67, 15);
            this.payMethod.TabIndex = 52;
            this.payMethod.Text = "结算方式";
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(288, 289);
            this.info.Margin = new System.Windows.Forms.Padding(4);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(339, 25);
            this.info.TabIndex = 51;
            // 
            // Supplier_name
            // 
            this.Supplier_name.Location = new System.Drawing.Point(288, 86);
            this.Supplier_name.Margin = new System.Windows.Forms.Padding(4);
            this.Supplier_name.Name = "Supplier_name";
            this.Supplier_name.Size = new System.Drawing.Size(339, 25);
            this.Supplier_name.TabIndex = 50;
            // 
            // Buyer_name
            // 
            this.Buyer_name.Location = new System.Drawing.Point(288, 127);
            this.Buyer_name.Margin = new System.Windows.Forms.Padding(4);
            this.Buyer_name.Name = "Buyer_name";
            this.Buyer_name.Size = new System.Drawing.Size(339, 25);
            this.Buyer_name.TabIndex = 49;
            // 
            // otherInfo
            // 
            this.otherInfo.AutoSize = true;
            this.otherInfo.Location = new System.Drawing.Point(180, 296);
            this.otherInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.otherInfo.Name = "otherInfo";
            this.otherInfo.Size = new System.Drawing.Size(67, 15);
            this.otherInfo.TabIndex = 48;
            this.otherInfo.Text = "备注信息";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(391, 343);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 29);
            this.save.TabIndex = 47;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(527, 343);
            this.reset.Margin = new System.Windows.Forms.Padding(4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(100, 29);
            this.reset.TabIndex = 46;
            this.reset.Text = "重置";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // A_money
            // 
            this.A_money.Location = new System.Drawing.Point(288, 208);
            this.A_money.Margin = new System.Windows.Forms.Padding(4);
            this.A_money.Name = "A_money";
            this.A_money.Size = new System.Drawing.Size(339, 25);
            this.A_money.TabIndex = 45;
            // 
            // BuyerName
            // 
            this.BuyerName.AutoSize = true;
            this.BuyerName.Location = new System.Drawing.Point(164, 131);
            this.BuyerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BuyerName.Name = "BuyerName";
            this.BuyerName.Size = new System.Drawing.Size(82, 15);
            this.BuyerName.TabIndex = 44;
            this.BuyerName.Text = "付款人姓名";
            // 
            // totalMoney
            // 
            this.totalMoney.AutoSize = true;
            this.totalMoney.Location = new System.Drawing.Point(196, 213);
            this.totalMoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalMoney.Name = "totalMoney";
            this.totalMoney.Size = new System.Drawing.Size(52, 15);
            this.totalMoney.TabIndex = 43;
            this.totalMoney.Text = "总金额";
            // 
            // SalespersonName
            // 
            this.SalespersonName.AutoSize = true;
            this.SalespersonName.Location = new System.Drawing.Point(164, 89);
            this.SalespersonName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalespersonName.Name = "SalespersonName";
            this.SalespersonName.Size = new System.Drawing.Size(82, 15);
            this.SalespersonName.TabIndex = 42;
            this.SalespersonName.Text = "供应商名称";
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(323, 23);
            this.add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(159, 31);
            this.add.TabIndex = 41;
            this.add.Text = "添加付款单";
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Status);
            this.Controls.Add(this.jieSuanStatus);
            this.Controls.Add(this.type);
            this.Controls.Add(this.payMethod);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Supplier_name);
            this.Controls.Add(this.Buyer_name);
            this.Controls.Add(this.otherInfo);
            this.Controls.Add(this.save);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.A_money);
            this.Controls.Add(this.BuyerName);
            this.Controls.Add(this.totalMoney);
            this.Controls.Add(this.SalespersonName);
            this.Controls.Add(this.add);
            this.Name = "AddPayment";
            this.Size = new System.Drawing.Size(1035, 455);
            this.Load += new System.EventHandler(this.AddPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label jieSuanStatus;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label payMethod;
        public System.Windows.Forms.TextBox info;
        public System.Windows.Forms.TextBox Supplier_name;
        public System.Windows.Forms.TextBox Buyer_name;
        private System.Windows.Forms.Label otherInfo;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button reset;
        public System.Windows.Forms.TextBox A_money;
        private System.Windows.Forms.Label BuyerName;
        private System.Windows.Forms.Label totalMoney;
        private System.Windows.Forms.Label SalespersonName;
        private System.Windows.Forms.Label add;
    }
}
