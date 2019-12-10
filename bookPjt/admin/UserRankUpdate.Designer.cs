namespace bookPjt.admin
{
    partial class UserRankUpdate
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
            this.ComboAfterRank = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdateRankExecute = new System.Windows.Forms.Button();
            this.txtBeforeRank = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ComboAfterRank);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnUpdateRankExecute);
            this.panel1.Controls.Add(this.txtBeforeRank);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 163);
            this.panel1.TabIndex = 0;
            // 
            // ComboAfterRank
            // 
            this.ComboAfterRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboAfterRank.FormattingEnabled = true;
            this.ComboAfterRank.Items.AddRange(new object[] {
            "일반 회원",
            "사서",
            "관리자"});
            this.ComboAfterRank.Location = new System.Drawing.Point(201, 53);
            this.ComboAfterRank.Name = "ComboAfterRank";
            this.ComboAfterRank.Size = new System.Drawing.Size(136, 23);
            this.ComboAfterRank.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "취 소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpdateRankExecute
            // 
            this.btnUpdateRankExecute.Location = new System.Drawing.Point(34, 95);
            this.btnUpdateRankExecute.Name = "btnUpdateRankExecute";
            this.btnUpdateRankExecute.Size = new System.Drawing.Size(136, 40);
            this.btnUpdateRankExecute.TabIndex = 3;
            this.btnUpdateRankExecute.Text = "변 경";
            this.btnUpdateRankExecute.UseVisualStyleBackColor = true;
            this.btnUpdateRankExecute.Click += new System.EventHandler(this.btnUpdateRankExecute_Click);
            // 
            // txtBeforeRank
            // 
            this.txtBeforeRank.Enabled = false;
            this.txtBeforeRank.Location = new System.Drawing.Point(34, 53);
            this.txtBeforeRank.Name = "txtBeforeRank";
            this.txtBeforeRank.Size = new System.Drawing.Size(136, 25);
            this.txtBeforeRank.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "변경 후";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "변경 전";
            // 
            // UserRankUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 173);
            this.Controls.Add(this.panel1);
            this.Name = "UserRankUpdate";
            this.Text = "사용자 권한 변경";
            this.Load += new System.EventHandler(this.UserRankUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdateRankExecute;
        private System.Windows.Forms.TextBox txtBeforeRank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboAfterRank;
    }
}