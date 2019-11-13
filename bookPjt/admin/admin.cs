using BookManagement;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using bookPjt.util;
using bookPjt.admin;
using bookPjt.DAO;
using bookPjt.DTO;

namespace bookPjt
{
    public partial class bookManagement : Form
    {
        public int bookrowItem = 0;
        List<BookManageDTO> manageList;
        List<BookDTO> list;
        BookDAO bookDAO = BookDAO.getInstance();
        BookManageDAO bookManageDAO = BookManageDAO.getInstance();
        UserDAO userDAO = UserDAO.getInstance();

        public void selectManageList()
        {
            if (BookManageDAO.status == 1)
            {
                rentalTable.Rows.Clear();
                manageList = bookManageDAO.getManageList();
                foreach (BookManageDTO bookManage in manageList)
                {
                    string delinquent = "미 연체";
                    if (Convert.ToDateTime(bookManage.Bm_returnDate) < DateTime.Now)
                        delinquent = "연체";
                    rentalTable.Rows.Add(bookManage.Bm_b_idx, bookManage.C_idx, bookManage.B_name, bookManage.C_name, bookManage.Bm_takeDate, bookManage.Bm_returnDate, bookManage.Bm_extend, delinquent);
                }
                BookManageDAO.status = 0;
            }
        }

        public void selectList()
        {
            if (BookDAO.dbStatus == 1)
            {
                table.Rows.Clear();
                list = bookDAO.selectList(categoryList.Text, searchBook.Text, false);
                foreach (BookDTO book in list)
                {
                    table.Rows.Add(book.B_idx, book.B_name, book.B_author, book.B_puBlisher, book.B_category, book.B_stock, book.B_guest);
                }
                BookDAO.dbStatus = 0;
            }
        }

        private void selectCategoryList()
        {
            categoryList.Items.Clear();
            List<string> list = bookDAO.getCategoryList();
            categoryList.Items.Add("도서 분류");
            categoryList.SelectedIndex = 0;
            foreach (string listItem in list)
                categoryList.Items.Add(listItem);
        }

        public bookManagement()
        {
            InitializeComponent();
            selectList();
            selectCategoryList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TabControll.SelectedIndex = 1;
            publisher.Items.Clear();
            category.Items.Clear();
            List<string> list = bookDAO.getCategoryList();
            foreach (string categoryItem in list)
            {
                category.Items.Add(categoryItem);
            }
            list = bookDAO.getPublisherList();
            foreach (string publisherItem in list)
            {
                publisher.Items.Add(publisherItem);
            }
            publisher.SelectedIndex = 0;
            category.SelectedIndex = 0;
            bookGuest.SelectedIndex = 0;
            bookImage.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TabControll.SelectedIndex = 2;
            categoryTable.Rows.Clear();
            publisherTable.Rows.Clear();
            List<string> list = bookDAO.getCategoryList();
            foreach (string category in list)
                categoryTable.Rows.Add(category);

            list = bookDAO.getPublisherList();
            foreach (string publisher in list)
                publisherTable.Rows.Add(publisher);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TabControll.SelectedIndex = 3;
            selectManageList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TabControll.SelectedIndex = 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TabControll.SelectedIndex = 0;
            selectList();
            selectCategoryList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.ShowDialog();
            if (openFileDlg.FileName.Length > 0)
            {
                foreach (string filename in openFileDlg.FileNames)
                {
                    bookImg.Text = filename;
                    Bitmap img = new Bitmap(bookImg.Text);
                    img = UtilClass.imgResize(img, 420, 245);
                    bookImage.Image = img;
                }
            }
        }

