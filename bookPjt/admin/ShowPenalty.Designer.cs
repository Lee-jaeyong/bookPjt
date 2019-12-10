namespace bookPjt.admin
{
    partial class ShowPenalty
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
            this.laUserName = new System.Windows.Forms.Label();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtInputPenalty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // laUserName
            // 
            this.laUserName.AutoSize = true;
            this.laUserName.Location = new System.Drawing.Point(27, 25);
            this.laUserName.Name = "laUserName";
            this.laUserName.Size = new System.Drawing.Size(45, 15);
            this.laUserName.TabIndex = 0;
            this.laUserName.Text = "label1";
            // 
            // txtPenalty
            // 
            this.txtPenalty.Location = new System.Drawing.Point(30, 65);
            this.txtPenalty.Multiline = true;
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.ReadOnly = true;
            this.txtPenalty.Size = new System.Drawing.Size(145, 45);
            this.txtPenalty.TabIndex = 1;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(30, 131);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(145, 45);
            this.btnPayment.TabIndex = 2;
            this.btnPayment.Text = "연체금 결제";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "닫 기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtInputPenalty
            // 
            this.txtInputPenalty.Location = new System.Drawing.Point(194, 65);
            this.txtInputPenalty.Multiline = true;
            this.txtInputPenalty.Name = "txtInputPenalty";
            this.txtInputPenalty.Size = new System.Drawing.Size(145, 45);
            this.txtInputPenalty.TabIndex = 4;
            // 
            // ShowPenalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 206);
            this.Controls.Add(this.txtInputPenalty);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.txtPenalty);
            this.Controls.Add(this.laUserName);
            this.Name = "ShowPenalty";
            this.Text = "ShowPenalty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laUserName;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtInputPenalty;
    }
}