using System;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using bookPjt;
using System.Linq;
using bookPjt.util;
using System.Drawing;
using bookPjt.DAO;
using bookPjt.DTO;

namespace BookManagement
{
    public partial class index : Form
    {
        BookDAO bookDAO = BookDAO.getInstance();
        UserDAO userDAO = UserDAO.getInstance();
        BookManageDAO bookManageDAO = BookManageDAO.getInstance();
        BookRentalChkDAO bookRentalChkDAO = BookRentalChkDAO.getInstance();
        NoticeDAO noticeDAO = NoticeDAO.getInstance();
        UserQADAO userQADAO = UserQADAO.getInstance();
        UserDTO userDTO;

        private string id;

        List<BookDTO> bookList;
        private void getBookList(string type, string search)
        {
            if (type == "책제목")
                type = "b_name";
            else if (type == "저자")
                type = "b_author";
            else if (type == "출판사")
                type = "p_n_name";
            else if (type == "분류")
                type = "c_n_name";
            bookListTable.Rows.Clear();
            bookList = bookDAO.getBookList(type, search.Trim());
            foreach (BookDTO book in bookList)
                bookListTable.Rows.Add(book.B_idx, book.B_name, book.B_status, book.B_author, book.B_puBlisher, book.B_category, book.B_img, book.B_summary);
        }

        private void infoOut()
        {
            userDTO = userDAO.getUserInfo(id);
            txtUserId.Text = userDTO.C_identy;
            txtUserName.Text = userDTO.C_name;
            txtUserBirth.Text = userDTO.C_birth;
            string[] phone = userDTO.C_phone.Split('-');
            txtUserPhone1.Text = phone[0];
            txtUserPhone2.Text = phone[1];
            txtUserPhone3.Text = phone[2];
        }

        public index(string id)
        {
            this.id = id;
            InitializeComponent();
        }
        private void outBtn_Click(object sender, EventArgs e)
        {
            loginForm frm = new loginForm();
            MessageBox.Show("로그아웃 완료");
            id = "";
            frm.Show();
            Hide();
        }
        private void bookBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            getBookList("", "");
            searchSelect.SelectedIndex = 0;
        }

        private void index_Load(object sender, EventArgs e)
        {
            OverDueImg.Visible = false;
            if (bookManageDAO.userChkOverDue(id))
            {
                OverDueChk.Text = "*연체된 도서가 존재합니다.";
                OverDueImg.Visible = true;
            }
            getBookList("", "");
            searchSelect.SelectedIndex = 0;
        }

