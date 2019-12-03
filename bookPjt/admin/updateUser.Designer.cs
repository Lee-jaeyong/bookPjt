namespace bookPjt.admin
{
    partial class UpdateUser
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
            this.btnExit = new System.Windows.Forms.Button();
            this.BtnUpdateUserInfo = new System.Windows.Forms.Button();
            this.txtUserBirth = new System.Windows.Forms.TextBox();
            this.txtUserPhone3 = new System.Windows.Forms.TextBox();
            this.txtUserPhone2 = new System.Windows.Forms.TextBox();
            this.txtUserPhone1 = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.BtnUpdateUserInfo);
            this.panel1.Controls.Add(this.txtUserBirth);
            this.panel1.Controls.Add(this.txtUserPhone3);
            this.panel1.Controls.Add(this.txtUserPhone2);
            this.panel1.Controls.Add(this.txtUserPhone1);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.txtUserId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 334);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(215, 255);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 52);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "취 소";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BtnUpdateUserInfo
            // 
            this.BtnUpdateUserInfo.Location = new System.Drawing.Point(32, 255);
            this.BtnUpdateUserInfo.Name = "BtnUpdateUserInfo";
            this.BtnUpdateUserInfo.Size = new System.Drawing.Size(164, 52);
            this.BtnUpdateUserInfo.TabIndex = 7;
            this.BtnUpdateUserInfo.Text = "변 경";
            this.BtnUpdateUserInfo.UseVisualStyleBackColor = true;
            this.BtnUpdateUserInfo.Click += new System.EventHandler(this.BtnUpdateUserInfo_Click);
            // 
            // txtUserBirth
            // 
            this.txtUserBirth.Location = new System.Drawing.Point(151, 184);
            this.txtUserBirth.Multiline = true;
            this.txtUserBirth.Name = "txtUserBirth";
            this.txtUserBirth.Size = new System.Drawing.Size(211, 34);
            this.txtUserBirth.TabIndex = 6;
            this.txtUserBirth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUserBirth_KeyUp);
            // 
            // txtUserPhone3
            // 
            this.txtUserPhone3.Location = new System.Drawing.Point(317, 134);
            this.txtUserPhone3.Multiline = true;
            this.txtUserPhone3.Name = "txtUserPhone3";
            this.txtUserPhone3.Size = new System.Drawing.Size(45, 34);
            this.txtUserPhone3.TabIndex = 5;
            // 
            // txtUserPhone2
            // 
            this.txtUserPhone2.Location = new System.Drawing.Point(233, 134);
            this.txtUserPhone2.Multiline = true;
            this.txtUserPhone2.Name = "txtUserPhone2";
            this.txtUserPhone2.Size = new System.Drawing.Size(54, 34);
            this.txtUserPhone2.TabIndex = 4;
            // 
            // txtUserPhone1
            // 
            this.txtUserPhone1.Location = new System.Drawing.Point(152, 134);
            this.txtUserPhone1.Multiline = true;
            this.txtUserPhone1.Name = "txtUserPhone1";
            this.txtUserPhone1.Size = new System.Drawing.Size(56, 34);
            this.txtUserPhone1.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(151, 84);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(211, 34);
            this.txtUserName.TabIndex = 2;
            // 
            // txtUserId
            // 
            this.txtUserId.Enabled = false;
            this.txtUserId.Location = new System.Drawing.Point(151, 32);
            this.txtUserId.Multiline = true;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(211, 34);
            this.txtUserId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "생년월일 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "핸드폰 번호 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "사용자 명:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디 :";
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 358);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateUser";
            this.Text = "사용자 정보 변경";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button BtnUpdateUserInfo;
        private System.Windows.Forms.TextBox txtUserBirth;
        private System.Windows.Forms.TextBox txtUserPhone1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserPhone3;
        private System.Windows.Forms.TextBox txtUserPhone2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}