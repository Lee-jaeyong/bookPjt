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
            if (txtNoticeTitle.Text.Trim() == "" || txtNoticeContent.Text.Trim() == "")
                MessageBox.Show("비어있는 항목이 존재합니다.");
            else
            if (MessageBox.Show("공지사항을 정말 등록하시겠습니까?", "등록", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            if (MessageBox.Show("취소를 누르시면 입력하신 내용이 모두 초기화 됩니다.\r계속 하시겠습니까?", "취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Dispose();
        }
    }
}
