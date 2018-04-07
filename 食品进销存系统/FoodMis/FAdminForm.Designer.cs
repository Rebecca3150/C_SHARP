namespace FoodMis
{
    partial class FAdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAdminForm));
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.管理员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.采购员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.供应商管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Bleft = new System.Windows.Forms.Label();
            this.label_Bright = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.label1);
            this.MainGroup.Location = new System.Drawing.Point(3, 75);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Size = new System.Drawing.Size(1019, 641);
            this.MainGroup.TabIndex = 4;
            this.MainGroup.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(201, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "食品进销存系统";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理员管理ToolStripMenuItem,
            this.采购员管理ToolStripMenuItem,
            this.客户管理ToolStripMenuItem,
            this.销售员管理ToolStripMenuItem,
            this.供应商管理ToolStripMenuItem,
            this.注销ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 32);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 管理员管理ToolStripMenuItem
            // 
            this.管理员管理ToolStripMenuItem.Name = "管理员管理ToolStripMenuItem";
            this.管理员管理ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.管理员管理ToolStripMenuItem.Text = "管理员管理";
            this.管理员管理ToolStripMenuItem.Click += new System.EventHandler(this.管理员管理ToolStripMenuItem_Click);
            // 
            // 采购员管理ToolStripMenuItem
            // 
            this.采购员管理ToolStripMenuItem.Name = "采购员管理ToolStripMenuItem";
            this.采购员管理ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.采购员管理ToolStripMenuItem.Text = "采购员管理";
            this.采购员管理ToolStripMenuItem.Click += new System.EventHandler(this.采购员管理ToolStripMenuItem_Click);
            // 
            // 客户管理ToolStripMenuItem
            // 
            this.客户管理ToolStripMenuItem.Name = "客户管理ToolStripMenuItem";
            this.客户管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.客户管理ToolStripMenuItem.Text = "客户管理";
            this.客户管理ToolStripMenuItem.Click += new System.EventHandler(this.客户管理ToolStripMenuItem_Click);
            // 
            // 销售员管理ToolStripMenuItem
            // 
            this.销售员管理ToolStripMenuItem.Name = "销售员管理ToolStripMenuItem";
            this.销售员管理ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.销售员管理ToolStripMenuItem.Text = "销售员管理";
            this.销售员管理ToolStripMenuItem.Click += new System.EventHandler(this.销售员管理ToolStripMenuItem_Click);
            // 
            // 供应商管理ToolStripMenuItem
            // 
            this.供应商管理ToolStripMenuItem.Name = "供应商管理ToolStripMenuItem";
            this.供应商管理ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.供应商管理ToolStripMenuItem.Text = "供应商管理";
            this.供应商管理ToolStripMenuItem.Click += new System.EventHandler(this.供应商管理ToolStripMenuItem_Click);
            // 
            // label_Bleft
            // 
            this.label_Bleft.AutoSize = true;
            this.label_Bleft.Location = new System.Drawing.Point(7, 719);
            this.label_Bleft.Name = "label_Bleft";
            this.label_Bleft.Size = new System.Drawing.Size(15, 15);
            this.label_Bleft.TabIndex = 9;
            this.label_Bleft.Text = "l";
            // 
            // label_Bright
            // 
            this.label_Bright.AutoSize = true;
            this.label_Bright.Location = new System.Drawing.Point(806, 719);
            this.label_Bright.Name = "label_Bright";
            this.label_Bright.Size = new System.Drawing.Size(67, 15);
            this.label_Bright.TabIndex = 8;
            this.label_Bright.Text = "显示时间";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // FAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 751);
            this.Controls.Add(this.label_Bleft);
            this.Controls.Add(this.label_Bright);
            this.Controls.Add(this.MainGroup);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FAdminForm";
            this.Text = "食品进销存系统——基础管理";
            this.TitleCenter = false;
            this.Load += new System.EventHandler(this.FAdminForm_Load);
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采购员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 供应商管理ToolStripMenuItem;
        private System.Windows.Forms.Label label_Bleft;
        private System.Windows.Forms.Label label_Bright;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;

    }
}