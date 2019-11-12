using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookPjt
{
    public partial class Form2 : Form
    {
        BookDAO bookDAO = BookDAO.getInstance();
        BookDTO book;
        bookManagement bookManage;
        int bookrowItem;
        public Form2(bookManagement bookManage,int bookrowItem)
        {
            InitializeComponent();
            this.bookManage = bookManage;
            this.bookrowItem = bookrowItem;
            book = bookDAO.selectBook(bookrowItem);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bookName.Text = book.B_name;
            bookImage.Image = Image.FromFile(Environment.CurrentDirectory.ToString().Replace("\\source\\repos\\bookPjt\\bookPjt\\bin\\Debug", "") + book.B_img);
            //bookImage.Image = Image.FromFile((Environment.CurrentDirectory.ToString().Substring(0, Environment.CurrentDirectory.ToString().LastIndexOf("\\bin"))) + book.B_img.Replace("\\source\\repos\\bookPjt\\bookPjt", ""));
            bookStock.Text = book.B_stock.ToString();
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
            if (bookDAO.updateBook(bookrowItem, int.Parse(bookStock.Text)))
                MessageBox.Show("재고 수정 완료");
            else
                MessageBox.Show("재고 수정 실패");
            BookDAO.dbStatus = 1;
            bookManage.selectList();
            Hide();
        }
    }
}
