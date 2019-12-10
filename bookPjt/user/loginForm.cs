using bookPjt;
using System;
using System.Windows.Forms;

namespace BookManagement
{
    public partial class loginForm : Form
    {
        string id = "";
        int count = 0;
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(idTxt.Text.Trim() == "" || pwTxt.Text.Trim() == "")
            {
                MessageBox.Show("아이디 혹은 비밀번호를 입력해주세요.");
                return;
            }
            UserDAO dao = UserDAO.getInstance();
            string inputId = idTxt.Text;
            string inputPw = pwTxt.Text;
            if (id != inputId)
            {
                id = inputId;
                count = 0;
            }
            bool re = dao.userLogin(inputId, inputPw);
            if (re)
            {
                string userRank = dao.checkUserRank(inputId);
                int age = dao.checkAge(inputId);
                Form frm;
                if (inputId == "root" || userRank == "관리자" || userRank == "사서")
                    frm = new BookAdmin(userRank, userRank);
                else
                    frm = new index(inputId, userRank, age);
                frm.Owner = this;
                frm.Show();
                this.Hide();
            }
            else
            {
                if (id == inputId && count < 4)
                {
                    MessageBox.Show("아이디 또는 비밀번호 오류 입니다.");
                    count++;
                }
                else
                if (MessageBox.Show("로그인 5회 오류 입니다.\r아이디 또는 비밀번호 찾기를 하시겠습니까?", "아이디, 비밀번호 찾기", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    IdPw_SearchForm findForm = new IdPw_SearchForm();
                    findForm.ShowDialog();
                }
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

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pwTxt_Enter(object sender, EventArgs e)
        {
            pwTxt.Text = "";
        }
    }
}
