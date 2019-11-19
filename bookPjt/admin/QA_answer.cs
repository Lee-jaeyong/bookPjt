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
            if(userQADAO.answerQA(txtQATitle.Text,txtQAcontent.Text,idx))
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
            Dispose();
        }
    }
}
