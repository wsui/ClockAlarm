namespace ClockAlarm
{
    partial class SetTimeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetTimeForm));
            this.hour1 = new System.Windows.Forms.NumericUpDown();
            this.minute1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hour1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute1)).BeginInit();
            this.SuspendLayout();
            // 
            // hour1
            // 
            this.hour1.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hour1.Location = new System.Drawing.Point(72, 78);
            this.hour1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hour1.Name = "hour1";
            this.hour1.Size = new System.Drawing.Size(120, 43);
            this.hour1.TabIndex = 0;
            // 
            // minute1
            // 
            this.minute1.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minute1.Location = new System.Drawing.Point(198, 78);
            this.minute1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minute1.Name = "minute1";
            this.minute1.Size = new System.Drawing.Size(120, 43);
            this.minute1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(67, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "小时";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(193, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "分钟";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SetTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 231);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minute1);
            this.Controls.Add(this.hour1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 270);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 270);
            this.Name = "SetTimeForm";
            this.Text = "提醒间隔时间设置";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.hour1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown hour1;
        private System.Windows.Forms.NumericUpDown minute1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;

    }
}