namespace BookManagement
{
    partial class JoinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinForm));
            this.idTxt = new System.Windows.Forms.TextBox();
            this.pwTxt = new System.Windows.Forms.TextBox();
            this.pw2Txt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.ph0Select = new System.Windows.Forms.ComboBox();
            this.ph1Txt = new System.Windows.Forms.TextBox();
            this.ph2Txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDupChk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idTxt
            // 
            this.idTxt.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idTxt.Location = new System.Drawing.Point(141, 52);
            this.idTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(267, 32);
            this.idTxt.TabIndex = 0;
            this.idTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.idTxt_KeyUp);
            // 
            // pwTxt
            // 
            this.pwTxt.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwTxt.Location = new System.Drawing.Point(141, 179);
            this.pwTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pwTxt.Name = "pwTxt";
            this.pwTxt.PasswordChar = '●';
            this.pwTxt.Size = new System.Drawing.Size(267, 32);
            this.pwTxt.TabIndex = 2;
            // 
            // pw2Txt
            // 
            this.pw2Txt.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pw2Txt.Location = new System.Drawing.Point(141, 236);
            this.pw2Txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pw2Txt.Name = "pw2Txt";
            this.pw2Txt.PasswordChar = '●';
            this.pw2Txt.Size = new System.Drawing.Size(267, 32);
            this.pw2Txt.TabIndex = 3;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameTxt.Location = new System.Drawing.Point(141, 298);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(267, 32);
            this.nameTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(77, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "이름 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "비밀번호 확인 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(48, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "비밀번호 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(62, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "아이디 : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelBtn.Image")));
            this.cancelBtn.Location = new System.Drawing.Point(222, 419);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(118, 61);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "취소";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.okBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.okBtn.Image = ((System.Drawing.Image)(resources.GetObject("okBtn.Image")));
            this.okBtn.Location = new System.Drawing.Point(106, 419);
            this.okBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(118, 61);
            this.okBtn.TabIndex = 8;
            this.okBtn.Text = "확인";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // ph0Select
            // 
            this.ph0Select.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ph0Select.FormattingEnabled = true;
            this.ph0Select.ItemHeight = 21;
            this.ph0Select.Items.AddRange(new object[] {
            "010",
            "070",
            "02",
            "030",
            "031",
            "011",
            "061"});
            this.ph0Select.Location = new System.Drawing.Point(141, 356);
            this.ph0Select.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ph0Select.Name = "ph0Select";
            this.ph0Select.Size = new System.Drawing.Size(68, 29);
            this.ph0Select.TabIndex = 5;
            // 
            // ph1Txt
            // 
            this.ph1Txt.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ph1Txt.Location = new System.Drawing.Point(230, 355);
            this.ph1Txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ph1Txt.Name = "ph1Txt";
            this.ph1Txt.Size = new System.Drawing.Size(78, 32);
            this.ph1Txt.TabIndex = 6;
            this.ph1Txt.Leave += new System.EventHandler(this.ph1Txt_Leave);
            // 
            // ph2Txt
            // 
            this.ph2Txt.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ph2Txt.Location = new System.Drawing.Point(330, 355);
            this.ph2Txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ph2Txt.Name = "ph2Txt";
            this.ph2Txt.Size = new System.Drawing.Size(78, 32);
            this.ph2Txt.TabIndex = 7;
            this.ph2Txt.Leave += new System.EventHandler(this.ph2Txt_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(48, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "전화번호 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "-";
            // 
            // txtBirth
            // 
            this.txtBirth.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBirth.Location = new System.Drawing.Point(141, 124);
            this.txtBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(267, 32);
            this.txtBirth.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(53, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "생년월일 :";
            this.label8.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblDupChk
            // 
            this.lblDupChk.AutoSize = true;
            this.lblDupChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDupChk.ForeColor = System.Drawing.Color.Red;
            this.lblDupChk.Location = new System.Drawing.Point(144, 90);
            this.lblDupChk.Name = "lblDupChk";
            this.lblDupChk.Size = new System.Drawing.Size(177, 24);
            this.lblDupChk.TabIndex = 7;
            this.lblDupChk.Text = "* 아이디를 입력해주세요";
            this.lblDupChk.Click += new System.EventHandler(this.label4_Click);
            // 
            // JoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(439, 520);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ph2Txt);
            this.Controls.Add(this.ph1Txt);
            this.Controls.Add(this.ph0Select);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDupChk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.pw2Txt);
            this.Controls.Add(this.pwTxt);
            this.Controls.Add(this.txtBirth);
            this.Controls.Add(this.idTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "JoinForm";
            this.Text = "회원가입";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox pwTxt;
        private System.Windows.Forms.TextBox pw2Txt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.ComboBox ph0Select;
        private System.Windows.Forms.TextBox ph1Txt;
        private System.Windows.Forms.TextBox ph2Txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDupChk;
    }
}