namespace bookPjt
{
    partial class IdPw_SearchForm
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
            this.idTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.idFindPh2 = new System.Windows.Forms.TextBox();
            this.idFindPh1 = new System.Windows.Forms.TextBox();
            this.idFindPh0 = new System.Windows.Forms.ComboBox();
            this.idFindName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idFindBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pwFindName = new System.Windows.Forms.TextBox();
            this.pwFindId = new System.Windows.Forms.TextBox();
            this.pwFindBtn = new System.Windows.Forms.Button();
            this.idTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idTab
            // 
            this.idTab.Controls.Add(this.tabPage1);
            this.idTab.Controls.Add(this.tabPage2);
            this.idTab.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idTab.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.idTab.ItemSize = new System.Drawing.Size(120, 50);
            this.idTab.Location = new System.Drawing.Point(0, 0);
            this.idTab.Name = "idTab";
            this.idTab.Padding = new System.Drawing.Point(14, 3);
            this.idTab.SelectedIndex = 0;
            this.idTab.Size = new System.Drawing.Size(383, 416);
            this.idTab.TabIndex = 0;
            this.idTab.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.idFindBtn);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.idFindPh2);
            this.tabPage1.Controls.Add(this.idFindPh1);
            this.tabPage1.Controls.Add(this.idFindPh0);
            this.tabPage1.Controls.Add(this.idFindName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(375, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "아이디찾기";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // idFindPh2
            // 
            this.idFindPh2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idFindPh2.Location = new System.Drawing.Point(268, 153);
            this.idFindPh2.Name = "idFindPh2";
            this.idFindPh2.Size = new System.Drawing.Size(71, 26);
            this.idFindPh2.TabIndex = 7;
            this.idFindPh2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idFindPh2_KeyDown);
            // 
            // idFindPh1
            // 
            this.idFindPh1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idFindPh1.Location = new System.Drawing.Point(179, 153);
            this.idFindPh1.Name = "idFindPh1";
            this.idFindPh1.Size = new System.Drawing.Size(71, 26);
            this.idFindPh1.TabIndex = 6;
            // 
            // idFindPh0
            // 
            this.idFindPh0.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idFindPh0.FormattingEnabled = true;
            this.idFindPh0.ItemHeight = 17;
            this.idFindPh0.Items.AddRange(new object[] {
            "010",
            "070",
            "02",
            "030",
            "031",
            "011",
            "061"});
            this.idFindPh0.Location = new System.Drawing.Point(101, 154);
            this.idFindPh0.Name = "idFindPh0";
            this.idFindPh0.Size = new System.Drawing.Size(60, 25);
            this.idFindPh0.TabIndex = 5;
            // 
            // idFindName
            // 
            this.idFindName.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idFindName.Location = new System.Drawing.Point(101, 99);
            this.idFindName.Name = "idFindName";
            this.idFindName.Size = new System.Drawing.Size(238, 26);
            this.idFindName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "전화번호 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 : ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pwFindBtn);
            this.tabPage2.Controls.Add(this.pwFindId);
            this.tabPage2.Controls.Add(this.pwFindName);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(375, 358);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "비밀번호찾기";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "-";
            // 
            // idFindBtn
            // 
            this.idFindBtn.Location = new System.Drawing.Point(126, 254);
            this.idFindBtn.Name = "idFindBtn";
            this.idFindBtn.Size = new System.Drawing.Size(124, 40);
            this.idFindBtn.TabIndex = 10;
            this.idFindBtn.Text = "확인";
            this.idFindBtn.UseVisualStyleBackColor = true;
            this.idFindBtn.Click += new System.EventHandler(this.idFindBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "이름 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "아이디 : ";
            // 
            // pwFindName
            // 
            this.pwFindName.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwFindName.Location = new System.Drawing.Point(101, 99);
            this.pwFindName.Name = "pwFindName";
            this.pwFindName.Size = new System.Drawing.Size(238, 26);
            this.pwFindName.TabIndex = 2;
            // 
            // pwFindId
            // 
            this.pwFindId.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwFindId.Location = new System.Drawing.Point(101, 153);
            this.pwFindId.Name = "pwFindId";
            this.pwFindId.Size = new System.Drawing.Size(238, 26);
            this.pwFindId.TabIndex = 3;
            this.pwFindId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pwFindId_KeyUp);
            // 
            // pwFindBtn
            // 
            this.pwFindBtn.Location = new System.Drawing.Point(126, 254);
            this.pwFindBtn.Name = "pwFindBtn";
            this.pwFindBtn.Size = new System.Drawing.Size(124, 40);
            this.pwFindBtn.TabIndex = 4;
            this.pwFindBtn.Text = "확인";
            this.pwFindBtn.UseVisualStyleBackColor = true;
            this.pwFindBtn.Click += new System.EventHandler(this.pwFindBtn_Click);
            // 
            // IdPw_SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 416);
            this.Controls.Add(this.idTab);
            this.Name = "IdPw_SearchForm";
            this.Text = "아이디/비번 찾기";
            this.idTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl idTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox idFindName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idFindPh2;
        private System.Windows.Forms.TextBox idFindPh1;
        private System.Windows.Forms.ComboBox idFindPh0;
        private System.Windows.Forms.Button idFindBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pwFindName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pwFindId;
        private System.Windows.Forms.Button pwFindBtn;
    }
}