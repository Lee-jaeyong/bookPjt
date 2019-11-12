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
            this.bookStock = new System.Windows.Forms.TextBox();
            this.bookName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.bookImage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookStock
            // 
            this.bookStock.Location = new System.Drawing.Point(158, 208);
            this.bookStock.Multiline = true;
            this.bookStock.Name = "bookStock";
            this.bookStock.Size = new System.Drawing.Size(296, 36);
            this.bookStock.TabIndex = 28;
            // 
            // bookName
            // 
            this.bookName.Enabled = false;
            this.bookName.Location = new System.Drawing.Point(158, 132);
            this.bookName.Multiline = true;
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(296, 36);
            this.bookName.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "수 량 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "책 이름 :";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(369, 414);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(325, 90);
            this.button10.TabIndex = 19;
            this.button10.Text = "삭 제";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(23, 414);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(325, 90);
            this.button9.TabIndex = 18;
            this.button9.Text = "수 정";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // bookImage
            // 
            this.bookImage.BackColor = System.Drawing.Color.Turquoise;
            this.bookImage.Location = new System.Drawing.Point(561, 31);
            this.bookImage.Name = "bookImage";
            this.bookImage.Size = new System.Drawing.Size(480, 348);
            this.bookImage.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(714, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 90);
            this.button1.TabIndex = 19;
            this.button1.Text = "취 소";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 516);
            this.Controls.Add(this.bookStock);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.bookImage);
            this.Name = "Form2";
            this.Text = "수정 및 삭제";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox bookStock;
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label bookImage;
        private System.Windows.Forms.Button button1;
    }
}