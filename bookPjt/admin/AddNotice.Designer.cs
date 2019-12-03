namespace bookPjt.admin
{
    partial class AddNotice
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNoticeContent = new System.Windows.Forms.TextBox();
            this.txtNoticeTitle = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtNoticeContent);
            this.panel1.Controls.Add(this.txtNoticeTitle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 426);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "취 소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "등 록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNoticeContent
            // 
            this.txtNoticeContent.Location = new System.Drawing.Point(43, 94);
            this.txtNoticeContent.Multiline = true;
            this.txtNoticeContent.Name = "txtNoticeContent";
            this.txtNoticeContent.Size = new System.Drawing.Size(562, 249);
            this.txtNoticeContent.TabIndex = 1;
            // 
            // txtNoticeTitle
            // 
            this.txtNoticeTitle.Location = new System.Drawing.Point(43, 37);
            this.txtNoticeTitle.Multiline = true;
            this.txtNoticeTitle.Name = "txtNoticeTitle";
            this.txtNoticeTitle.Size = new System.Drawing.Size(562, 39);
            this.txtNoticeTitle.TabIndex = 0;
            // 
            // AddNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AddNotice";
            this.Text = "공지사항 등록";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNoticeContent;
        private System.Windows.Forms.TextBox txtNoticeTitle;
    }
}