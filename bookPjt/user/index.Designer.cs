﻿namespace BookManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.bookBtn = new System.Windows.Forms.Button();
            this.outBtn = new System.Windows.Forms.Button();
            this.meBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBook = new System.Windows.Forms.TextBox();
            this.searchSelect = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.bookListTable = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookImg = new System.Windows.Forms.PictureBox();
            this.txtBookSummary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.takeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.txtBookPublisher = new System.Windows.Forms.TextBox();
            this.txtBookCategory = new System.Windows.Forms.TextBox();
            this.bookPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bookListTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.bookPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookBtn
            // 
            this.bookBtn.FlatAppearance.BorderSize = 0;
            this.bookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBtn.Image = ((System.Drawing.Image)(resources.GetObject("bookBtn.Image")));
            this.bookBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bookBtn.Location = new System.Drawing.Point(3, 3);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(90, 98);
            this.bookBtn.TabIndex = 0;
            this.bookBtn.Text = "책목록";
            this.bookBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // outBtn
            // 
            this.outBtn.FlatAppearance.BorderSize = 0;
            this.outBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outBtn.Image = ((System.Drawing.Image)(resources.GetObject("outBtn.Image")));
            this.outBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.outBtn.Location = new System.Drawing.Point(183, 3);
            this.outBtn.Name = "outBtn";
            this.outBtn.Size = new System.Drawing.Size(90, 98);
            this.outBtn.TabIndex = 1;
            this.outBtn.Text = "나가기";
            this.outBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.outBtn.UseVisualStyleBackColor = true;
            this.outBtn.Click += new System.EventHandler(this.outBtn_Click);
            // 
            // meBtn
            // 
            this.meBtn.FlatAppearance.BorderSize = 0;
            this.meBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.meBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meBtn.Image = ((System.Drawing.Image)(resources.GetObject("meBtn.Image")));
            this.meBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.meBtn.Location = new System.Drawing.Point(92, 3);
            this.meBtn.Name = "meBtn";
            this.meBtn.Size = new System.Drawing.Size(90, 98);
            this.meBtn.TabIndex = 2;
            this.meBtn.Text = "내정보";
            this.meBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.meBtn.UseVisualStyleBackColor = true;
            this.meBtn.Click += new System.EventHandler(this.meBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(24, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "      ";
            // 
            // searchBook
            // 
            this.searchBook.Location = new System.Drawing.Point(184, 10);
            this.searchBook.Multiline = true;
            this.searchBook.Name = "searchBook";
            this.searchBook.Size = new System.Drawing.Size(256, 24);
            this.searchBook.TabIndex = 1;
            this.searchBook.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchBook_KeyUp);
            // 
            // searchSelect
            // 
            this.searchSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchSelect.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchSelect.FormattingEnabled = true;
            this.searchSelect.ItemHeight = 16;
            this.searchSelect.Items.AddRange(new object[] {
            "책제목",
            "저자",
            "출판사",
            "분류"});
            this.searchSelect.Location = new System.Drawing.Point(66, 10);
            this.searchSelect.Name = "searchSelect";
            this.searchSelect.Size = new System.Drawing.Size(113, 24);
            this.searchSelect.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchBtn.Location = new System.Drawing.Point(445, 9);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(59, 26);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "검색";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // bookListTable
            // 
            this.bookListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookListTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.bookName,
            this.stock,
            this.author,
            this.publisher,
            this.category,
            this.Column2,
            this.Column3});
            this.bookListTable.Location = new System.Drawing.Point(13, 42);
            this.bookListTable.Name = "bookListTable";
            this.bookListTable.ReadOnly = true;
            this.bookListTable.RowHeadersWidth = 51;
            this.bookListTable.RowTemplate.Height = 23;
            this.bookListTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookListTable.Size = new System.Drawing.Size(643, 468);
            this.bookListTable.TabIndex = 4;
            this.bookListTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookListTable_CellClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "책 줄거리";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "책 이미지";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // category
            // 
            this.category.HeaderText = "분 류";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 125;
            // 
            // publisher
            // 
            this.publisher.HeaderText = "출판사";
            this.publisher.MinimumWidth = 6;
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            this.publisher.Width = 150;
            // 
            // author
            // 
            this.author.HeaderText = "저 자";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Width = 125;
            // 
            // stock
            // 
            this.stock.HeaderText = "상 태";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // bookName
            // 
            this.bookName.HeaderText = "책 제목";
            this.bookName.MinimumWidth = 6;
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            this.bookName.Width = 200;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "책 번호";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // bookImg
            // 
            this.bookImg.BackColor = System.Drawing.Color.White;
            this.bookImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookImg.Location = new System.Drawing.Point(883, 43);
            this.bookImg.Name = "bookImg";
            this.bookImg.Size = new System.Drawing.Size(162, 209);
            this.bookImg.TabIndex = 5;
            this.bookImg.TabStop = false;
            // 
            // txtBookSummary
            // 
            this.txtBookSummary.Enabled = false;
            this.txtBookSummary.Location = new System.Drawing.Point(674, 281);
            this.txtBookSummary.Multiline = true;
            this.txtBookSummary.Name = "txtBookSummary";
            this.txtBookSummary.Size = new System.Drawing.Size(371, 150);
            this.txtBookSummary.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(676, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "상세 : ";
            // 
            // takeBtn
            // 
            this.takeBtn.FlatAppearance.BorderSize = 0;
            this.takeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeBtn.Image = ((System.Drawing.Image)(resources.GetObject("takeBtn.Image")));
            this.takeBtn.Location = new System.Drawing.Point(669, 432);
            this.takeBtn.Name = "takeBtn";
            this.takeBtn.Size = new System.Drawing.Size(383, 79);
            this.takeBtn.TabIndex = 13;
            this.takeBtn.Text = "대출 신청";
            this.takeBtn.UseVisualStyleBackColor = true;
            this.takeBtn.Click += new System.EventHandler(this.takeBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtBookCategory);
            this.panel1.Controls.Add(this.txtBookPublisher);
            this.panel1.Controls.Add(this.txtBookAuthor);
            this.panel1.Controls.Add(this.txtBookName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(674, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 209);
            this.panel1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(15, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "분류 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "저자 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "제목 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(1, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "출판사 : ";
            // 
            // txtBookName
            // 
            this.txtBookName.Enabled = false;
            this.txtBookName.Location = new System.Drawing.Point(62, 27);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookName.Multiline = true;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(134, 28);
            this.txtBookName.TabIndex = 10;
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Enabled = false;
            this.txtBookAuthor.Location = new System.Drawing.Point(62, 70);
            this.txtBookAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookAuthor.Multiline = true;
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(134, 28);
            this.txtBookAuthor.TabIndex = 10;
            // 
            // txtBookPublisher
            // 
            this.txtBookPublisher.Enabled = false;
            this.txtBookPublisher.Location = new System.Drawing.Point(62, 111);
            this.txtBookPublisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookPublisher.Multiline = true;
            this.txtBookPublisher.Name = "txtBookPublisher";
            this.txtBookPublisher.Size = new System.Drawing.Size(134, 28);
            this.txtBookPublisher.TabIndex = 10;
            // 
            // txtBookCategory
            // 
            this.txtBookCategory.Enabled = false;
            this.txtBookCategory.Location = new System.Drawing.Point(62, 152);
            this.txtBookCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookCategory.Multiline = true;
            this.txtBookCategory.Name = "txtBookCategory";
            this.txtBookCategory.Size = new System.Drawing.Size(134, 28);
            this.txtBookCategory.TabIndex = 10;
            // 
            // bookPanel
            // 
            this.bookPanel.BackColor = System.Drawing.Color.White;
            this.bookPanel.Controls.Add(this.panel1);
            this.bookPanel.Controls.Add(this.takeBtn);
            this.bookPanel.Controls.Add(this.label6);
            this.bookPanel.Controls.Add(this.txtBookSummary);
            this.bookPanel.Controls.Add(this.bookImg);
            this.bookPanel.Controls.Add(this.bookListTable);
            this.bookPanel.Controls.Add(this.searchBtn);
            this.bookPanel.Controls.Add(this.searchSelect);
            this.bookPanel.Controls.Add(this.searchBook);
            this.bookPanel.Controls.Add(this.label1);
            this.bookPanel.Location = new System.Drawing.Point(-1, 99);
            this.bookPanel.Name = "bookPanel";
            this.bookPanel.Size = new System.Drawing.Size(1066, 522);
            this.bookPanel.TabIndex = 0;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 617);
            this.Controls.Add(this.bookPanel);
            this.Controls.Add(this.meBtn);
            this.Controls.Add(this.outBtn);
            this.Controls.Add(this.bookBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "index";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookListTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bookPanel.ResumeLayout(false);
            this.bookPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button outBtn;
        private System.Windows.Forms.Button meBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBook;
        private System.Windows.Forms.ComboBox searchSelect;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView bookListTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.PictureBox bookImg;
        private System.Windows.Forms.TextBox txtBookSummary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button takeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBookCategory;
        private System.Windows.Forms.TextBox txtBookPublisher;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel bookPanel;
    }
}

