namespace bookPjt
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.btnBookUpdate = new System.Windows.Forms.Button();
            this.bookImage = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSummery = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookName
            // 
            this.bookName.Location = new System.Drawing.Point(147, 76);
            this.bookName.Multiline = true;
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(296, 36);
            this.bookName.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "도서명 :";
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.Location = new System.Drawing.Point(375, 15);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(287, 90);
            this.btnBookDelete.TabIndex = 19;
            this.btnBookDelete.Text = "삭 제";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            this.btnBookDelete.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnBookUpdate
            // 
            this.btnBookUpdate.Location = new System.Drawing.Point(49, 15);
            this.btnBookUpdate.Name = "btnBookUpdate";
            this.btnBookUpdate.Size = new System.Drawing.Size(287, 90);
            this.btnBookUpdate.TabIndex = 18;
            this.btnBookUpdate.Text = "수 정";
            this.btnBookUpdate.UseVisualStyleBackColor = true;
            this.btnBookUpdate.Click += new System.EventHandler(this.button9_Click);
            // 
            // bookImage
            // 
            this.bookImage.BackColor = System.Drawing.Color.White;
            this.bookImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookImage.Image = ((System.Drawing.Image)(resources.GetObject("bookImage.Image")));
            this.bookImage.Location = new System.Drawing.Point(561, 21);
            this.bookImage.Name = "bookImage";
            this.bookImage.Size = new System.Drawing.Size(480, 348);
            this.bookImage.TabIndex = 17;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(701, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(287, 90);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "취 소";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "줄거리 :";
            // 
            // txtSummery
            // 
            this.txtSummery.Location = new System.Drawing.Point(147, 131);
            this.txtSummery.Multiline = true;
            this.txtSummery.Name = "txtSummery";
            this.txtSummery.Size = new System.Drawing.Size(296, 122);
            this.txtSummery.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSummery);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bookName);
            this.panel1.Location = new System.Drawing.Point(23, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 348);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnBookDelete);
            this.panel2.Controls.Add(this.btnBookUpdate);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Location = new System.Drawing.Point(22, 382);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 119);
            this.panel2.TabIndex = 29;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1063, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bookImage);
            this.Name = "Form2";
            this.Text = "수정 및 삭제";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.Button btnBookUpdate;
        private System.Windows.Forms.Label bookImage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSummery;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}