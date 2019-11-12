namespace BookManagement
{
    partial class index
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookBtn = new System.Windows.Forms.Button();
            this.outBtn = new System.Windows.Forms.Button();
            this.meBtn = new System.Windows.Forms.Button();
            this.bookPanel = new System.Windows.Forms.Panel();
            this.takeBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.summaryTxt = new System.Windows.Forms.TextBox();
            this.bookImg = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookListTable = new System.Windows.Forms.DataGridView();
            this.takeBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchSelect = new System.Windows.Forms.ComboBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // bookBtn
            // 
            this.bookBtn.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bookBtn.Location = new System.Drawing.Point(-1, -1);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(90, 90);
            this.bookBtn.TabIndex = 0;
            this.bookBtn.Text = "책목록";
            this.bookBtn.UseVisualStyleBackColor = true;
            // 
            // outBtn
            // 
            this.outBtn.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.outBtn.Location = new System.Drawing.Point(183, -1);
            this.outBtn.Name = "outBtn";
            this.outBtn.Size = new System.Drawing.Size(90, 90);
            this.outBtn.TabIndex = 1;
            this.outBtn.Text = "나가기";
            this.outBtn.UseVisualStyleBackColor = true;
            // 
            // meBtn
            // 
            this.meBtn.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.meBtn.Location = new System.Drawing.Point(91, -1);
            this.meBtn.Name = "meBtn";
            this.meBtn.Size = new System.Drawing.Size(90, 90);
            this.meBtn.TabIndex = 2;
            this.meBtn.Text = "내정보";
            this.meBtn.UseVisualStyleBackColor = true;
            this.meBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // bookPanel
            // 
            this.bookPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bookPanel.Controls.Add(this.takeBtn);
            this.bookPanel.Controls.Add(this.label6);
            this.bookPanel.Controls.Add(this.summaryTxt);
            this.bookPanel.Controls.Add(this.bookImg);
            this.bookPanel.Controls.Add(this.label5);
            this.bookPanel.Controls.Add(this.label4);
            this.bookPanel.Controls.Add(this.label3);
            this.bookPanel.Controls.Add(this.label2);
            this.bookPanel.Controls.Add(this.bookListTable);
            this.bookPanel.Controls.Add(this.searchBtn);
            this.bookPanel.Controls.Add(this.searchSelect);
            this.bookPanel.Controls.Add(this.searchTxt);
            this.bookPanel.Controls.Add(this.label1);
            this.bookPanel.Location = new System.Drawing.Point(-1, 86);
            this.bookPanel.Name = "bookPanel";
            this.bookPanel.Size = new System.Drawing.Size(1066, 534);
            this.bookPanel.TabIndex = 0;
            // 
            // takeBtn
            // 
            this.takeBtn.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.takeBtn.Location = new System.Drawing.Point(883, 454);
            this.takeBtn.Name = "takeBtn";
            this.takeBtn.Size = new System.Drawing.Size(162, 61);
            this.takeBtn.TabIndex = 13;
            this.takeBtn.Text = "대출하기";
            this.takeBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(671, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "상세 : ";
            // 
            // summaryTxt
            // 
            this.summaryTxt.Enabled = false;
            this.summaryTxt.Location = new System.Drawing.Point(674, 287);
            this.summaryTxt.Multiline = true;
            this.summaryTxt.Name = "summaryTxt";
            this.summaryTxt.Size = new System.Drawing.Size(371, 150);
            this.summaryTxt.TabIndex = 10;
            // 
            // bookImg
            // 
            this.bookImg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bookImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bookImg.Location = new System.Drawing.Point(883, 58);
            this.bookImg.Name = "bookImg";
            this.bookImg.Size = new System.Drawing.Size(162, 205);
            this.bookImg.TabIndex = 5;
            this.bookImg.TabStop = false;
            this.bookImg.Click += new System.EventHandler(this.bookImg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(680, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "분류 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(666, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "출판사 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(680, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "저자 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(680, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "제목 : ";
            // 
            // bookListTable
            // 
            this.bookListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookListTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.takeBook,
            this.stock,
            this.bookName,
            this.author,
            this.publisher,
            this.category});
            this.bookListTable.Location = new System.Drawing.Point(13, 46);
            this.bookListTable.Name = "bookListTable";
            this.bookListTable.RowTemplate.Height = 23;
            this.bookListTable.Size = new System.Drawing.Size(643, 473);
            this.bookListTable.TabIndex = 4;
            // 
            // takeBook
            // 
            this.takeBook.HeaderText = "";
            this.takeBook.Name = "takeBook";
            this.takeBook.Width = 30;
            // 
            // stock
            // 
            this.stock.HeaderText = "재고";
            this.stock.Name = "stock";
            this.stock.Width = 50;
            // 
            // bookName
            // 
            this.bookName.HeaderText = "책 제목";
            this.bookName.Name = "bookName";
            this.bookName.Width = 300;
            // 
            // author
            // 
            this.author.HeaderText = "저자";
            this.author.Name = "author";
            // 
            // publisher
            // 
            this.publisher.HeaderText = "출판사";
            this.publisher.Name = "publisher";
            this.publisher.Width = 150;
            // 
            // category
            // 
            this.category.HeaderText = "분류";
            this.category.Name = "category";
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchBtn.Location = new System.Drawing.Point(445, 12);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(59, 26);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "검색";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // searchSelect
            // 
            this.searchSelect.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchSelect.FormattingEnabled = true;
            this.searchSelect.ItemHeight = 16;
            this.searchSelect.Items.AddRange(new object[] {
            "책제목",
            "저자",
            "출판사",
            "분류"});
            this.searchSelect.Location = new System.Drawing.Point(66, 13);
            this.searchSelect.Name = "searchSelect";
            this.searchSelect.Size = new System.Drawing.Size(113, 24);
            this.searchSelect.TabIndex = 2;
            this.searchSelect.Text = "책제목";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(184, 13);
            this.searchTxt.Multiline = true;
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(256, 24);
            this.searchTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "검색 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 617);
            this.Controls.Add(this.bookPanel);
            this.Controls.Add(this.meBtn);
            this.Controls.Add(this.outBtn);
            this.Controls.Add(this.bookBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.bookPanel.ResumeLayout(false);
            this.bookPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookListTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button outBtn;
        private System.Windows.Forms.Button meBtn;
        private System.Windows.Forms.Panel bookPanel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox searchSelect;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView bookListTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox summaryTxt;
        private System.Windows.Forms.PictureBox bookImg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn takeBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.Button takeBtn;
    }
}