        private void bookListTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtBookName.Text = bookListTable.Rows[bookListTable.CurrentRow.Index].Cells[1].Value.ToString();
                txtBookAuthor.Text = bookListTable.Rows[bookListTable.CurrentRow.Index].Cells[3].Value.ToString();
                txtBookPublisher.Text = bookListTable.Rows[bookListTable.CurrentRow.Index].Cells[4].Value.ToString();
                txtBookCategory.Text = bookListTable.Rows[bookListTable.CurrentRow.Index].Cells[5].Value.ToString();
                txtBookSummary.Text = bookListTable.Rows[bookListTable.CurrentRow.Index].Cells[7].Value.ToString();
                Bitmap sourceImage = new Bitmap((Environment.CurrentDirectory.ToString().Substring(0, Environment.CurrentDirectory.ToString().LastIndexOf("\\bin"))) + bookListTable.Rows[bookListTable.CurrentRow.Index].Cells[6].Value.ToString().Replace("\\source\\repos\\bookPjt\\bookPjt", ""));
                sourceImage = UtilClass.imgResize(sourceImage, 185, 261);
                bookImg.Image = sourceImage;
            }
            catch (Exception a)
            {

            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            getBookList(searchSelect.Text, searchBook.Text);
            searchBook.Text = "";
        }

        private void searchBook_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getBookList(searchSelect.Text, searchBook.Text);
                searchBook.Text = "";
            }
        }

        private void takeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("대출 신청 하시겠습니까?", "대출 신청", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bookRentalChkDAO.getChkRental(id, Convert.ToInt32(bookListTable.Rows[bookListTable.CurrentRow.Index].Cells[0].Value)))
                        if (bookRentalChkDAO.insertRentalChk(id, Convert.ToInt32(bookListTable.Rows[bookListTable.CurrentRow.Index].Cells[0].Value)))
                            MessageBox.Show("대출 신청 완료");
                        else
                            MessageBox.Show("대출 신청 실패");
                    else
                        MessageBox.Show("이미 신청한 도서입니다");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("도서를 클릭해주세요");
            }
        }

        private void meBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            infoOut();
        }

        private void btnUserUpdateExecute_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = false;
            txtUserBirth.Enabled = false;
            txtUserPhone1.Enabled = false;
            txtUserPhone2.Enabled = false;
            txtUserPhone3.Enabled = false;
            btnUserUpdate.Visible = true;
            btnUserUpdateExecute.Visible = false;
            btnUserUpdateCencel.Visible = false;

            UserDTO userUpdate = new UserDTO();
            userUpdate.C_identy = userDTO.C_identy;
            userUpdate.C_name = txtUserName.Text;
            userUpdate.C_birth = txtUserBirth.Text;
            string[] phone = new string[] { txtUserPhone1.Text, txtUserPhone2.Text, txtUserPhone3.Text };
            if (userDAO.updateUser(userUpdate, phone))
            {
                MessageBox.Show("수정 완료");
                infoOut();
            }
            else
                MessageBox.Show("수정 실패");
        }

        private void btnUserUpdateCencel_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = false;
            txtUserBirth.Enabled = false;
            txtUserPhone1.Enabled = false;
            txtUserPhone2.Enabled = false;
            txtUserPhone3.Enabled = false;
            btnUserUpdate.Visible = true;
            btnUserUpdateExecute.Visible = false;
            btnUserUpdateCencel.Visible = false;
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            if (txtChangePass.Text != txtChangePassChk.Text)
                MessageBox.Show("비밀번호가 일치하지 않습니다");
            else
            {
                if (userDAO.updatePassWord(txtChangePass.Text, id))
                    MessageBox.Show("비밀번호 변경 완료");
                else
                    MessageBox.Show("비밀번호 변경 실패");
            }
            txtChangePass.Text = "";
            txtChangePassChk.Text = "";
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = true;
            txtUserBirth.Enabled = true;
            txtUserPhone1.Enabled = true;
            txtUserPhone2.Enabled = true;
            txtUserPhone3.Enabled = true;
            btnUserUpdate.Visible = false;
            btnUserUpdateExecute.Visible = true;
            btnUserUpdateCencel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            rentalChkTable.Rows.Clear();
            List<RentalChkDTO> list = bookRentalChkDAO.getRentalList(id);
            foreach (RentalChkDTO item in list)
            {
                rentalChkTable.Rows.Add(item.BookTitle, item.RentalChkDate);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            ComboRental.SelectedIndex = 0;
            showRentalBookInfo();
        }

        private void ComboRental_SelectedIndexChanged(object sender, EventArgs e)
        {
            showRentalBookInfo();
        }

        private void showRentalBookInfo()
        {
            rentalBookInfoTable.Rows.Clear();
            List<BookManageDTO> list;
            if (ComboRental.Text == "대출 중")
                list = bookManageDAO.getUserManageList(id, 0, false);
            else if (ComboRental.Text == "반납 완료")
                list = bookManageDAO.getUserManageList(id, 1, false);
            else
                list = bookManageDAO.getUserManageList(id, 0, true);

            foreach (BookManageDTO item in list)
            {
                rentalBookInfoTable.Rows.Add(item.B_name, item.Bm_takeDate, item.Bm_returnDate, item.Bm_extend, item.Status);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
            noticeTable.Rows.Clear();
            List<NoticeDTO> list = noticeDAO.getNoticeList();
            foreach (NoticeDTO notice in list)
                noticeTable.Rows.Add(notice.No_date, notice.No_title, notice.No_content);

        }

        private void getUserQnA()
        {
            userQnAtable.Rows.Clear();
            List<UserQADTO> list = userQADAO.getUserQAList(id);
            foreach (UserQADTO userQ in list)
                userQnAtable.Rows.Add(userQ.Q_date, userQ.Q_title, userQ.Q_content, userQ.Q_status, userQ.Q_idx);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
            getUserQnA();
        }

        private void noticeTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNoticeTitle.Text = noticeTable.Rows[noticeTable.CurrentRow.Index].Cells[1].Value.ToString();
                txtNoticeContent.Text = noticeTable.Rows[noticeTable.CurrentRow.Index].Cells[2].Value.ToString();
            }
            catch (Exception a)
            {
            }
        }

        private void btnQadd_Click(object sender, EventArgs e)
        {
            if (userQADAO.insertUserQ(id, txtQtitle.Text, txtQcontent.Text))
            {
                MessageBox.Show("질문 등록 완료");
                txtQtitle.Text = "";
                txtQcontent.Text = "";
                getUserQnA();
            }
            else
                MessageBox.Show("질문 등록 실패");
        }

        private void userQnAtable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtQtitle.Text = userQnAtable.Rows[userQnAtable.CurrentRow.Index].Cells[1].Value.ToString();
            txtQcontent.Text = userQnAtable.Rows[userQnAtable.CurrentRow.Index].Cells[2].Value.ToString();
            txtQtitle.ReadOnly = true;
            txtQcontent.ReadOnly = true;

            if (userQnAtable.Rows[userQnAtable.CurrentRow.Index].Cells[3].Value.ToString() == "답변 완료")
            {
                AdminAnswerDTO adminAnswerDTO = userQADAO.getAnswerInfo(Convert.ToInt32(userQnAtable.Rows[userQnAtable.CurrentRow.Index].Cells[4].Value));
                txtAnsTitle.Text = adminAnswerDTO.Ans_title;
                txtAnsContent.Text = adminAnswerDTO.Ans_content;
            }
            else
            {
                txtAnsTitle.Text = "";
                txtAnsContent.Text = "";
            }
        }

    }
}
