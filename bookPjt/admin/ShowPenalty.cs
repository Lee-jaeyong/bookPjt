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
    public partial class ShowPenalty : Form
    {
        BookManageDAO manageDAO = BookManageDAO.getInstance();
        int c_idx;
        public ShowPenalty(string name, int c_idx)
        {
            InitializeComponent();
            laUserName.Text = "'" + name + "' 회원의 연체금 입니다.";
            txtPenalty.Text = manageDAO.selectPenalty(c_idx).ToString();
            this.c_idx = c_idx;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 연체금을 처리하시겠습니까?", "연체금 처리", MessageBoxButtons.YesNo) == DialogResult.Yes)
                if (!manageDAO.selectChkReturnBook(c_idx))
                    MessageBox.Show("해당 사용자의 모든 도서를 반납 후 연체금 처리 바랍니다.");
                else
                {
                    try
                    {
                        if (Convert.ToInt32(txtPenalty.Text) < Convert.ToInt32(txtInputPenalty.Text))
                        {
                            MessageBox.Show("연체금보다 더 높게 입력하셨습니다. 다시 입력해주세요.");
                            return;
                        }
                        if (manageDAO.updatePenalty(Convert.ToInt32(txtPenalty.Text), Convert.ToInt32(txtInputPenalty.Text), c_idx))
                        {
                            MessageBox.Show("연체금 완납 완료");
                            this.Dispose();
                        }
                        else
                            MessageBox.Show("연체금 완납 실패");
                    }
                    catch
                    {
                        MessageBox.Show("숫자만 입력해주시기 바랍니다.");
                        return;
                    }
                }
        }
    }
}
