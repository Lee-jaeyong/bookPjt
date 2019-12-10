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
using System.Text.RegularExpressions;

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
        NoticeDAO noticeDAO = NoticeDAO.getInstance();
        UserQADAO userQADAO = UserQADAO.getInstance();
        BookReservationDAO bookReservationDAO = BookReservationDAO.getInstance();

        private string userRank;
        private int qaNumber;
        private int noticeNumber;
        private int age;

        public void selectUserList(string type, string search, bool overdueChk)
        {
            userListTable.Rows.Clear();
            userList = userDAO.getUserList(type, search, overdueChk);
            foreach (UserDTO user in userList)
                userListTable.Rows.Add(user.C_identy, user.C_name, user.C_birth, user.C_phone, user.C_rank, user.C_idx, user.Email, user.Address);
        }

        private void selectRentalChkList()
        {

            rentalChkTable.Rows.Clear();
            rentalChkList = bookRentalChkDAO.getRentalChkList();
            foreach (RentalChkDTO item in rentalChkList)
            {
                rentalChkTable.Rows.Add(item.B_idx, item.C_id, item.BookImg, returnReplace(item.BookTitle), item.RentalUser, item.RentalChkDate);
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
                rentalTable.Rows.Add(bookManage.Bm_b_idx, bookManage.C_idx, returnReplace(bookManage.B_name), returnReplace(bookManage.C_name), bookManage.Bm_takeDate, bookManage.Bm_returnDate, bookManage.Bm_extend, delinquent, bookManage.Bm_idx, status);
            }
        }

        public void selectList()
        {
            table.Rows.Clear();
            list = bookDAO.selectList(categoryList.Text, searchBook.Text, false);
            foreach (BookDTO book in list)
            {
                table.Rows.Add(book.B_idx, returnReplace(book.B_name), returnReplace(book.B_author), returnReplace(book.B_puBlisher), returnReplace(book.B_category), book.B_stock, returnReplace(book.B_guest));
            }
        }

        private string returnReplace(string str)
        {
            return str.Replace("\\singleQ\\", "'");
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

        public BookAdmin(string userRank, string rank)
        {
            InitializeComponent();
            this.userRank = userRank;
            this.age = age;
            if (userRank != "관리자")
            {
                btnCategory.Visible = false;
                btnCustomer.Visible = false;
                btnNotice.Visible = false;
            }
            this.Text = "admin (" + userRank + ")";
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
                category.Items.Add(returnReplace(categoryItem));
            }
            list = bookDAO.getPublisherList();
            foreach (string publisherItem in list)
            {
                publisher.Items.Add(returnReplace(publisherItem));
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
            try
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
            catch
            {
                MessageBox.Show("jpg 형식 이미지 파일만 업로드 가능합니다.");
                bookImg.Text = "";
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
            if (MessageBox.Show("초기화를 누를 시 지금까지 입력하신 데이터는 모두 소멸됩니다.\r정말 초기화 하시겠습니까?", "초기화", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            if (bookName.Text.Trim() == "")
            {
                MessageBox.Show("도서 명을 입력해주세요.");
                bookName.Focus();
            }
            else if (Regex.IsMatch(bookName.Text, @"[^a-zA-Z0-9가-힣]"))
            {
                MessageBox.Show("도서 명에 특수문자가 포함되어 있습니다.");
                bookName.Focus();
            }
            else if (bookAuthor.Text.Trim() == "")
            {
                MessageBox.Show("저자를 입력해주세요.");
                bookAuthor.Focus();
            }
            else if (Regex.IsMatch(bookAuthor.Text, @"[^a-zA-Z0-9가-힣]"))
            {
                MessageBox.Show("저자에 특수문자가 포함되어 있습니다.");
                bookAuthor.Focus();
            }
            else if (bookStock.Text.Trim() == "")
            {
                MessageBox.Show("수량을 입력해주세요.");
                bookStock.Focus();
            }
            else if (publisher.Text.Trim() == "")
            {
                MessageBox.Show("출판사를 선택해주세요.");
                publisher.Focus();
            }
            else if (category.Text.Trim() == "")
            {
                MessageBox.Show("카테고리를 선택해주세요.");
                category.Focus();
            }
            else if (bookGuest.Text.Trim() == "")
            {
                MessageBox.Show("연령 제한을 선택해주세요.");
                bookGuest.Focus();
            }
            else if (bookContent.Text.Trim() == "")
            {
                MessageBox.Show("줄거리를 입력해주세요.");
                bookContent.Focus();
            }
            else if (Regex.IsMatch(bookContent.Text, @"[^a-zA-Z0-9가-힣]"))
            {
                MessageBox.Show("줄거리에 특수문자가 포함되어 있습니다.");
                bookContent.Focus();
            }
            else if (bookImg.Text.Trim() == "")
            {
                MessageBox.Show("이미지를 선택해주세요.");
                btnAddImg.Focus();
            }else if(bookImg.Text.Substring(bookImg.Text.Length -3 ) != "jpg")
            {
                MessageBox.Show("이미지는 jpg 형식만 첨부 가능합니다.");
                btnAddImg.Focus();
            }else if(Regex.IsMatch(btnAddImg.Text, @"[^a-zA-Z0-9가-힣]"))
            {
                MessageBox.Show("이미지는 첨부시 특수문자를 제외해주시기 바랍니다.");
                btnAddImg.Focus();
            }
            else
            {
                if (MessageBox.Show("정말 도서를 등록하시겠습니까?", "도서 등록", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string realPath = "\\\\source\\\\repos\\\\bookPjt\\\\bookPjt\\\\Resources\\\\BookImg";
                    string imgPath = bookImg.Text.ToString().Replace("\\", "\\\\");
                    string fileName = imgPath.Substring(imgPath.LastIndexOf("\\\\"));
                    string copyPath = Environment.CurrentDirectory.ToString().Replace("\\bin\\Debug", "\\Resources\\BookImg") + fileName;
                    try
                    {
                        BookDTO bookDTO = new BookDTO(replaceAll(bookName.Text), replaceAll(bookAuthor.Text), replaceAll(publisher.Text), replaceAll(category.Text), replaceAll(bookContent.Text), (realPath + fileName), int.Parse(bookStock.Text), replaceAll(bookGuest.Text));
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
                        selectList();
                        TabControll.SelectedIndex = 0;
                    }
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
            if (AddcategoryName.Text.Trim() != "")
            {
                if (MessageBox.Show("정말 카테고리를 추가하시겠습니까?", "카테고리 추가", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    if (bookDAO.insertCategory(replaceAll(AddcategoryName.Text)))
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
            if (AddPublisherName.Text.Trim() != "")
            {
                if (MessageBox.Show("정말 출판사를 추가하시겠습니까?", "출판사 추가", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    if (bookDAO.insertPublisher(replaceAll(AddPublisherName.Text)))
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
                Form2 form = new Form2(this, bookrowItem, age);
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

                txtTitle.Text = returnReplace(bookDTO.B_name);
                txtAuthor.Text = returnReplace(bookDTO.B_author);
                txtPublisher.Text = returnReplace(bookDTO.B_puBlisher);
                txtDate.Text = returnReplace(bookDTO.B_date);
                txtCategory.Text = returnReplace(bookDTO.B_category);
                txtStatus.Text = returnReplace(bookDTO.B_status);
            }
            catch (Exception a)
            {
            }
        }

        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectList();
        }

        private void searchBook_KeyUp(object sender, KeyEventArgs e)
        {
            categoryList.SelectedIndex = 0;
            selectList();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 로그아웃 하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Hide();
                MessageBox.Show("로그아웃 완료");
                loginForm login = new loginForm();
                login.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TabControll.SelectedIndex = 4;
            selectUserList("", "", false);
            comboUserSelectType.SelectedIndex = 0;
            rentalOverdue.Checked = false;
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
            try
            {
                categoryTable.Rows[categoryTable.CurrentRow.Index].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("수정할 카테고리를 선택해주세요.");
                return;
            }
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
                selectRentalBook(int.Parse(rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[1].Value.ToString()));
                selectRentalCustomer(int.Parse(rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[0].Value.ToString()));
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
                Bitmap sourceImage = new Bitmap((Environment.CurrentDirectory.ToString().Substring(0, Environment.CurrentDirectory.ToString().LastIndexOf("\\bin"))) + rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[2].Value.ToString().Replace("\\source\\repos\\bookPjt\\bookPjt", ""));
                sourceImage = UtilClass.imgResize(sourceImage, 346, 263);
                rentalChkImg.Image = sourceImage;
                rentalChkBname.Text = returnReplace(rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[3].Value.ToString());
                rentalChkCname.Text = returnReplace(rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[4].Value.ToString());
                rentalChkDate.Text = returnReplace(rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[5].Value.ToString());
            }
            catch (Exception a)
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[0].Value.ToString() == "")
                    new Exception();
                Convert.ToInt32(rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[0].Value);
            }
            catch
            {
                MessageBox.Show("대여 처리할 항목을 선택해주세요.");
                return;
            }
            if (!bookRentalChkDAO.selectCheckReservation(Convert.ToInt32(rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[0].Value)))
            {
                if (MessageBox.Show("이미 예약되어 있는 도서입니다. 그래도 대출 승인하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bookRentalChkDAO.insertRental(Convert.ToInt32(rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[0].Value), rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[1].Value.ToString()))
                        MessageBox.Show("대여 처리 완료");
                    else
                        MessageBox.Show("대여 처리 실패");
                    selectRentalChkList();
                }
            }
            else
            {
                if (MessageBox.Show("대출 승인 하시겠습니까?", "확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bookRentalChkDAO.insertRental(Convert.ToInt32(rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[0].Value), rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[1].Value.ToString()))
                        MessageBox.Show("대여 처리 완료");
                    else
                        MessageBox.Show("대여 처리 실패");
                    selectRentalChkList();
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[0].Value);
            }
            catch
            {
                MessageBox.Show("처리할 데이터를 선택해주세요");
                return;
            }
            if (MessageBox.Show("정말 대출신청을 삭제하시겠습니까?", "대출 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bookRentalChkDAO.deleteRentalChk(Convert.ToInt32(rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[0].Value), rentalChkTable.Rows[rentalChkTable.CurrentRow.Index].Cells[1].Value.ToString()))
                    MessageBox.Show("삭제 완료");
                else
                    MessageBox.Show("삭제 실패");
                selectRentalChkList();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[9].Value.ToString() == "반납")
                {
                    MessageBox.Show("이미 반납된 도서입니다.");
                    return;
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("연장할 도서를 선택해주세요.");
                return;
            }
            if (Convert.ToInt32(rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[6].Value) < 3)
            {
                if (MessageBox.Show("정말 대출을 연장하시겠습니까?", "대출 연장", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    if (bookManageDAO.extendRental(Convert.ToInt32(rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[8].Value)))
                    {
                        MessageBox.Show("연장 완료");
                        ComboRentalStatus.SelectedIndex = 0;
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
            try
            {
                if (MessageBox.Show("정말 반납 처리하시겠습니까?", "도서 반납", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[9].Value.ToString() == "반납")
                    {
                        MessageBox.Show("이미 반납한 도서입니다");
                        return;
                    }
                    if (rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[7].Value.ToString() == "연체")
                    {
                        TimeSpan timeSpan = Convert.ToDateTime(DateTime.Now.ToString().Substring(0, 10)) - Convert.ToDateTime(rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[5].Value.ToString());
                        bookManageDAO.addReturnOverdue(timeSpan.Days, Convert.ToInt32(rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[8].Value), Convert.ToInt32(rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[0].Value));
                    }
                    if (bookManageDAO.returnBook(Convert.ToInt32(rentalTable.Rows[rentalTable.CurrentRow.Index].Cells[8].Value)))
                    {
                        MessageBox.Show("반납 완료");
                        ComboRentalStatus.SelectedIndex = 0;
                        selectManageList("");
                    }
                    else
                        MessageBox.Show("반납 실패");
                }
            }
            catch (Exception a)
            {

            }
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
                    if (output == "연체" && bookManage.Status == 0)
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
            rentalOverdue.Checked = false;
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
                btnShowPenalty.Visible = true;
            }
            else
            {
                selectUserList("", "", false);
                changeRentalOverdue = true;
                btnOverdueRelease.Visible = false;
                btnShowPenalty.Visible = false;
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
            }
            catch (Exception a)
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
            try
            {
                publisherTable.Rows[publisherTable.CurrentRow.Index].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("수정할 출판사를 선택해주세요.");
                return;
            }
            UpdatePublisher updatePublisher = new UpdatePublisher(this, publisherTable.Rows[publisherTable.CurrentRow.Index].Cells[0].Value.ToString());
            updatePublisher.Show();
        }

        public void showNoticeList()
        {
            List<NoticeDTO> list = noticeDAO.getNoticeList();
            noticeTable.Rows.Clear();
            foreach (NoticeDTO notice in list)
            {
                noticeTable.Rows.Add(notice.No_idx, returnReplace(notice.No_title), returnReplace(notice.No_content), notice.No_date, notice.No_hit);
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            TabControll.SelectedIndex = 6;
            showNoticeList();
            noticeNumber = -1;
            txtNoticeTitle.Text = "";
            txtNoticeContent.Text = "";
            btnUpdateNoticExcute.Visible = false;
            btnUpdateNoticeCencel.Visible = false;
            txtNoticeTitle.ReadOnly = true;
            txtNoticeContent.ReadOnly = true;
        }

        private void btnNoticeAdd_Click(object sender, EventArgs e)
        {
            AddNotice addNotice = new AddNotice(this);
            addNotice.Show();
        }

        private void noticeTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNoticeTitle.Text = returnReplace(noticeTable.Rows[noticeTable.CurrentRow.Index].Cells[1].Value.ToString());
                txtNoticeContent.Text = returnReplace(noticeTable.Rows[noticeTable.CurrentRow.Index].Cells[2].Value.ToString());
                noticeNumber = Convert.ToInt32(noticeTable.Rows[noticeTable.CurrentRow.Index].Cells[0].Value);
                txtNoticeTitle.ReadOnly = true;
                txtNoticeContent.ReadOnly = true;
                btnUpdateNoticExcute.Visible = false;
                btnUpdateNoticeCencel.Visible = false;
            }
            catch (Exception a)
            {
                txtNoticeTitle.ReadOnly = true;
                txtNoticeContent.ReadOnly = true;
                btnUpdateNoticExcute.Visible = false;
                btnUpdateNoticeCencel.Visible = false;
            }
        }

        private void btnNoticeUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNoticeTitle.Text.Trim() == "" || noticeTable.Rows[noticeTable.CurrentRow.Index].Cells[1].Value.ToString() == "")
                    MessageBox.Show("수정할 항목을 선택해주세요.");
                else
                {
                    txtNoticeTitle.ReadOnly = false;
                    txtNoticeContent.ReadOnly = false;
                    btnUpdateNoticExcute.Visible = true;
                    btnUpdateNoticeCencel.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("수정할 항목을 선택해주세요.");
                return;
            }
        }

        private void btnUpdateNoticeCencel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("취소를 누르시면 입력하신 내용이 모두 초기화 됩니다.\r계속 하시겠습니까?", "취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                txtNoticeTitle.Text = "";
                txtNoticeContent.Text = "";
                btnUpdateNoticExcute.Visible = false;
                btnUpdateNoticeCencel.Visible = false;
                txtNoticeTitle.ReadOnly = true;
                txtNoticeContent.ReadOnly = true;
            }
        }

        private void btnUpdateNoticExcute_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("공지사항 수정시 다시 복구할 수 없습니다. \r공지사항을 정말 수정하시겠습니까?", "수정", MessageBoxButtons.YesNo) == DialogResult.Yes)
                if (noticeDAO.updateNotice(replaceAll(txtNoticeTitle.Text), replaceAll(txtNoticeContent.Text), noticeNumber))
                {
                    MessageBox.Show("수정 완료");
                    showNoticeList();
                    btnUpdateNoticExcute.Visible = false;
                    btnUpdateNoticeCencel.Visible = false;
                    txtNoticeTitle.ReadOnly = true;
                    txtNoticeContent.ReadOnly = true;
                }
                else
                    MessageBox.Show("수정 실패");
        }

        private void btnNoticeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNoticeTitle.Text == "" || noticeTable.Rows[noticeTable.CurrentRow.Index].Cells[1].Value.ToString() == "")
                {
                    MessageBox.Show("삭제할 공지사항을 선택해주세요.");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("삭제할 공지사항을 선택해주세요.");
                return;
            }
            if (MessageBox.Show("공지사항 삭제시 다시 복구할 수 없습니다. \r공지사항을 정말 삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                if (noticeNumber != -1)
                    if (noticeDAO.deleteNotice(noticeNumber))
                    {
                        MessageBox.Show("삭제 완료");
                        showNoticeList();
                        txtNoticeTitle.ReadOnly = true;
                        txtNoticeContent.ReadOnly = true;
                        txtNoticeTitle.Text = "";
                        txtNoticeContent.Text = "";
                    }
                    else
                        MessageBox.Show("삭제 실패");
                else
                    MessageBox.Show("삭제할 항목을 선택해주세요");
        }

        public void getQAlist()
        {
            userQAtable.Rows.Clear();
            List<UserQADTO> list = userQADAO.getUserQAList("");
            foreach (UserQADTO userQA in list)
            {
                userQAtable.Rows.Add(userQA.Q_idx, userQA.Q_c_name, returnReplace(userQA.Q_title), returnReplace(userQA.Q_content), userQA.Q_date, userQA.Q_status);
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            TabControll.SelectedIndex = 7;
            getQAlist();
            qaNumber = -1;
        }

        private void userQAtable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtQAtitle.Text = userQAtable.Rows[userQAtable.CurrentRow.Index].Cells[2].Value.ToString();
                txtQAcust.Text = userQAtable.Rows[userQAtable.CurrentRow.Index].Cells[1].Value.ToString();
                txtQAcontent.Text = userQAtable.Rows[userQAtable.CurrentRow.Index].Cells[3].Value.ToString();
                qaNumber = Convert.ToInt32(userQAtable.Rows[userQAtable.CurrentRow.Index].Cells[0].Value);
                if (userQAtable.Rows[userQAtable.CurrentRow.Index].Cells[5].Value.ToString() == "답변 완료")
                    btnAnswer.Enabled = false;
                else
                    btnAnswer.Enabled = true;

            }
            catch (Exception a)
            {
                qaNumber = -1;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (qaNumber != -1)
            {
                QA_answer qA_Answer = new QA_answer(this, Convert.ToInt32(userQAtable.Rows[userQAtable.CurrentRow.Index].Cells[0].Value));
                qA_Answer.Show();
            }
            else
                MessageBox.Show("답변할 항목을 선택해주세요.");
        }

        private void BookAdmin_Load(object sender, EventArgs e)
        {

        }

        private string replaceAll(string str)
        {
            return str.Replace("'", "\\singleQ\\");
        }

        private void AddcategoryName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AddcategoryName.Text.Trim() != "")
                {
                    if (bookDAO.insertCategory(replaceAll(AddcategoryName.Text)))
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
        }

        private void AddPublisherName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (AddPublisherName.Text.Trim() != "")
                {
                    if (bookDAO.insertPublisher(replaceAll(AddPublisherName.Text)))
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
        }

        private void BookAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            TabControll.SelectedIndex = 8;
            List<BookReservationDTO> list = bookReservationDAO.selectReservation("");
            bookReservationTable.Rows.Clear();
            foreach (BookReservationDTO reservation in list)
            {
                bookReservationTable.Rows.Add(reservation.Rc_idx, reservation.B_idx, reservation.C_id, reservation.B_name, reservation.C_name, reservation.ReservationDate);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                bookReservationTable.Rows[bookReservationTable.CurrentRow.Index].Cells[0].Value.ToString();
            }
            catch (Exception a)
            {
                MessageBox.Show("대출 승인할 항목을 선택해주세요.");
                return;
            }
            if (MessageBox.Show("예약 대출을 승인하시겠습니까?", "대출 승인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bookRentalChkDAO.insertRental(Convert.ToInt32(bookReservationTable.Rows[bookReservationTable.CurrentRow.Index].Cells[1].Value.ToString()), bookReservationTable.Rows[bookReservationTable.CurrentRow.Index].Cells[2].Value.ToString()))
                {
                    bookReservationDAO.deleteReservation(bookReservationTable.Rows[bookReservationTable.CurrentRow.Index].Cells[0].Value.ToString());
                    MessageBox.Show("대출 승인 완료");
                    List<BookReservationDTO> list = bookReservationDAO.selectReservation("");
                    bookReservationTable.Rows.Clear();
                    foreach (BookReservationDTO reservation in list)
                    {
                        bookReservationTable.Rows.Add(reservation.Rc_idx, reservation.B_idx, reservation.C_id, reservation.B_name, reservation.C_name, reservation.ReservationDate);
                    }
                }
                else
                    MessageBox.Show("대출 승인 실패");
            }
        }

        private void button12_Click_2(object sender, EventArgs e)
        {
            try
            {
                bookReservationTable.Rows[bookReservationTable.CurrentRow.Index].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("삭제할 항목을 선택해주세요.");
                return;
            }
            if (MessageBox.Show("정말 예약을 취소하시겠습니까?", "예약 취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bookReservationDAO.deleteReservation(bookReservationTable.Rows[bookReservationTable.CurrentRow.Index].Cells[0].Value.ToString()))
                {
                    MessageBox.Show("예약 취소 완료");
                    List<BookReservationDTO> list = bookReservationDAO.selectReservation("");
                    bookReservationTable.Rows.Clear();
                    foreach (BookReservationDTO reservation in list)
                    {
                        bookReservationTable.Rows.Add(reservation.Rc_idx, reservation.B_idx, reservation.C_id, reservation.B_name, reservation.C_name, reservation.ReservationDate);
                    }
                }
                else
                    MessageBox.Show("예약 취소 실패");
            }
        }

        private void btnShowPenalty_Click(object sender, EventArgs e)
        {
            try
            {
                userListTable.Rows[userListTable.CurrentRow.Index].Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("연체금 확인할 사용자를 선택해주세요.");
                return;
            }
            ShowPenalty showPenalty = new ShowPenalty(userListTable.Rows[userListTable.CurrentRow.Index].Cells[1].Value.ToString(), Convert.ToInt32(userListTable.Rows[userListTable.CurrentRow.Index].Cells[5].Value));
            showPenalty.Show();
        }
    }
}
