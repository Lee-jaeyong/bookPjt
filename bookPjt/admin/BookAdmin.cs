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
    public partial class BookAdmin : Form
    {
        public int bookrowItem = 0;
        List<BookManageDTO> manageList;
        List<BookDTO> list;
        List<RentalChkDTO> rentalChkList;
        List<UserDTO> userList;
        BookDAO bookDAO = BookDAO.getInstance();
        BookManageDAO bookManageDAO = BookManageDAO.getInstance();
        UserDAO userDAO = UserDAO.getInstance();
        BookRentalChkDAO bookRentalChkDAO = BookRentalChkDAO.getInstance();

        public void selectUserList(string type, string search, bool overdueChk)
        {
            userListTable.Rows.Clear();
            userList = userDAO.getUserList(type, search, overdueChk);
            foreach (UserDTO user in userList)
                userListTable.Rows.Add(user.C_identy, user.C_name, user.C_birth, user.C_phone, user.C_rank, user.C_idx);
        }

        private void selectRentalChkList()
        {

            rentalChkTable.Rows.Clear();
            rentalChkList = bookRentalChkDAO.getRentalChkList();
            foreach (RentalChkDTO item in rentalChkList)
            {
                rentalChkTable.Rows.Add(item.B_idx, item.C_idx, item.BookImg, item.BookTitle, item.RentalUser, item.RentalChkDate);
            }
        }

        public void selectManageList(string search)
        {

            rentalTable.Rows.Clear();
            manageList = bookManageDAO.getManageList(search);
            foreach (BookManageDTO bookManage in manageList)
            {
                string delinquent = "미 연체";
                string status = "미 반납";
                if (Convert.ToDateTime(bookManage.Bm_returnDate) < Convert.ToDateTime(DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString()))
                    delinquent = "연체";
                if (bookManage.Status == 1)
                    status = "반납";
                rentalTable.Rows.Add(bookManage.Bm_b_idx, bookManage.C_idx, bookManage.B_name, bookManage.C_name, bookManage.Bm_takeDate, bookManage.Bm_returnDate, bookManage.Bm_extend, delinquent, bookManage.Bm_idx, status);
            }
        }

        public void selectList()
        {
            table.Rows.Clear();
            list = bookDAO.selectList(categoryList.Text, searchBook.Text, false);
            foreach (BookDTO book in list)
            {
                table.Rows.Add(book.B_idx, book.B_name, book.B_author, book.B_puBlisher, book.B_category, book.B_stock, book.B_guest);
            }
            BookDAO.dbStatus = 0;
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

        public BookAdmin()
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
            ComboRentalStatus.SelectedIndex = 0;
            selectManageList("");
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
                    selectPublisherList();
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
            selectUserList("", "", false);
            comboUserSelectType.SelectedIndex = 0;
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
                if (rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[9].Value.ToString() == "반납")
                    rentalOkImg.Visible = true;
                else
                    rentalOkImg.Visible = false;

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

        private void button6_Click_1(object sender, EventArgs e)
        {
            TabControll.SelectedIndex = 5;
            selectRentalChkList();
        }

        private void rentalChkTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Bitmap sourceImage = new Bitmap((Environment.CurrentDirectory.ToString().Substring(0, Environment.CurrentDirectory.ToString().LastIndexOf("\\bin"))) + rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[1].Value.ToString().Replace("\\source\\repos\\bookPjt\\bookPjt", ""));
                sourceImage = UtilClass.imgResize(sourceImage, 346, 263);
                rentalChkImg.Image = sourceImage;
                rentalChkBname.Text = rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[2].Value.ToString();
                rentalChkCname.Text = rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[3].Value.ToString();
                rentalChkDate.Text = rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[4].Value.ToString();
            }
            catch (Exception a)
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (bookRentalChkDAO.insertRental(Convert.ToInt32(rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[0].Value), Convert.ToInt32(rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[1].Value)))
                    MessageBox.Show("대여 처리 완료");
                else
                    MessageBox.Show("대여 처리 실패");
            }
            catch (Exception a)
            {
                MessageBox.Show("처리할 데이터를 선택해주세요");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (bookRentalChkDAO.deleteRentalChk(Convert.ToInt32(rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[0].Value), Convert.ToInt32(rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[1].Value)))
                    MessageBox.Show("삭제 완료");
                else
                    MessageBox.Show("삭제 실패");
            }
            catch (Exception a)
            {
                MessageBox.Show("처리할 데이터를 선택해주세요");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[6].Value) < 3)
            {
                if (bookManageDAO.extendRental(Convert.ToInt32(rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[8].Value)))
                {
                    MessageBox.Show("연장 완료");
                    selectManageList("");
                }
                else
                    MessageBox.Show("연장 실패");
            }
            else
                MessageBox.Show("연장 횟수 초과");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[9].Value.ToString() == "반납")
            {
                MessageBox.Show("이미 반납한 도서입니다");
                return;
            }
            if (rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[7].Value.ToString() == "연체")
            {
                TimeSpan timeSpan = Convert.ToDateTime(DateTime.Now.ToString().Substring(0, 10)) - Convert.ToDateTime(rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[5].Value.ToString());
                bookManageDAO.addReturnOverdue(timeSpan.Days, Convert.ToInt32(rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[8].Value));
            }
            if (bookManageDAO.returnBook(Convert.ToInt32(rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[8].Value)))
            {
                MessageBox.Show("반납 완료");
                selectManageList("");
            }
            else
                MessageBox.Show("반납 실패");
        }

        public void comborentalStatusModul(int status, string output)
        {
            rentalTable.Rows.Clear();
            foreach (BookManageDTO bookManage in manageList)
            {
                string delinquent = "미 연체";
                if (Convert.ToDateTime(bookManage.Bm_returnDate) < Convert.ToDateTime(DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString()))
                {
                    delinquent = "연체";
                    if (output == "연체")
                        rentalTable.Rows.Add(bookManage.Bm_b_idx, bookManage.C_idx, bookManage.B_name, bookManage.C_name, bookManage.Bm_takeDate, bookManage.Bm_returnDate, bookManage.Bm_extend, delinquent, bookManage.Bm_idx, "미 반납");
                }
                if (output != "연체" && bookManage.Status == status)
                    rentalTable.Rows.Add(bookManage.Bm_b_idx, bookManage.C_idx, bookManage.B_name, bookManage.C_name, bookManage.Bm_takeDate, bookManage.Bm_returnDate, bookManage.Bm_extend, delinquent, bookManage.Bm_idx, output);
            }
            if (status == 0)
            {
                btnExtend.Visible = true;
                btnReturn.Visible = true;
            }
            else
            {
                btnExtend.Visible = false;
                btnReturn.Visible = false;
            }
        }

        private void ComboRentalStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboRentalStatus.SelectedIndex == 0)
            {
                btnExtend.Visible = true;
                btnReturn.Visible = true;
                selectManageList("");
                return;
            }
            else if (ComboRentalStatus.SelectedIndex == 1)
            {
                comborentalStatusModul(0, "미 반납");
            }
            else if (ComboRentalStatus.SelectedIndex == 2)
            {
                comborentalStatusModul(1, "반납");
            }
            else if (ComboRentalStatus.SelectedIndex == 3)
            {
                comborentalStatusModul(0, "연체");
            }
        }

        private void btnSelectRentalUser_Click(object sender, EventArgs e)
        {
            selectManageList(txtSearchRentalUser.Text.Trim());
        }

        private void txtSearchRentalUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                selectManageList(txtSearchRentalUser.Text.Trim());
                btnSelectRentalUser.Focus();
            }
        }

        public void serachUser()
        {
            string type = "c_identy";
            if (comboUserSelectType.SelectedIndex == 1)
                type = "c_name";
            selectUserList(type, txtUserSelect.Text.Trim(), false);
        }

        private void btnSelectUser_Click(object sender, EventArgs e)
        {
            serachUser();
        }

        private void txtUserSelect_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSelectUser.Focus();
                serachUser();
            }
        }

        private bool changeRentalOverdue = true;
        private void rentalOverdue_CheckedChanged(object sender, EventArgs e)
        {
            if (changeRentalOverdue)
            {
                selectUserList("", "", true);
                changeRentalOverdue = false;
                btnOverdueRelease.Visible = true;
            }
            else
            {
                selectUserList("", "", false);
                changeRentalOverdue = true;
                btnOverdueRelease.Visible = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                int c_idx = Convert.ToInt32(userListTable.Rows[userListTable.CurrentRow.Index].Cells[5].Value);
                if (c_idx != 0)
                {
                    if (MessageBox.Show("연체를 강제 해제하시겠습니까?", "연체 관리", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (bookManageDAO.overdueRelease(c_idx))
                            MessageBox.Show("연체 해제 완료");
                        else
                            MessageBox.Show("연체 해제 실패");
                    }
                }
                else
                    MessageBox.Show("선택해주세요");
            }
            catch (Exception a)
            {
                MessageBox.Show("선택해주세요");
            }
        }

        private void btnRankUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UserRankUpdate userRankUpdate = new UserRankUpdate(this, userListTable.Rows[userListTable.CurrentRow.Index].Cells[4].Value.ToString(), Convert.ToInt32(userListTable.Rows[userListTable.CurrentRow.Index].Cells[5].Value));
                userRankUpdate.Show();
            }catch(Exception a)
            {
                MessageBox.Show("선택해주세요");
            }
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateUser updateUser = new UpdateUser(this, userListTable.Rows[userListTable.CurrentRow.Index].Cells[0].Value.ToString()
                    , userListTable.Rows[userListTable.CurrentRow.Index].Cells[1].Value.ToString(),
                    userListTable.Rows[userListTable.CurrentRow.Index].Cells[3].Value.ToString(),
                    userListTable.Rows[userListTable.CurrentRow.Index].Cells[2].Value.ToString(),
                    Convert.ToInt32(userListTable.Rows[userListTable.CurrentRow.Index].Cells[5].Value));
                updateUser.Show();
            }
            catch (Exception a)
            {
                MessageBox.Show("선택해주세요");
            }
        }

        public void selectPublisherList()
        {
            publisherTable.Rows.Clear();
            List<string> list = bookDAO.getPublisherList();
            foreach (string publisher in list)
                publisherTable.Rows.Add(publisher);
        }

        private void btnPublisherUpdate_Click(object sender, EventArgs e)
        {
            UpdatePublisher updatePublisher = new UpdatePublisher(this,publisherTable.Rows[publisherTable.CurrentRow.Index].Cells[0].Value.ToString());
            updatePublisher.Show();
        }
    }
}
