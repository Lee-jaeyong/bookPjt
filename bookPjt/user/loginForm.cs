using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bookPjt;

namespace BookManagement
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            UserDAO dao = UserDAO.getInstance();
            string inputId = idTxt.Text;
            string inputPw = pwTxt.Text;

            bool re = dao.userLogin(inputId, inputPw);

                if (re)
                {
                    this.Visible = false;
                    bookManagement frm = new bookManagement();
                    frm.Owner = this;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("아이디 또는 비밀번호 오류 입니다.");
                }
        }

        private void pwTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn_Click(sender, e);
            }

        }

        private void joinBtn_Click(object sender, EventArgs e)
        {
            JoinForm joinF = new JoinForm();
            joinF.ShowDialog();
        }
    }
}
