using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookManagement;

namespace bookPjt.admin
{
    public partial class UserRankUpdate : Form
    {
        UserDAO userDAO = UserDAO.getInstance();
        BookAdmin bookAdmin;
        private string rank;
        private int c_idx;
        public UserRankUpdate(BookAdmin bookAdmin, string rank, int c_idx)
        {
            InitializeComponent();
            this.bookAdmin = bookAdmin;
            this.rank = rank;
            this.c_idx = c_idx;
            ComboAfterRank.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Dispose();
        }

        private void UserRankUpdate_Load(object sender, EventArgs e)
        {
            txtBeforeRank.Text = rank;
        }

        private void btnUpdateRankExecute_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 권한을 변경하시겠습니까?", "권한 변경", MessageBoxButtons.YesNo) == DialogResult.Yes)
                if (userDAO.updateUserRank(ComboAfterRank.Text, c_idx))
                {
                    MessageBox.Show("권한 변경 완료");
                    bookAdmin.selectUserList("", "", false);
                    Hide();
                    Dispose();
                }
                else
                    MessageBox.Show("권한 변경 실패");
        }
    }
}
