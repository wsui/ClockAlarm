namespace ClockAlarm
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文字ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.时间间隔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消提醒ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.背景闪烁ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最大化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.点击退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(0, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(434, 186);
            this.button1.TabIndex = 0;
            this.button1.Text = "休息时间到！";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文字ToolStripMenuItem,
            this.时间间隔ToolStripMenuItem,
            this.取消提醒ToolStripMenuItem1,
            this.背景闪烁ToolStripMenuItem,
            this.点击退出ToolStripMenuItem,
            this.最大化ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.sToolStripMenuItem.Text = "设置";
            // 
            // 文字ToolStripMenuItem
            // 
            this.文字ToolStripMenuItem.Name = "文字ToolStripMenuItem";
            this.文字ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.文字ToolStripMenuItem.Text = "提醒文字";
            this.文字ToolStripMenuItem.Click += new System.EventHandler(this.文字ToolStripMenuItem_Click);
            // 
            // 时间间隔ToolStripMenuItem
            // 
            this.时间间隔ToolStripMenuItem.Name = "时间间隔ToolStripMenuItem";
            this.时间间隔ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.时间间隔ToolStripMenuItem.Text = "设置间隔提醒";
            this.时间间隔ToolStripMenuItem.Click += new System.EventHandler(this.设置时间间隔ToolStripMenuItem_Click);
            // 
            // 取消提醒ToolStripMenuItem1
            // 
            this.取消提醒ToolStripMenuItem1.Name = "取消提醒ToolStripMenuItem1";
            this.取消提醒ToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.取消提醒ToolStripMenuItem1.Text = "取消提醒";
            this.取消提醒ToolStripMenuItem1.Click += new System.EventHandler(this.取消提醒ToolStripMenuItem1_Click);
            // 
            // 背景闪烁ToolStripMenuItem
            // 
            this.背景闪烁ToolStripMenuItem.Name = "背景闪烁ToolStripMenuItem";
            this.背景闪烁ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.背景闪烁ToolStripMenuItem.Text = "背景闪烁×";
            this.背景闪烁ToolStripMenuItem.Click += new System.EventHandler(this.背景闪烁ToolStripMenuItem_Click);
            // 
            // 最大化ToolStripMenuItem
            // 
            this.最大化ToolStripMenuItem.Name = "最大化ToolStripMenuItem";
            this.最大化ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.最大化ToolStripMenuItem.Text = "最大化×";
            this.最大化ToolStripMenuItem.Click += new System.EventHandler(this.全屏ToolStripMenuItem_Click);
            // 
            // 点击退出ToolStripMenuItem
            // 
            this.点击退出ToolStripMenuItem.Name = "点击退出ToolStripMenuItem";
            this.点击退出ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.点击退出ToolStripMenuItem.Text = "点击界面关闭×";
            this.点击退出ToolStripMenuItem.Click += new System.EventHandler(this.点击退出ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "间隔提醒";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文字ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 时间间隔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消提醒ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 背景闪烁ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 点击退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最大化ToolStripMenuItem;

    }
}

