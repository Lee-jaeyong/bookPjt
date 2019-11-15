using bookPjt;
using System;
using System.Windows.Forms;

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
                Form frm;
                this.Visible = false;
                if (inputId == "dlwodyd202")
                    frm = new BookAdmin();
                else
                    frm = new index(inputId);
                frm.Owner = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호 오류 입니다.");
            }
        }


        private void joinBtn_Click(object sender, EventArgs e)
        {
            JoinForm joinF = new JoinForm();
            joinF.ShowDialog();
        }

        private void pwTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn_Click(sender, e);
            }

        }

        private void id_pwFindBtn_Click(object sender, EventArgs e)
        {
            IdPw_SearchForm findForm = new IdPw_SearchForm();
            findForm.ShowDialog();
        }
    }
}
