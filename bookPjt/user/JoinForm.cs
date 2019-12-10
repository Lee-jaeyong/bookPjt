using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BookManagement
{
    public partial class JoinForm : Form
    {
        UserDAO dao = UserDAO.getInstance();
        public JoinForm()
        {
            InitializeComponent();
            ph0Select.Text = "010";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("회원가입을 취소하시겠습니까?", "회원가입 취소", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Dispose();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string inputName = nameTxt.Text;
            string inputId = idTxt.Text;
            string inputPw = pwTxt.Text;
            string pwCheck = pw2Txt.Text;
            string inputPh1 = ph1Txt.Text;
            string inputPh2 = ph2Txt.Text;
            string inputPh0 = ph0Select.Text;
            string inputBirth = txtBirth.Text;
            string inputEmail = txtEmail.Text;
            string inputAddress = txtAddress.Text;
            int birth;
            Regex regex_name = new Regex(@"^[가-힣]+$");
            Regex regex_id = new Regex(@"^[a-zA-Z0-9]+$");
            if (!(regex_name.IsMatch(inputName)))
            {
                MessageBox.Show("한글 이름을 입력해주세요");
                nameTxt.Focus();
            }
            else if (!(int.TryParse(inputBirth, out birth)))
            {
                MessageBox.Show("생년월일을 다시 입력해주세요.");
                txtBirth.Focus();
            }
            else if (inputBirth.Length > 6)
            {
                MessageBox.Show("생년월일을 6자리까지만 입력해주세요.");
                txtBirth.Focus();
            }
            else if (!(regex_id.IsMatch(inputId)) || inputId.Length < 8)
            {
                MessageBox.Show("아이디는 영문,숫자 8자 이상입니다");
                idTxt.Focus();
            }
            else if (!(regex_id.IsMatch(inputPw)) || inputPw.Length < 8)
            {
                MessageBox.Show("비밀번호는 영문, 숫자 8자 이상입니다.");
                pw2Txt.Text = "";
            }
            else if (inputPw != pwCheck)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다");
                pw2Txt.Text = "";
                pw2Txt.Focus();
            }
            else if (dao.dupCheck(inputId))
            {
                MessageBox.Show("이미 사용중인 아이디 입니다");
                idTxt.Text = "";
                idTxt.Focus();
            }
            else if (!Regex.IsMatch(inputEmail, @"[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?"))
            {
                MessageBox.Show("이메일 형식이 올바르지 않습니다");
                txtEmail.Focus();
            }
            else if (inputAddress.Trim() == "")
            {
                MessageBox.Show("주소를 입력해주세요");
                txtAddress.Focus();
            }
            else
            {
                //DAO연결 insert
                if (MessageBox.Show("입력하신 해당 정보로 회원가입 하시겠습니까?", "회원가입", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool result = dao.joinDB(inputName, inputPh0, inputPh1, inputPh2, inputId, inputPw, inputBirth, inputEmail, inputAddress);
                    if (result == true)
                    {
                        MessageBox.Show("회원가입이 완료되었습니다");
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("회원가입 실행 오류");
                    }
                }
            }
        }


        private void ph1Txt_Leave(object sender, EventArgs e)
        {
            string phone1 = ph1Txt.Text;

            try
            {
                if (phone1.Length == 4 || phone1.Length == 3 || phone1.Length == 0)
                {
                    int.Parse(phone1);
                }
                else
                {
                    MessageBox.Show("3자리 또는 4자리 숫자로 입력해주세요");
                    ph1Txt.Text = "";
                    ph1Txt.Focus();
                }

            }
            catch (Exception ex)
            {
                if (phone1.Length != 0)
                {
                    MessageBox.Show("3자리 또는 4자리 숫자로 입력해주세요");
                    ph1Txt.Text = "";
                    ph1Txt.Focus();
                }
            }
        }

        private void ph2Txt_Leave(object sender, EventArgs e)
        {
            string phone2 = ph2Txt.Text;

            try
            {
                if (phone2.Length == 4 || phone2.Length == 0)
                {
                    int.Parse(phone2);
                }
                else
                {
                    MessageBox.Show("4자리 숫자로 입력해주세요");
                    ph2Txt.Text = "";
                    ph2Txt.Focus();
                }

            }
            catch (Exception ex)
            {
                if (phone2.Length != 0)
                {
                    MessageBox.Show("4자리 숫자로 입력해주세요");
                    ph2Txt.Text = "";
                    ph2Txt.Focus();
                }
            }

        }

        private void idTxt_KeyUp(object sender, KeyEventArgs e)
        {
            string inputId = idTxt.Text;
            Regex regex_id = new Regex(@"^[a-zA-Z0-9]+$");
            if (!(regex_id.IsMatch(inputId)) || inputId.Length < 8)
                lblDupChk.Text = "* 아이디는 영문,숫자 8자 이상입니다";
            else
                if (dao.dupCheck(inputId))
                lblDupChk.Text = "* 중복된 아이디가 존재합니다";
            else
                lblDupChk.Text = "* 사용 가능한 아이디입니다";
        }
    }
}
