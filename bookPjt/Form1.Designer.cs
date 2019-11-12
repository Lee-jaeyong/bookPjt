namespace bookPjt
{
    partial class bookManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.subBookImg = new System.Windows.Forms.Label();
            this.categoryList = new System.Windows.Forms.ComboBox();
            this.bookUpdateAndDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.searchBook = new System.Windows.Forms.TextBox();
            this.table = new System.Windows.Forms.DataGridView();
            this.bookIdx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.category = new System.Windows.Forms.ComboBox();
            this.publisher = new System.Windows.Forms.ComboBox();
            this.bookContent = new System.Windows.Forms.TextBox();
            this.bookStock = new System.Windows.Forms.TextBox();
            this.bookAuthor = new System.Windows.Forms.TextBox();
            this.bookName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.bookImage = new System.Windows.Forms.Label();
            this.bookImg = new System.Windows.Forms.Label();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.publisherTable = new System.Windows.Forms.DataGridView();
            this.publisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.publisherAddBtn = new System.Windows.Forms.Button();
            this.AddPublisherName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryTable = new System.Windows.Forms.DataGridView();
            this.categoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.categoryAddBtn = new System.Windows.Forms.Button();
            this.AddcategoryName = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisherTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1061, 694);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.subBookImg);
            this.tabPage1.Controls.Add(this.categoryList);
            this.tabPage1.Controls.Add(this.bookUpdateAndDelete);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.searchBook);
            this.tabPage1.Controls.Add(this.table);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1053, 685);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // subBookImg
            // 
            this.subBookImg.BackColor = System.Drawing.Color.DarkGray;
            this.subBookImg.Location = new System.Drawing.Point(661, 97);
            this.subBookImg.Name = "subBookImg";
            this.subBookImg.Size = new System.Drawing.Size(380, 354);
            this.subBookImg.TabIndex = 7;
            // 
            // categoryList
            // 
            this.categoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryList.Font = new System.Drawing.Font("굴림", 20F);
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Location = new System.Drawing.Point(196, 7);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(262, 41);
            this.categoryList.TabIndex = 5;
            this.categoryList.SelectedIndexChanged += new System.EventHandler(this.categoryList_SelectedIndexChanged);
            // 
            // bookUpdateAndDelete
            // 
            this.bookUpdateAndDelete.Location = new System.Drawing.Point(21, 5);
            this.bookUpdateAndDelete.Name = "bookUpdateAndDelete";
            this.bookUpdateAndDelete.Size = new System.Drawing.Size(140, 44);
            this.bookUpdateAndDelete.TabIndex = 4;
            this.bookUpdateAndDelete.Text = "수정 및 삭제";
            this.bookUpdateAndDelete.UseVisualStyleBackColor = true;
            this.bookUpdateAndDelete.Click += new System.EventHandler(this.bookUpdateAndDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(487, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "검 색 :";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(941, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 43);
            this.button7.TabIndex = 2;
            this.button7.Text = "검색";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // searchBook
            // 
            this.searchBook.Location = new System.Drawing.Point(596, 6);
            this.searchBook.Multiline = true;
            this.searchBook.Name = "searchBook";
            this.searchBook.Size = new System.Drawing.Size(339, 43);
            this.searchBook.TabIndex = 1;
            this.searchBook.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchBook_KeyUp);
            // 
            // table
            // 
            this.table.BackgroundColor = System.Drawing.Color.White;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdx,
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column4,
            this.Column3});
            this.table.Location = new System.Drawing.Point(3, 55);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 27;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(645, 460);
            this.table.TabIndex = 0;
            this.table.Tag = "";
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            // 
            // bookIdx
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bookIdx.DefaultCellStyle = dataGridViewCellStyle4;
            this.bookIdx.HeaderText = "도서 번호";
            this.bookIdx.MinimumWidth = 6;
            this.bookIdx.Name = "bookIdx";
            this.bookIdx.ReadOnly = true;
            this.bookIdx.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "책 이름";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column5
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "저자";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "출판사";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column4
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "분류";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "수량";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.category);
            this.tabPage2.Controls.Add(this.publisher);
            this.tabPage2.Controls.Add(this.bookContent);
            this.tabPage2.Controls.Add(this.bookStock);
            this.tabPage2.Controls.Add(this.bookAuthor);
            this.tabPage2.Controls.Add(this.bookName);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.bookImage);
            this.tabPage2.Controls.Add(this.bookImg);
            this.tabPage2.Controls.Add(this.btnAddImg);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1053, 685);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // category
            // 
            this.category.Cursor = System.Windows.Forms.Cursors.Default;
            this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(127, 286);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(296, 23);
            this.category.TabIndex = 14;
            // 
            // publisher
            // 
            this.publisher.Cursor = System.Windows.Forms.Cursors.Default;
            this.publisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publisher.FormattingEnabled = true;
            this.publisher.Location = new System.Drawing.Point(127, 227);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(296, 23);
            this.publisher.TabIndex = 14;
            // 
            // bookContent
            // 
            this.bookContent.Location = new System.Drawing.Point(127, 352);
            this.bookContent.Multiline = true;
            this.bookContent.Name = "bookContent";
            this.bookContent.Size = new System.Drawing.Size(296, 91);
            this.bookContent.TabIndex = 11;
            // 
            // bookStock
            // 
            this.bookStock.Location = new System.Drawing.Point(127, 162);
            this.bookStock.Multiline = true;
            this.bookStock.Name = "bookStock";
            this.bookStock.Size = new System.Drawing.Size(296, 36);
            this.bookStock.TabIndex = 11;
            // 
            // bookAuthor
            // 
            this.bookAuthor.Location = new System.Drawing.Point(127, 104);
            this.bookAuthor.Multiline = true;
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.Size = new System.Drawing.Size(296, 36);
            this.bookAuthor.TabIndex = 11;
            // 
            // bookName
            // 
            this.bookName.Location = new System.Drawing.Point(127, 39);
            this.bookName.Multiline = true;
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(296, 36);
            this.bookName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "줄 거 리 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "분 류 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "수 량 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "출 판 사 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "저 자 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "책 이름 :";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(807, 415);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(222, 90);
            this.button10.TabIndex = 4;
            this.button10.Text = "확 인";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(580, 415);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(222, 90);
            this.button9.TabIndex = 3;
            this.button9.Text = "초기화";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // bookImage
            // 
            this.bookImage.BackColor = System.Drawing.Color.Turquoise;
            this.bookImage.Location = new System.Drawing.Point(564, 81);
            this.bookImage.Name = "bookImage";
            this.bookImage.Size = new System.Drawing.Size(480, 306);
            this.bookImage.TabIndex = 2;
            // 
            // bookImg
            // 
            this.bookImg.BackColor = System.Drawing.Color.MediumPurple;
            this.bookImg.Location = new System.Drawing.Point(704, 31);
            this.bookImg.Name = "bookImg";
            this.bookImg.Size = new System.Drawing.Size(340, 34);
            this.bookImg.TabIndex = 1;
            // 
            // btnAddImg
            // 
            this.btnAddImg.Location = new System.Drawing.Point(567, 31);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(126, 36);
            this.btnAddImg.TabIndex = 0;
            this.btnAddImg.Text = "이미지 추가";
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1053, 685);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(531, -9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 541);
            this.label8.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.publisherTable);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.publisherAddBtn);
            this.panel2.Controls.Add(this.AddPublisherName);
            this.panel2.Location = new System.Drawing.Point(536, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 534);
            this.panel2.TabIndex = 1;
            // 
            // publisherTable
            // 
            this.publisherTable.BackgroundColor = System.Drawing.Color.White;
            this.publisherTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publisherTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.publisherName});
            this.publisherTable.Location = new System.Drawing.Point(25, 192);
            this.publisherTable.Name = "publisherTable";
            this.publisherTable.ReadOnly = true;
            this.publisherTable.RowHeadersWidth = 51;
            this.publisherTable.RowTemplate.Height = 27;
            this.publisherTable.Size = new System.Drawing.Size(458, 312);
            this.publisherTable.TabIndex = 6;
            // 
            // publisherName
            // 
            this.publisherName.Frozen = true;
            this.publisherName.HeaderText = "출판사 명";
            this.publisherName.MinimumWidth = 6;
            this.publisherName.Name = "publisherName";
            this.publisherName.ReadOnly = true;
            this.publisherName.Width = 345;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(191, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 32);
            this.label10.TabIndex = 4;
            this.label10.Text = "출판사 관리";
            // 
            // publisherAddBtn
            // 
            this.publisherAddBtn.Location = new System.Drawing.Point(25, 120);
            this.publisherAddBtn.Name = "publisherAddBtn";
            this.publisherAddBtn.Size = new System.Drawing.Size(108, 47);
            this.publisherAddBtn.TabIndex = 3;
            this.publisherAddBtn.Text = "추가";
            this.publisherAddBtn.UseVisualStyleBackColor = true;
            this.publisherAddBtn.Click += new System.EventHandler(this.publisherAddBtn_Click);
            // 
            // AddPublisherName
            // 
            this.AddPublisherName.Location = new System.Drawing.Point(149, 121);
            this.AddPublisherName.Multiline = true;
            this.AddPublisherName.Name = "AddPublisherName";
            this.AddPublisherName.Size = new System.Drawing.Size(334, 46);
            this.AddPublisherName.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.categoryTable);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.categoryAddBtn);
            this.panel1.Controls.Add(this.AddcategoryName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 534);
            this.panel1.TabIndex = 0;
            // 
            // categoryTable
            // 
            this.categoryTable.BackgroundColor = System.Drawing.Color.White;
            this.categoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryname});
            this.categoryTable.Location = new System.Drawing.Point(30, 192);
            this.categoryTable.Name = "categoryTable";
            this.categoryTable.ReadOnly = true;
            this.categoryTable.RowHeadersWidth = 51;
            this.categoryTable.RowTemplate.Height = 27;
            this.categoryTable.Size = new System.Drawing.Size(458, 312);
            this.categoryTable.TabIndex = 5;
            // 
            // categoryname
            // 
            this.categoryname.HeaderText = "분류 명";
            this.categoryname.MinimumWidth = 6;
            this.categoryname.Name = "categoryname";
            this.categoryname.ReadOnly = true;
            this.categoryname.Width = 345;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(149, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 34);
            this.label9.TabIndex = 4;
            this.label9.Text = "카테고리 관리";
            // 
            // categoryAddBtn
            // 
            this.categoryAddBtn.Location = new System.Drawing.Point(30, 121);
            this.categoryAddBtn.Name = "categoryAddBtn";
            this.categoryAddBtn.Size = new System.Drawing.Size(108, 47);
            this.categoryAddBtn.TabIndex = 3;
            this.categoryAddBtn.Text = "추가";
            this.categoryAddBtn.UseVisualStyleBackColor = true;
            this.categoryAddBtn.Click += new System.EventHandler(this.categoryAddBtn_Click);
            // 
            // AddcategoryName
            // 
            this.AddcategoryName.Location = new System.Drawing.Point(154, 122);
            this.AddcategoryName.Multiline = true;
            this.AddcategoryName.Name = "AddcategoryName";
            this.AddcategoryName.Size = new System.Drawing.Size(334, 46);
            this.AddcategoryName.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1053, 685);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage5.Location = new System.Drawing.Point(4, 5);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1053, 685);
            this.tabPage5.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(191, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 73);
            this.button2.TabIndex = 2;
            this.button2.Text = "도서 추가";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(565, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 73);
            this.button3.TabIndex = 4;
            this.button3.Text = "사용자 관리";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(378, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 73);
            this.button4.TabIndex = 3;
            this.button4.Text = "관리 모드";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(752, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 73);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(939, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 73);
            this.button5.TabIndex = 6;
            this.button5.Text = " ";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.Location = new System.Drawing.Point(4, 1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(188, 73);
            this.button8.TabIndex = 7;
            this.button8.Text = "도서 목록";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // bookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 609);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Name = "bookManagement";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisherTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox searchBook;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.Label bookImg;
        private System.Windows.Forms.Label bookImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox bookContent;
        private System.Windows.Forms.TextBox bookAuthor;
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.TextBox bookStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView publisherTable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button publisherAddBtn;
        private System.Windows.Forms.TextBox AddPublisherName;
        private System.Windows.Forms.DataGridView categoryTable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button categoryAddBtn;
        private System.Windows.Forms.TextBox AddcategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryname;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherName;
        private System.Windows.Forms.ComboBox categoryList;
        private System.Windows.Forms.Button bookUpdateAndDelete;
        private System.Windows.Forms.Label subBookImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox publisher;
    }
}

