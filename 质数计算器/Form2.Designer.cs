
namespace 质数计算器
{
    partial class Frame2
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
            this.fileShowText = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.Label();
            this.textFilePath = new System.Windows.Forms.TextBox();
            this.saveFile = new System.Windows.Forms.Button();
            this.leadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileShowText
            // 
            this.fileShowText.AutoSize = true;
            this.fileShowText.Font = new System.Drawing.Font("隶书", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileShowText.Location = new System.Drawing.Point(37, 12);
            this.fileShowText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileShowText.Name = "fileShowText";
            this.fileShowText.Size = new System.Drawing.Size(159, 36);
            this.fileShowText.TabIndex = 0;
            this.fileShowText.Text = "文件操作";
            // 
            // filePath
            // 
            this.filePath.AutoSize = true;
            this.filePath.Font = new System.Drawing.Font("隶书", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.filePath.Location = new System.Drawing.Point(38, 90);
            this.filePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(208, 28);
            this.filePath.TabIndex = 1;
            this.filePath.Text = "输入文件路径：";
            this.filePath.Click += new System.EventHandler(this.filePath_Click);
            // 
            // textFilePath
            // 
            this.textFilePath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textFilePath.Location = new System.Drawing.Point(286, 90);
            this.textFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.Size = new System.Drawing.Size(525, 35);
            this.textFilePath.TabIndex = 2;
            this.textFilePath.TextChanged += new System.EventHandler(this.textFilePath_TextChanged);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(286, 182);
            this.saveFile.Margin = new System.Windows.Forms.Padding(4);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(155, 49);
            this.saveFile.TabIndex = 3;
            this.saveFile.Text = "保存";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // leadFile
            // 
            this.leadFile.Location = new System.Drawing.Point(656, 182);
            this.leadFile.Margin = new System.Windows.Forms.Padding(4);
            this.leadFile.Name = "leadFile";
            this.leadFile.Size = new System.Drawing.Size(155, 49);
            this.leadFile.TabIndex = 4;
            this.leadFile.Text = "导入";
            this.leadFile.UseVisualStyleBackColor = true;
            this.leadFile.Click += new System.EventHandler(this.leadFile_Click);
            // 
            // Frame2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(959, 293);
            this.Controls.Add(this.leadFile);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.textFilePath);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.fileShowText);
            this.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frame2";
            this.Text = "file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileShowText;
        private System.Windows.Forms.Label filePath;
        private System.Windows.Forms.TextBox textFilePath;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button leadFile;
    }
}