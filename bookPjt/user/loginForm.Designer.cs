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
            this.idTxt.Location = new System.Drawing.Point(547, 242);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(304, 34);
            this.idTxt.TabIndex = 0;
            // 
            // pwTxt
            // 
            this.pwTxt.Font = new System.Drawing.Font("굴림", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwTxt.Location = new System.Drawing.Point(547, 289);
            this.pwTxt.Name = "pwTxt";
            this.pwTxt.PasswordChar = '●';
            this.pwTxt.Size = new System.Drawing.Size(304, 34);
            this.pwTxt.TabIndex = 1;
            this.pwTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwTxt_KeyDown);
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginBtn.Location = new System.Drawing.Point(860, 242);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(122, 78);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "로그인";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // joinBtn
            // 
            this.joinBtn.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.joinBtn.Location = new System.Drawing.Point(637, 329);
            this.joinBtn.Name = "joinBtn";
            this.joinBtn.Size = new System.Drawing.Size(169, 28);
            this.joinBtn.TabIndex = 3;
            this.joinBtn.Text = "회원가입";
            this.joinBtn.UseVisualStyleBackColor = true;
            this.joinBtn.Click += new System.EventHandler(this.joinBtn_Click);
            // 
            // id_pwFindBtn
            // 
            this.id_pwFindBtn.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id_pwFindBtn.Location = new System.Drawing.Point(812, 329);
            this.id_pwFindBtn.Name = "id_pwFindBtn";
            this.id_pwFindBtn.Size = new System.Drawing.Size(169, 28);
            this.id_pwFindBtn.TabIndex = 4;
            this.id_pwFindBtn.Text = "아이디 / 비밀번호 찾기";
            this.id_pwFindBtn.UseVisualStyleBackColor = true;
            this.id_pwFindBtn.Click += new System.EventHandler(this.id_pwFindBtn_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 617);
            this.Controls.Add(this.id_pwFindBtn);
            this.Controls.Add(this.joinBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pwTxt);
            this.Controls.Add(this.idTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginForm";
            this.Text = "로그인";
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