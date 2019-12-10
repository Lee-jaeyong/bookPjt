namespace BookManagement
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.idTxt = new System.Windows.Forms.TextBox();
            this.pwTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.joinBtn = new System.Windows.Forms.Button();
            this.id_pwFindBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idTxt
            // 
            this.idTxt.Font = new System.Drawing.Font("굴림", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idTxt.Location = new System.Drawing.Point(625, 302);
            this.idTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(347, 41);
            this.idTxt.TabIndex = 0;
            // 
            // pwTxt
            // 
            this.pwTxt.Font = new System.Drawing.Font("굴림", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwTxt.Location = new System.Drawing.Point(625, 361);
            this.pwTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pwTxt.Name = "pwTxt";
            this.pwTxt.PasswordChar = '●';
            this.pwTxt.Size = new System.Drawing.Size(347, 41);
            this.pwTxt.TabIndex = 1;
            this.pwTxt.Enter += new System.EventHandler(this.pwTxt_Enter);
            this.pwTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwTxt_KeyDown);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginBtn.Image = ((System.Drawing.Image)(resources.GetObject("loginBtn.Image")));
            this.loginBtn.Location = new System.Drawing.Point(975, 311);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(157, 84);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "로그인";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // joinBtn
            // 
            this.joinBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.joinBtn.FlatAppearance.BorderSize = 0;
            this.joinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joinBtn.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.joinBtn.Image = ((System.Drawing.Image)(resources.GetObject("joinBtn.Image")));
            this.joinBtn.Location = new System.Drawing.Point(713, 411);
            this.joinBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.joinBtn.Name = "joinBtn";
            this.joinBtn.Size = new System.Drawing.Size(208, 48);
            this.joinBtn.TabIndex = 3;
            this.joinBtn.Text = "회원가입";
            this.joinBtn.UseVisualStyleBackColor = false;
            this.joinBtn.Click += new System.EventHandler(this.joinBtn_Click);
            // 
            // id_pwFindBtn
            // 
            this.id_pwFindBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.id_pwFindBtn.FlatAppearance.BorderSize = 0;
            this.id_pwFindBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.id_pwFindBtn.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id_pwFindBtn.Image = ((System.Drawing.Image)(resources.GetObject("id_pwFindBtn.Image")));
            this.id_pwFindBtn.Location = new System.Drawing.Point(925, 411);
            this.id_pwFindBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id_pwFindBtn.Name = "id_pwFindBtn";
            this.id_pwFindBtn.Size = new System.Drawing.Size(208, 48);
            this.id_pwFindBtn.TabIndex = 4;
            this.id_pwFindBtn.Text = "아이디 / 비밀번호 찾기";
            this.id_pwFindBtn.UseVisualStyleBackColor = false;
            this.id_pwFindBtn.Click += new System.EventHandler(this.id_pwFindBtn_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 771);
            this.Controls.Add(this.id_pwFindBtn);
            this.Controls.Add(this.joinBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pwTxt);
            this.Controls.Add(this.idTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "loginForm";
            this.Text = "로그인";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.loginForm_FormClosing);
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox pwTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button joinBtn;
        private System.Windows.Forms.Button id_pwFindBtn;
    }
}