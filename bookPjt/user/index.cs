using System;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using bookPjt;
using System.Linq;
using bookPjt.util;
using System.Drawing;
using bookPjt.DAO;

namespace BookManagement
{
    public partial class index : Form
    {
        BookDAO bookDAO = BookDAO.getInstance();
        BookRentalChkDAO bookRentalChkDAO = BookRentalChkDAO.getInstance();

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
            getBookList("", "");
            searchSelect.SelectedIndex = 0;
        }

        private void index_Load(object sender, EventArgs e)
        {
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
                    if (bookRentalChkDAO.insertRentalChk(id, Convert.ToInt32(bookListTable.Rows[bookListTable.CurrentRow.Index].Cells[0].Value)))
                        MessageBox.Show("대출 신청 완료");
                    else
                        MessageBox.Show("대출 신청 실패");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("도서를 클릭해주세요");
            }
        }
    }
}
