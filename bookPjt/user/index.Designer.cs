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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.bookBtn = new System.Windows.Forms.Button();
            this.outBtn = new System.Windows.Forms.Button();
            this.meBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBook = new System.Windows.Forms.TextBox();
            this.searchSelect = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.bookListTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookImg = new System.Windows.Forms.PictureBox();
            this.txtBookSummary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.takeBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBookCategory = new System.Windows.Forms.TextBox();
            this.txtBookPublisher = new System.Windows.Forms.TextBox();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bookPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.changePass = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChangePassChk = new System.Windows.Forms.TextBox();
            this.txtChangePass = new System.Windows.Forms.TextBox();
            this.btnUserUpdateCencel = new System.Windows.Forms.Button();
            this.btnUserUpdateExecute = new System.Windows.Forms.Button();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.txtUserBirth = new System.Windows.Forms.TextBox();
            this.txtUserPhone3 = new System.Windows.Forms.TextBox();
            this.txtUserPhone2 = new System.Windows.Forms.TextBox();
            this.txtUserPhone1 = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.rentalChkTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ComboRental = new System.Windows.Forms.ComboBox();
            this.rentalBookInfoTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookListTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.bookPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalChkTable)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentalBookInfoTable)).BeginInit();
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
            this.outBtn.Location = new System.Drawing.Point(965, 3);
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
            this.label1.Location = new System.Drawing.Point(24, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "      ";
            // 
            // searchBook
            // 
            this.searchBook.Location = new System.Drawing.Point(184, 8);
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
            this.searchSelect.Location = new System.Drawing.Point(66, 8);
            this.searchSelect.Name = "searchSelect";
            this.searchSelect.Size = new System.Drawing.Size(113, 24);
            this.searchSelect.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.searchBtn.Location = new System.Drawing.Point(445, 7);
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
            this.bookListTable.Location = new System.Drawing.Point(13, 43);
            this.bookListTable.Name = "bookListTable";
            this.bookListTable.ReadOnly = true;
            this.bookListTable.RowHeadersWidth = 51;
            this.bookListTable.RowTemplate.Height = 23;
            this.bookListTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookListTable.Size = new System.Drawing.Size(643, 443);
            this.bookListTable.TabIndex = 4;
            this.bookListTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookListTable_CellClick);
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
            // bookName
            // 
            this.bookName.HeaderText = "책 제목";
            this.bookName.MinimumWidth = 6;
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            this.bookName.Width = 200;
            // 
            // stock
            // 
            this.stock.HeaderText = "상 태";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 125;
            // 
            // author
            // 
            this.author.HeaderText = "저 자";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Width = 125;
            // 
            // publisher
            // 
            this.publisher.HeaderText = "출판사";
            this.publisher.MinimumWidth = 6;
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            this.publisher.Width = 150;
            // 
            // category
            // 
            this.category.HeaderText = "분 류";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "책 이미지";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "책 줄거리";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // bookImg
            // 
            this.bookImg.BackColor = System.Drawing.Color.White;
            this.bookImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookImg.Location = new System.Drawing.Point(883, 41);
            this.bookImg.Name = "bookImg";
            this.bookImg.Size = new System.Drawing.Size(152, 209);
            this.bookImg.TabIndex = 5;
            this.bookImg.TabStop = false;
            // 
            // txtBookSummary
            // 
            this.txtBookSummary.Enabled = false;
            this.txtBookSummary.Location = new System.Drawing.Point(674, 279);
            this.txtBookSummary.Multiline = true;
            this.txtBookSummary.Name = "txtBookSummary";
            this.txtBookSummary.Size = new System.Drawing.Size(361, 142);
            this.txtBookSummary.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(676, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "상세 : ";
            // 
            // takeBtn
            // 
            this.takeBtn.FlatAppearance.BorderSize = 0;
            this.takeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeBtn.Image = ((System.Drawing.Image)(resources.GetObject("takeBtn.Image")));
            this.takeBtn.Location = new System.Drawing.Point(679, 428);
            this.takeBtn.Name = "takeBtn";
            this.takeBtn.Size = new System.Drawing.Size(351, 54);
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
            this.panel1.Location = new System.Drawing.Point(674, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 209);
            this.panel1.TabIndex = 14;
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
            this.bookPanel.Location = new System.Drawing.Point(3, 5);
            this.bookPanel.Name = "bookPanel";
            this.bookPanel.Size = new System.Drawing.Size(1038, 489);
            this.bookPanel.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(3, 107);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1052, 507);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.bookPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1044, 498);
            this.tabPage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1044, 498);
            this.tabPage2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnUserUpdateCencel);
            this.panel2.Controls.Add(this.btnUserUpdateExecute);
            this.panel2.Controls.Add(this.btnUserUpdate);
            this.panel2.Controls.Add(this.txtUserBirth);
            this.panel2.Controls.Add(this.txtUserPhone3);
            this.panel2.Controls.Add(this.txtUserPhone2);
            this.panel2.Controls.Add(this.txtUserPhone1);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.txtUserId);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 493);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.changePass);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtChangePassChk);
            this.panel3.Controls.Add(this.txtChangePass);
            this.panel3.Location = new System.Drawing.Point(207, 278);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 103);
            this.panel3.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(38, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "변경 비밀번호 :";
            // 
            // changePass
            // 
            this.changePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.changePass.Location = new System.Drawing.Point(473, 24);
            this.changePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(132, 53);
            this.changePass.TabIndex = 2;
            this.changePass.Text = "비밀번호 변경";
            this.changePass.UseVisualStyleBackColor = true;
            this.changePass.Click += new System.EventHandler(this.changePass_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(25, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "비밀번호 재입력 :";
            // 
            // txtChangePassChk
            // 
            this.txtChangePassChk.Location = new System.Drawing.Point(151, 53);
            this.txtChangePassChk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChangePassChk.Multiline = true;
            this.txtChangePassChk.Name = "txtChangePassChk";
            this.txtChangePassChk.PasswordChar = '*';
            this.txtChangePassChk.Size = new System.Drawing.Size(285, 30);
            this.txtChangePassChk.TabIndex = 1;
            // 
            // txtChangePass
            // 
            this.txtChangePass.Location = new System.Drawing.Point(151, 16);
            this.txtChangePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChangePass.Multiline = true;
            this.txtChangePass.Name = "txtChangePass";
            this.txtChangePass.PasswordChar = '*';
            this.txtChangePass.Size = new System.Drawing.Size(285, 30);
            this.txtChangePass.TabIndex = 1;
            // 
            // btnUserUpdateCencel
            // 
            this.btnUserUpdateCencel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUserUpdateCencel.Location = new System.Drawing.Point(681, 154);
            this.btnUserUpdateCencel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserUpdateCencel.Name = "btnUserUpdateCencel";
            this.btnUserUpdateCencel.Size = new System.Drawing.Size(132, 53);
            this.btnUserUpdateCencel.TabIndex = 16;
            this.btnUserUpdateCencel.Text = "취 소";
            this.btnUserUpdateCencel.UseVisualStyleBackColor = true;
            this.btnUserUpdateCencel.Visible = false;
            this.btnUserUpdateCencel.Click += new System.EventHandler(this.btnUserUpdateCencel_Click);
            // 
            // btnUserUpdateExecute
            // 
            this.btnUserUpdateExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUserUpdateExecute.Location = new System.Drawing.Point(681, 87);
            this.btnUserUpdateExecute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserUpdateExecute.Name = "btnUserUpdateExecute";
            this.btnUserUpdateExecute.Size = new System.Drawing.Size(132, 53);
            this.btnUserUpdateExecute.TabIndex = 17;
            this.btnUserUpdateExecute.Text = "수 정";
            this.btnUserUpdateExecute.UseVisualStyleBackColor = true;
            this.btnUserUpdateExecute.Visible = false;
            this.btnUserUpdateExecute.Click += new System.EventHandler(this.btnUserUpdateExecute_Click);
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUserUpdate.Location = new System.Drawing.Point(681, 87);
            this.btnUserUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(132, 53);
            this.btnUserUpdate.TabIndex = 18;
            this.btnUserUpdate.Text = "정보 수정";
            this.btnUserUpdate.UseVisualStyleBackColor = true;
            this.btnUserUpdate.Click += new System.EventHandler(this.btnUserUpdate_Click);
            // 
            // txtUserBirth
            // 
            this.txtUserBirth.Enabled = false;
            this.txtUserBirth.Location = new System.Drawing.Point(351, 220);
            this.txtUserBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserBirth.Multiline = true;
            this.txtUserBirth.Name = "txtUserBirth";
            this.txtUserBirth.Size = new System.Drawing.Size(293, 30);
            this.txtUserBirth.TabIndex = 10;
            // 
            // txtUserPhone3
            // 
            this.txtUserPhone3.Enabled = false;
            this.txtUserPhone3.Location = new System.Drawing.Point(571, 177);
            this.txtUserPhone3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserPhone3.Multiline = true;
            this.txtUserPhone3.Name = "txtUserPhone3";
            this.txtUserPhone3.Size = new System.Drawing.Size(73, 30);
            this.txtUserPhone3.TabIndex = 11;
            // 
            // txtUserPhone2
            // 
            this.txtUserPhone2.Enabled = false;
            this.txtUserPhone2.Location = new System.Drawing.Point(463, 177);
            this.txtUserPhone2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserPhone2.Multiline = true;
            this.txtUserPhone2.Name = "txtUserPhone2";
            this.txtUserPhone2.Size = new System.Drawing.Size(73, 30);
            this.txtUserPhone2.TabIndex = 12;
            // 
            // txtUserPhone1
            // 
            this.txtUserPhone1.Enabled = false;
            this.txtUserPhone1.Location = new System.Drawing.Point(351, 177);
            this.txtUserPhone1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserPhone1.Multiline = true;
            this.txtUserPhone1.Name = "txtUserPhone1";
            this.txtUserPhone1.Size = new System.Drawing.Size(73, 30);
            this.txtUserPhone1.TabIndex = 13;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(351, 135);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(293, 30);
            this.txtUserName.TabIndex = 14;
            // 
            // txtUserId
            // 
            this.txtUserId.Enabled = false;
            this.txtUserId.Location = new System.Drawing.Point(351, 87);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserId.Multiline = true;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(293, 30);
            this.txtUserId.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(264, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "생년월일 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(547, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(438, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(246, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 18);
            this.label12.TabIndex = 7;
            this.label12.Text = "핸드폰 번호 :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(286, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 18);
            this.label13.TabIndex = 8;
            this.label13.Text = "이 름 :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(277, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 18);
            this.label14.TabIndex = 9;
            this.label14.Text = "아이디 :";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.rentalChkTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1044, 498);
            this.tabPage3.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(916, 11);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 42);
            this.button4.TabIndex = 6;
            this.button4.Text = "대출 신청 취소";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // rentalChkTable
            // 
            this.rentalChkTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalChkTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.rentalChkTable.Location = new System.Drawing.Point(7, 58);
            this.rentalChkTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentalChkTable.Name = "rentalChkTable";
            this.rentalChkTable.ReadOnly = true;
            this.rentalChkTable.RowHeadersWidth = 51;
            this.rentalChkTable.RowTemplate.Height = 27;
            this.rentalChkTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentalChkTable.Size = new System.Drawing.Size(645, 278);
            this.rentalChkTable.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "신청 도서명";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "대출 신청일";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ComboRental);
            this.tabPage4.Controls.Add(this.rentalBookInfoTable);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Location = new System.Drawing.Point(4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1044, 498);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ComboRental
            // 
            this.ComboRental.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboRental.FormattingEnabled = true;
            this.ComboRental.Items.AddRange(new object[] {
            "대출 중",
            "반납 완료",
            "연 체"});
            this.ComboRental.Location = new System.Drawing.Point(5, 20);
            this.ComboRental.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboRental.Name = "ComboRental";
            this.ComboRental.Size = new System.Drawing.Size(151, 20);
            this.ComboRental.TabIndex = 11;
            this.ComboRental.SelectedIndexChanged += new System.EventHandler(this.ComboRental_SelectedIndexChanged);
            // 
            // rentalBookInfoTable
            // 
            this.rentalBookInfoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalBookInfoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.rentalBookInfoTable.Location = new System.Drawing.Point(5, 54);
            this.rentalBookInfoTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentalBookInfoTable.Name = "rentalBookInfoTable";
            this.rentalBookInfoTable.ReadOnly = true;
            this.rentalBookInfoTable.RowHeadersWidth = 51;
            this.rentalBookInfoTable.RowTemplate.Height = 27;
            this.rentalBookInfoTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentalBookInfoTable.Size = new System.Drawing.Size(1034, 436);
            this.rentalBookInfoTable.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "도서명";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "대출 일자";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "반납 일자";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "연장 횟수";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "상 태";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(815, 8);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 42);
            this.button3.TabIndex = 9;
            this.button3.Text = "연 장";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 98);
            this.button1.TabIndex = 4;
            this.button1.Text = "대출 신청 현황";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 98);
            this.button2.TabIndex = 4;
            this.button2.Text = "대출 현황";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(428, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 98);
            this.button5.TabIndex = 4;
            this.button5.Text = "희망 도서 신청";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(548, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 98);
            this.button6.TabIndex = 4;
            this.button6.Text = "공지 사항";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 617);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rentalChkTable)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rentalBookInfoTable)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button changePass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChangePassChk;
        private System.Windows.Forms.TextBox txtChangePass;
        private System.Windows.Forms.Button btnUserUpdateCencel;
        private System.Windows.Forms.Button btnUserUpdateExecute;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.TextBox txtUserBirth;
        private System.Windows.Forms.TextBox txtUserPhone3;
        private System.Windows.Forms.TextBox txtUserPhone2;
        private System.Windows.Forms.TextBox txtUserPhone1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView rentalChkTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView rentalBookInfoTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox ComboRental;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

