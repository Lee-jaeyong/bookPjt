using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bookPjt.DTO;

namespace bookPjt.admin
{
    public partial class UpdatePublisher : Form
    {
        BookAdmin bookAdmin;
        public UpdatePublisher(BookAdmin bookAdmin,string publisherName)
        {
            InitializeComponent();
            this.bookAdmin = bookAdmin;
            txtBefore.Text = publisherName;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            Dispose();
        }

        private void btnPublisherUpdateExecute_Click(object sender, EventArgs e)
        {
            BookDAO bookDAO = BookDAO.getInstance();
            if (bookDAO.updatePublisher(txtBefore.Text,txtAfter.Text))
            {
                MessageBox.Show("출판사 수정 성공");
                bookAdmin.selectPublisherList();
                Hide();
                Dispose();
            }
            else
                MessageBox.Show("출판사 수정 실패");
        }
    }
}