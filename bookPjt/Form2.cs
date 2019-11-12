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
        public Form2()
        {
            InitializeComponent();
            book = bookDAO.selectBook(bookManagement.bookrowItem);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bookName.Text = book.B_name;
            bookImage.Image = Image.FromFile(Environment.CurrentDirectory.ToString().Replace("\\source\\repos\\bookPjt\\bookPjt\\bin\\Debug", "") + book.B_img);
            bookStock.Text = book.B_stock.ToString();
            bookName.Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (bookDAO.updateBook(bookManagement.bookrowItem, int.Parse(bookStock.Text)))
                MessageBox.Show("재고 수정 완료");
            else
                MessageBox.Show("재고 수정 실패");
            Hide();
        }
    }
}
