namespace 质数计算器
{
    partial class Frame
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.titleText = new System.Windows.Forms.Label();
            this.textDown = new System.Windows.Forms.Label();
            this.textUp = new System.Windows.Forms.Label();
            this.textRes = new System.Windows.Forms.Label();
            this.textBoxDown = new System.Windows.Forms.TextBox();
            this.textBoxUp = new System.Windows.Forms.TextBox();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.juadge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("隶书", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleText.Location = new System.Drawing.Point(281, 9);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(452, 48);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "欢迎使用质数计算器";
            // 
            // textDown
            // 
            this.textDown.AutoSize = true;
            this.textDown.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textDown.Location = new System.Drawing.Point(62, 93);
            this.textDown.Name = "textDown";
            this.textDown.Size = new System.Drawing.Size(118, 24);
            this.textDown.TabIndex = 1;
            this.textDown.Text = "区间下界:";
            // 
            // textUp
            // 
            this.textUp.AutoSize = true;
            this.textUp.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textUp.Location = new System.Drawing.Point(415, 93);
            this.textUp.Name = "textUp";
            this.textUp.Size = new System.Drawing.Size(130, 24);
            this.textUp.TabIndex = 2;
            this.textUp.Text = "区间上界：";
            // 
            // textRes
            // 
            this.textRes.AutoSize = true;
            this.textRes.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textRes.Location = new System.Drawing.Point(62, 140);
            this.textRes.Name = "textRes";
            this.textRes.Size = new System.Drawing.Size(82, 24);
            this.textRes.TabIndex = 3;
            this.textRes.Text = "结果：";
            // 
            // textBoxDown
            // 
            this.textBoxDown.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxDown.Location = new System.Drawing.Point(167, 92);
            this.textBoxDown.Name = "textBoxDown";
            this.textBoxDown.Size = new System.Drawing.Size(218, 35);
            this.textBoxDown.TabIndex = 4;
            this.textBoxDown.TextChanged += new System.EventHandler(this.textBoxDown_TextChanged);
            // 
            // textBoxUp
            // 
            this.textBoxUp.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxUp.Location = new System.Drawing.Point(519, 93);
            this.textBoxUp.Name = "textBoxUp";
            this.textBoxUp.Size = new System.Drawing.Size(218, 35);
            this.textBoxUp.TabIndex = 5;
            this.textBoxUp.TextChanged += new System.EventHandler(this.textBoxUp_TextChanged);
            // 
            // textBoxRes
            // 
            this.textBoxRes.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxRes.Location = new System.Drawing.Point(121, 140);
            this.textBoxRes.MaxLength = 2147483647;
            this.textBoxRes.Multiline = true;
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(763, 281);
            this.textBoxRes.TabIndex = 6;
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button.Location = new System.Drawing.Point(769, 87);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(139, 41);
            this.button.TabIndex = 7;
            this.button.Text = "计算质数";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "设置";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "帮助";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // juadge
            // 
            this.juadge.Location = new System.Drawing.Point(840, 12);
            this.juadge.Name = "juadge";
            this.juadge.Size = new System.Drawing.Size(68, 35);
            this.juadge.TabIndex = 11;
            this.juadge.Text = "判断";
            this.juadge.UseVisualStyleBackColor = true;
            this.juadge.Click += new System.EventHandler(this.juadge_Click);
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 455);
            this.Controls.Add(this.juadge);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.textBoxUp);
            this.Controls.Add(this.textBoxDown);
            this.Controls.Add(this.textRes);
            this.Controls.Add(this.textUp);
            this.Controls.Add(this.textDown);
            this.Controls.Add(this.titleText);
            this.Font = new System.Drawing.Font("隶书", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frame";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "质数计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label textDown;
        private System.Windows.Forms.Label textUp;
        private System.Windows.Forms.Label textRes;
        private System.Windows.Forms.TextBox textBoxDown;
        private System.Windows.Forms.TextBox textBoxUp;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button juadge;
    }
}

