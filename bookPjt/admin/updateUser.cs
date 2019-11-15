using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bookPjt.DTO;
using BookManagement;

namespace bookPjt.admin
{
    public partial class UpdateUser : Form
    {
        BookAdmin bookAdmin;
        UserDAO userDAO = UserDAO.getInstance();
        UserDTO userDTO = new UserDTO();
        public UpdateUser(BookAdmin bookAdmin,string id,string name,string phone,string birth,int c_idx)
        {
            InitializeComponent();
            this.bookAdmin = bookAdmin;
            txtUserId.Text = id;
            txtUserName.Text = name;
            txtUserBirth.Text = birth;
            string[] _phone = phone.Split('-');
            txtUserPhone1.Text = _phone[0];
            txtUserPhone2.Text = _phone[1];
            txtUserPhone3.Text = _phone[2];
            userDTO.C_idx = c_idx;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            Dispose();
        }

        private void updateUser()
        {
            userDTO.C_birth = txtUserBirth.Text.Trim();
            userDTO.C_name = txtUserName.Text.Trim();
            string[] phone = new string[] { txtUserPhone1.Text.Trim(), txtUserPhone2.Text.Trim(), txtUserPhone3.Text.Trim() };
            if (userDAO.updateUser(userDTO, phone))
            {
                MessageBox.Show("수정 완료");
                bookAdmin.selectUserList("", "", false);
                Hide();
                Dispose();
            }
            else
                MessageBox.Show("수정 실패");
        }

        private void BtnUpdateUserInfo_Click(object sender, EventArgs e)
        {
            updateUser();
        }

        private void txtUserBirth_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                updateUser();
        }
    }
}
