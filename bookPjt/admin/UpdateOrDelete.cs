using System;
using System.Drawing;
using System.Windows.Forms;
using bookPjt.util;

namespace bookPjt
{
    public partial class Form2 : Form
    {
        BookDAO bookDAO = BookDAO.getInstance();
        BookDTO book;
        BookAdmin bookManage;
        int bookrowItem;
        int age;
        public Form2(BookAdmin bookManage, int bookrowItem,int age)
        {
            InitializeComponent();
            this.bookManage = bookManage;
            this.age = age;
            this.bookrowItem = bookrowItem;
            book = bookDAO.selectBook(bookrowItem);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bookName.Text = book.B_name;
            txtSummery.Text = book.B_summary;
            bookName.Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 도서를 삭제하시겠습니까?", "도서 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bookDAO.deleteBook(bookrowItem))
                    MessageBox.Show("도서 삭제 완료");
                else
                    MessageBox.Show("도서 삭제 실패");
                bookManage.selectList();
                Hide();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 도서를 수정하시겠습니까?", "도서 수정", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bookDAO.updateBook(bookrowItem, bookName.Text, txtSummery.Text))
                    MessageBox.Show("도서 수정 완료");
                else
                    MessageBox.Show("상품 수정 실패");
                bookManage.selectList();
                Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
