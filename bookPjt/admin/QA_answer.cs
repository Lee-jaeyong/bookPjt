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
    public partial class QA_answer : Form
    {
        UserQADAO userQADAO = UserQADAO.getInstance();
        BookAdmin bookAdmin;
        int idx;

        public QA_answer(BookAdmin bookAdmin, int idx)
        {
            InitializeComponent();
            this.bookAdmin = bookAdmin;
            this.idx = idx;
        }

        private void btnQAanswer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("답변 등록시 수정할 수 없습니다.\r정말 답변을 등록하시겠습니까?", "답변 등록", MessageBoxButtons.YesNo) == DialogResult.Yes)
                if (userQADAO.answerQA(txtQATitle.Text, txtQAcontent.Text, idx))
                {
                    MessageBox.Show("답변 완료");
                    bookAdmin.getQAlist();
                    Dispose();
                }
                else
                    MessageBox.Show("답변 실패");
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("취소하시겠습니까?", "답변 취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Dispose();
        }
    }
}
