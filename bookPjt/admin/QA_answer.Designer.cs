namespace bookPjt.admin
{
    partial class QA_answer
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
            this.txtQATitle = new System.Windows.Forms.TextBox();
            this.txtQAcontent = new System.Windows.Forms.TextBox();
            this.btnQAanswer = new System.Windows.Forms.Button();
            this.btnCencel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCencel);
            this.panel1.Controls.Add(this.btnQAanswer);
            this.panel1.Controls.Add(this.txtQAcontent);
            this.panel1.Controls.Add(this.txtQATitle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 372);
            this.panel1.TabIndex = 0;
            // 
            // txtQATitle
            // 
            this.txtQATitle.Location = new System.Drawing.Point(24, 24);
            this.txtQATitle.Multiline = true;
            this.txtQATitle.Name = "txtQATitle";
            this.txtQATitle.Size = new System.Drawing.Size(552, 51);
            this.txtQATitle.TabIndex = 1;
            // 
            // txtQAcontent
            // 
            this.txtQAcontent.Location = new System.Drawing.Point(24, 86);
            this.txtQAcontent.Multiline = true;
            this.txtQAcontent.Name = "txtQAcontent";
            this.txtQAcontent.Size = new System.Drawing.Size(552, 207);
            this.txtQAcontent.TabIndex = 1;
            // 
            // btnQAanswer
            // 
            this.btnQAanswer.Location = new System.Drawing.Point(24, 305);
            this.btnQAanswer.Name = "btnQAanswer";
            this.btnQAanswer.Size = new System.Drawing.Size(280, 56);
            this.btnQAanswer.TabIndex = 2;
            this.btnQAanswer.Text = "답변 완료";
            this.btnQAanswer.UseVisualStyleBackColor = true;
            this.btnQAanswer.Click += new System.EventHandler(this.btnQAanswer_Click);
            // 
            // btnCencel
            // 
            this.btnCencel.Location = new System.Drawing.Point(310, 305);
            this.btnCencel.Name = "btnCencel";
            this.btnCencel.Size = new System.Drawing.Size(266, 56);
            this.btnCencel.TabIndex = 3;
            this.btnCencel.Text = "취 소";
            this.btnCencel.UseVisualStyleBackColor = true;
            this.btnCencel.Click += new System.EventHandler(this.btnCencel_Click);
            // 
            // QA_answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 396);
            this.Controls.Add(this.panel1);
            this.Name = "QA_answer";
            this.Text = "답 변";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCencel;
        private System.Windows.Forms.Button btnQAanswer;
        private System.Windows.Forms.TextBox txtQAcontent;
        private System.Windows.Forms.TextBox txtQATitle;
    }
}