        private void clearText()
        {
            bookName.Text = "";
            bookAuthor.Text = "";
            bookContent.Text = "";
            bookImg.Text = "";
            bookStock.Text = "";
            publisher.SelectedIndex = 0;
            bookGuest.SelectedIndex = 0;
            category.SelectedIndex = 0;
            bookImage.Image = null;
            bookName.Focus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(bookStock.Text);
            }
            catch (Exception a)
            {
                MessageBox.Show("수량을 다시 입력해주세요.");
                bookStock.Focus();
                return;
            }
            if (bookName.Text == "")
            {
                MessageBox.Show("도서 명을 입력해주세요.");
                bookName.Focus();
            }
            else if (bookAuthor.Text == "")
            {
                MessageBox.Show("저자를 입력해주세요.");
                bookAuthor.Focus();
            }
            else if (bookStock.Text == "")
            {
                MessageBox.Show("수량을 입력해주세요.");
                bookStock.Focus();
            }
            else if (publisher.Text == "")
            {
                MessageBox.Show("출판사를 선택해주세요.");
                publisher.Focus();
            }
            else if (category.Text == "")
            {
                MessageBox.Show("카테고리를 선택해주세요.");
                category.Focus();
            }
            else if (bookGuest.Text == "")
            {
                MessageBox.Show("연령 제한을 선택해주세요.");
                bookGuest.Focus();
            }
            else if (bookContent.Text == "")
            {
                MessageBox.Show("줄거리를 입력해주세요.");
                bookContent.Focus();
            }
            else if (bookImg.Text == "")
            {
                MessageBox.Show("이미지를 선택해주세요.");
                btnAddImg.Focus();
            }
            else
            {
                string realPath = "\\\\source\\\\repos\\\\bookPjt\\\\bookPjt\\\\Resources\\\\BookImg";
                string imgPath = bookImg.Text.ToString().Replace("\\", "\\\\");
                string fileName = imgPath.Substring(imgPath.LastIndexOf("\\\\"));
                string copyPath = Environment.CurrentDirectory.ToString().Replace("\\bin\\Debug", "\\Resources\\BookImg") + fileName;
                try
                {
                    BookDTO bookDTO = new BookDTO(bookName.Text, bookAuthor.Text, publisher.Text, category.Text, bookContent.Text, (realPath + fileName), int.Parse(bookStock.Text), bookGuest.Text);
                    bookDAO.insertBook(bookDTO);
                }
                catch (Exception a)
                {
                    MessageBox.Show("도서 추가 중 문제가 발생했습니다.");
                }
                try
                {
                    File.Copy(@imgPath, @copyPath);
                }
                catch (Exception a)
                {

                }
                finally
                {
                    MessageBox.Show("도서 등록 완료");
                    clearText();
                    BookDAO.dbStatus = 1;
                    selectList();
                    TabControll.SelectedIndex = 0;
                }
            }
        }

        public void categoryListShow()
        {
            categoryTable.Rows.Clear();
            List<string> list = bookDAO.getCategoryList();
            foreach (string category in list)
                categoryTable.Rows.Add(category);
        }

        private void categoryAddBtn_Click(object sender, EventArgs e)
        {
            if (AddcategoryName.Text != "")
            {
                if (bookDAO.insertCategory(AddcategoryName.Text))
                {
                    MessageBox.Show("카테고리 추가 완료");
                    AddcategoryName.Text = "";
                    categoryListShow();
                }
                else
                    MessageBox.Show("카테고리 추가 실패");
            }
            else
            {
                MessageBox.Show("추가할 카테고리를 입력해주세요.");
                AddcategoryName.Focus();
            }
        }

        private void publisherAddBtn_Click(object sender, EventArgs e)
        {
            if (AddPublisherName.Text != "")
            {
                if (bookDAO.insertPublisher(AddPublisherName.Text))
                {
                    MessageBox.Show("출판사 추가 완료");
                    AddPublisherName.Text = "";
                    publisherTable.Rows.Clear();
                    List<string> list = bookDAO.getPublisherList();
                    foreach (string publisher in list)
                        publisherTable.Rows.Add(publisher);
                }
                else
                    MessageBox.Show("출판사 추가 실패");
            }
            else
            {
                MessageBox.Show("추가할 출판사를 입력해주세요.");
                AddPublisherName.Focus();
            }
        }

