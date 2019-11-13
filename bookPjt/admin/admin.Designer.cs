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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.subBookImg = new System.Windows.Forms.Label();
            this.categoryList = new System.Windows.Forms.ComboBox();
            this.bookUpdateAndDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publisherTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTable)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(4, 134);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(924, 465);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.subBookImg);
            this.tabPage1.Controls.Add(this.categoryList);
            this.tabPage1.Controls.Add(this.bookUpdateAndDelete);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.searchBook);
            this.tabPage1.Controls.Add(this.table);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(916, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "도서명 :";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(71, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 28);
            this.textBox1.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(465, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 16);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "최신 등록 순";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("굴림", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(305, 16);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // subBookImg
            // 
            this.subBookImg.BackColor = System.Drawing.Color.White;
            this.subBookImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subBookImg.Image = ((System.Drawing.Image)(resources.GetObject("subBookImg.Image")));
            this.subBookImg.Location = new System.Drawing.Point(571, 54);
            this.subBookImg.Name = "subBookImg";
            this.subBookImg.Size = new System.Drawing.Size(337, 164);
            this.subBookImg.TabIndex = 7;
            // 
            // categoryList
            // 
            this.categoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryList.Font = new System.Drawing.Font("굴림", 10F);
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Location = new System.Drawing.Point(147, 17);
            this.categoryList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(144, 21);
            this.categoryList.TabIndex = 5;
            this.categoryList.SelectedIndexChanged += new System.EventHandler(this.categoryList_SelectedIndexChanged);
            // 
            // bookUpdateAndDelete
            // 
            this.bookUpdateAndDelete.BackColor = System.Drawing.Color.Gray;
            this.bookUpdateAndDelete.FlatAppearance.BorderSize = 0;
            this.bookUpdateAndDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookUpdateAndDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bookUpdateAndDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookUpdateAndDelete.Location = new System.Drawing.Point(10, 11);
            this.bookUpdateAndDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookUpdateAndDelete.Name = "bookUpdateAndDelete";
            this.bookUpdateAndDelete.Size = new System.Drawing.Size(122, 35);
            this.bookUpdateAndDelete.TabIndex = 4;
            this.bookUpdateAndDelete.Text = "수정 및 삭제 ";
            this.bookUpdateAndDelete.UseVisualStyleBackColor = false;
            this.bookUpdateAndDelete.Click += new System.EventHandler(this.bookUpdateAndDelete_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(565, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 36);
            this.label2.TabIndex = 3;
            // 
            // searchBook
            // 
            this.searchBook.Location = new System.Drawing.Point(611, 11);
            this.searchBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBook.Multiline = true;
            this.searchBook.Name = "searchBook";
            this.searchBook.Size = new System.Drawing.Size(297, 35);
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
            this.table.Location = new System.Drawing.Point(1, 54);
            this.table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 27;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(564, 389);
            this.table.TabIndex = 0;
            this.table.Tag = "";
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellClick);
            // 
            // bookIdx
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bookIdx.DefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(916, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // category
            // 
            this.category.Cursor = System.Windows.Forms.Cursors.Default;
            this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(111, 229);
            this.category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(260, 20);
            this.category.TabIndex = 14;
            // 
            // publisher
            // 
            this.publisher.Cursor = System.Windows.Forms.Cursors.Default;
            this.publisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.publisher.FormattingEnabled = true;
            this.publisher.Location = new System.Drawing.Point(111, 182);
            this.publisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(260, 20);
            this.publisher.TabIndex = 14;
            // 
            // bookContent
            // 
            this.bookContent.Location = new System.Drawing.Point(111, 282);
            this.bookContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookContent.Multiline = true;
            this.bookContent.Name = "bookContent";
            this.bookContent.Size = new System.Drawing.Size(260, 74);
            this.bookContent.TabIndex = 11;
            // 
            // bookStock
            // 
            this.bookStock.Location = new System.Drawing.Point(111, 130);
            this.bookStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookStock.Multiline = true;
            this.bookStock.Name = "bookStock";
            this.bookStock.Size = new System.Drawing.Size(260, 30);
            this.bookStock.TabIndex = 11;
            // 
            // bookAuthor
            // 
            this.bookAuthor.Location = new System.Drawing.Point(111, 83);
            this.bookAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookAuthor.Multiline = true;
            this.bookAuthor.Name = "bookAuthor";
            this.bookAuthor.Size = new System.Drawing.Size(260, 30);
            this.bookAuthor.TabIndex = 11;
            // 
            // bookName
            // 
            this.bookName.Location = new System.Drawing.Point(111, 31);
            this.bookName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookName.Multiline = true;
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(260, 30);
            this.bookName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "줄 거 리 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "분 류 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "수 량 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "출 판 사 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "저 자 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "책 이름 :";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(706, 332);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(194, 72);
            this.button10.TabIndex = 4;
            this.button10.Text = "확 인";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(508, 332);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(194, 72);
            this.button9.TabIndex = 3;
            this.button9.Text = "초기화";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // bookImage
            // 
            this.bookImage.BackColor = System.Drawing.Color.Turquoise;
            this.bookImage.Location = new System.Drawing.Point(494, 65);
            this.bookImage.Name = "bookImage";
            this.bookImage.Size = new System.Drawing.Size(420, 245);
            this.bookImage.TabIndex = 2;
            // 
            // bookImg
            // 
            this.bookImg.BackColor = System.Drawing.Color.MediumPurple;
            this.bookImg.Location = new System.Drawing.Point(616, 25);
            this.bookImg.Name = "bookImg";
            this.bookImg.Size = new System.Drawing.Size(298, 27);
            this.bookImg.TabIndex = 1;
            // 
            // btnAddImg
            // 
            this.btnAddImg.Location = new System.Drawing.Point(496, 25);
            this.btnAddImg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(110, 29);
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
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(916, 447);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(465, -7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(9, 433);
            this.label8.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.publisherTable);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.publisherAddBtn);
            this.panel2.Controls.Add(this.AddPublisherName);
            this.panel2.Location = new System.Drawing.Point(469, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 427);
            this.panel2.TabIndex = 1;
            // 
            // publisherTable
            // 
            this.publisherTable.BackgroundColor = System.Drawing.Color.White;
            this.publisherTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publisherTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.publisherName});
            this.publisherTable.Location = new System.Drawing.Point(22, 154);
            this.publisherTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publisherTable.Name = "publisherTable";
            this.publisherTable.ReadOnly = true;
            this.publisherTable.RowHeadersWidth = 51;
            this.publisherTable.RowTemplate.Height = 27;
            this.publisherTable.Size = new System.Drawing.Size(401, 250);
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
            this.label10.Location = new System.Drawing.Point(167, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 26);
            this.label10.TabIndex = 4;
            this.label10.Text = "출판사 관리";
            // 
            // publisherAddBtn
            // 
            this.publisherAddBtn.Location = new System.Drawing.Point(22, 96);
            this.publisherAddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publisherAddBtn.Name = "publisherAddBtn";
            this.publisherAddBtn.Size = new System.Drawing.Size(94, 38);
            this.publisherAddBtn.TabIndex = 3;
            this.publisherAddBtn.Text = "추가";
            this.publisherAddBtn.UseVisualStyleBackColor = true;
            this.publisherAddBtn.Click += new System.EventHandler(this.publisherAddBtn_Click);
            // 
            // AddPublisherName
            // 
            this.AddPublisherName.Location = new System.Drawing.Point(130, 97);
            this.AddPublisherName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddPublisherName.Multiline = true;
            this.AddPublisherName.Name = "AddPublisherName";
            this.AddPublisherName.Size = new System.Drawing.Size(293, 38);
            this.AddPublisherName.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.categoryTable);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.categoryAddBtn);
            this.panel1.Controls.Add(this.AddcategoryName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 427);
            this.panel1.TabIndex = 0;
            // 
            // categoryTable
            // 
            this.categoryTable.BackgroundColor = System.Drawing.Color.White;
            this.categoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryname});
            this.categoryTable.Location = new System.Drawing.Point(26, 154);
            this.categoryTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryTable.Name = "categoryTable";
            this.categoryTable.ReadOnly = true;
            this.categoryTable.RowHeadersWidth = 51;
            this.categoryTable.RowTemplate.Height = 27;
            this.categoryTable.Size = new System.Drawing.Size(401, 250);
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
            this.label9.Location = new System.Drawing.Point(130, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 27);
            this.label9.TabIndex = 4;
            this.label9.Text = "카테고리 관리";
            // 
            // categoryAddBtn
            // 
            this.categoryAddBtn.Location = new System.Drawing.Point(26, 97);
            this.categoryAddBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryAddBtn.Name = "categoryAddBtn";
            this.categoryAddBtn.Size = new System.Drawing.Size(94, 38);
            this.categoryAddBtn.TabIndex = 3;
            this.categoryAddBtn.Text = "추가";
            this.categoryAddBtn.UseVisualStyleBackColor = true;
            this.categoryAddBtn.Click += new System.EventHandler(this.categoryAddBtn_Click);
            // 
            // AddcategoryName
            // 
            this.AddcategoryName.Location = new System.Drawing.Point(135, 98);
            this.AddcategoryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddcategoryName.Multiline = true;
            this.AddcategoryName.Name = "AddcategoryName";
            this.AddcategoryName.Size = new System.Drawing.Size(293, 38);
            this.AddcategoryName.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 5);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(916, 447);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage5.Location = new System.Drawing.Point(4, 5);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(916, 447);
            this.tabPage5.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(128, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 108);
            this.button2.TabIndex = 2;
            this.button2.Text = "도서 추가";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(366, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 108);
            this.button3.TabIndex = 4;
            this.button3.Text = "대여 현황 관리";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(249, 11);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 108);
            this.button4.TabIndex = 3;
            this.button4.Text = "관리 모드";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(802, 11);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 108);
            this.button5.TabIndex = 6;
            this.button5.Text = " 로그아웃";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Cursor = System.Windows.Forms.Cursors.Default;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.Location = new System.Drawing.Point(14, 11);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(108, 107);
            this.button8.TabIndex = 7;
            this.button8.Text = "도서 목록";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(483, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 107);
            this.button1.TabIndex = 8;
            this.button1.Text = "대여 현황 관리";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(71, 46);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 28);
            this.textBox2.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "저 자 :";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(71, 80);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(249, 28);
            this.textBox3.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 12);
            this.label13.TabIndex = 11;
            this.label13.Text = "출판사 :";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(71, 114);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(249, 28);
            this.textBox4.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "분 류 :";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(71, 148);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(249, 28);
            this.textBox5.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 12);
            this.label15.TabIndex = 11;
            this.label15.Text = "상태 :";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(71, 184);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(249, 28);
            this.textBox6.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 192);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 12);
            this.label16.TabIndex = 11;
            this.label16.Text = "등록일 :";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(572, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 222);
            this.panel3.TabIndex = 12;
            // 
            // bookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 601);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "bookManagement";
            this.Text = "admin";
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox5;
    }
}

