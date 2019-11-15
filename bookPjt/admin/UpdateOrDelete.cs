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
        public Form2(BookAdmin bookManage, int bookrowItem)
        {
            InitializeComponent();
            this.bookManage = bookManage;
            this.bookrowItem = bookrowItem;
            book = bookDAO.selectBook(bookrowItem);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bookName.Text = book.B_name;

            Bitmap img = new Bitmap(Environment.CurrentDirectory.ToString().Replace("\\source\\repos\\bookPjt\\bookPjt\\bin\\Debug", "") + book.B_img);
            img = UtilClass.imgResize(img, 480, 348);
            bookImage.Image = img;
            //bookImage.Image = Image.FromFile((Environment.CurrentDirectory.ToString().Substring(0, Environment.CurrentDirectory.ToString().LastIndexOf("\\bin"))) + book.B_img.Replace("\\source\\repos\\bookPjt\\bookPjt", ""));
            txtSummery.Text = book.B_summary;
            bookName.Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (bookDAO.deleteBook(bookrowItem))
                MessageBox.Show("상품 삭제 완료");
            else
                MessageBox.Show("상품 삭제 실패");
            BookDAO.dbStatus = 1;
            bookManage.selectList();
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (bookDAO.updateBook(bookrowItem, bookName.Text, txtSummery.Text))
                MessageBox.Show("상품 수정 완료");
            else
                MessageBox.Show("상품 수정 실패");
            BookDAO.dbStatus = 1;
            bookManage.selectList();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
