namespace FoodMis
{
    partial class FKucunForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FKucunForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.利润分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存盘点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Bleft = new System.Windows.Forms.Label();
            this.label_Bright = new System.Windows.Forms.Label();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.利润分析ToolStripMenuItem,
            this.库存盘点ToolStripMenuItem,
            this.商品管理ToolStripMenuItem,
            this.注销ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 32);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 利润分析ToolStripMenuItem
            // 
            this.利润分析ToolStripMenuItem.Name = "利润分析ToolStripMenuItem";
            this.利润分析ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.利润分析ToolStripMenuItem.Text = "利润分析";
            this.利润分析ToolStripMenuItem.Click += new System.EventHandler(this.利润分析ToolStripMenuItem_Click);
            // 
            // 库存盘点ToolStripMenuItem
            // 
            this.库存盘点ToolStripMenuItem.Name = "库存盘点ToolStripMenuItem";
            this.库存盘点ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.库存盘点ToolStripMenuItem.Text = "库存盘点";
            this.库存盘点ToolStripMenuItem.Click += new System.EventHandler(this.库存盘点ToolStripMenuItem_Click);
            // 
            // 商品管理ToolStripMenuItem
            // 
            this.商品管理ToolStripMenuItem.Name = "商品管理ToolStripMenuItem";
            this.商品管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.商品管理ToolStripMenuItem.Text = "商品管理";
            this.商品管理ToolStripMenuItem.Click += new System.EventHandler(this.商品管理ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // FKucunForm
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
            this.Name = "FKucunForm";
            this.Text = "食品进销存系统——仓库管理";
            this.TitleCenter = false;
            this.Load += new System.EventHandler(this.FKucunForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 利润分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存盘点ToolStripMenuItem;
        private System.Windows.Forms.Label label_Bleft;
        private System.Windows.Forms.Label label_Bright;
        private System.Windows.Forms.ToolStripMenuItem 商品管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
    }
}