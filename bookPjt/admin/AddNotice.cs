using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bookPjt.DAO;

namespace bookPjt.admin
{
    public partial class AddNotice : Form
    {
        NoticeDAO noticeDAO = NoticeDAO.getInstance();
        BookAdmin bookAdmin;

        public AddNotice(BookAdmin bookAdmin)
        {
            InitializeComponent();
            this.bookAdmin = bookAdmin;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (noticeDAO.insertNotice(txtNoticeTitle.Text, txtNoticeContent.Text))
            {
                MessageBox.Show("공지사항 등록 완료");
                bookAdmin.showNoticeList();
                Dispose();
            }
            else
                MessageBox.Show("공지사항 등록 실패");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