        private void bookUpdateAndDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bookrowItem = int.Parse(table.Rows[table.CurrentRow.Index].Cells[0].Value.ToString());
                Form2 form = new Form2(this, bookrowItem);
                form.Show();
            }
            catch (Exception a)
            {
                bookUpdateAndDelete.Enabled = false;
            }
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bookUpdateAndDelete.Enabled = true;
                BookDTO bookDTO = bookDAO.selectBook(int.Parse(table.Rows[table.CurrentRow.Index].Cells[0].Value.ToString()));
                Bitmap sourceImage = new Bitmap((Environment.CurrentDirectory.ToString().Substring(0, Environment.CurrentDirectory.ToString().LastIndexOf("\\bin"))) + bookDTO.B_img.Replace("\\source\\repos\\bookPjt\\bookPjt", ""));
                sourceImage = UtilClass.imgResize(sourceImage, 337, 164);
                subBookImg.Image = sourceImage;

                txtTitle.Text = bookDTO.B_name;
                txtAuthor.Text = bookDTO.B_author;
                txtPublisher.Text = bookDTO.B_puBlisher;
                txtDate.Text = bookDTO.B_date;
                txtCategory.Text = bookDTO.B_category;
                txtStatus.Text = bookDTO.B_status;
            }
            catch (Exception a)
            {

            }
        }

        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookDAO.dbStatus = 1;
            selectList();
        }

        private void searchBook_KeyUp(object sender, KeyEventArgs e)
        {
            BookDAO.dbStatus = 1;
            categoryList.SelectedIndex = 0;
            selectList();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            BookDAO.dbStatus = 1;
            MessageBox.Show("로그아웃 완료");
            loginForm login = new loginForm();
            login.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TabControll.SelectedIndex = 4;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            table.Rows.Clear();
            foreach (BookDTO book in list)
            {
                if (book.B_status == "대출 가능")
                {
                    table.Rows.Add(book.B_idx, book.B_name, book.B_author, book.B_puBlisher, book.B_category, book.B_stock, book.B_guest);
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            table.Rows.Clear();
            foreach (BookDTO book in list)
            {
                if (book.B_status == "대출 불가")
                {
                    table.Rows.Add(book.B_idx, book.B_name, book.B_author, book.B_puBlisher, book.B_category, book.B_stock, book.B_guest);
                }
            }
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            string updateCategoryStr = categoryTable.Rows[categoryTable.CurrentRow.Index].Cells[0].Value.ToString();
            updateCategoryForm updateCategory = new updateCategoryForm(this, updateCategoryStr);
            updateCategory.Show();
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {

        }

        private void selectRentalBook(int b_idx)
        {
            BookDTO bookDTO = bookDAO.selectBook(b_idx);
            txtBookName.Text = bookDTO.B_name;
            txtBookAuthor.Text = bookDTO.B_author;
            txtBookPublisher.Text = bookDTO.B_puBlisher;
            txtBookCategory.Text = bookDTO.B_category;
            Bitmap sourceImage = new Bitmap((Environment.CurrentDirectory.ToString().Substring(0, Environment.CurrentDirectory.ToString().LastIndexOf("\\bin"))) + bookDTO.B_img.Replace("\\source\\repos\\bookPjt\\bookPjt", ""));
            sourceImage = UtilClass.imgResize(sourceImage, 369, 147);
            subImg.Image = sourceImage;
        }
        private void selectRentalCustomer(int c_idx)
        {
            UserDTO userDTO = userDAO.selectUser(c_idx);
            txtCustomerName.Text = userDTO.C_identy;
            txtCustomerPhone.Text = userDTO.C_phone;
            txtCustomerBirth.Text = userDTO.C_birth;
            txtBookManage.Text = userDTO.TotalManageCount.ToString();
            txtCustomerExtend.Text = rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[6].Value.ToString();
        }

        private void rentalTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectRentalBook(int.Parse(rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[0].Value.ToString()));
                selectRentalCustomer(int.Parse(rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[1].Value.ToString()));
                if (rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[7].Value.ToString() == "연체")
                    exclamation.Visible = true;
                else
                    exclamation.Visible = false;
            }
            catch (Exception a)
            {

            }
        }
    }
}
