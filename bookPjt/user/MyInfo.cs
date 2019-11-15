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
using bookPjt.DTO;
using bookPjt.DAO;

namespace bookPjt.user
{
    public partial class MyInfo : Form
    {
        UserDAO userDAO = UserDAO.getInstance();
        UserDTO userDTO;
        BookRentalChkDAO bookRentalChkDAO = BookRentalChkDAO.getInstance();

        private string c_id;
        public MyInfo(string c_id)
        {
            InitializeComponent();
            this.c_id = c_id;
            infoOut();
        }

        private void infoOut()
        {
            userDTO = userDAO.getUserInfo(c_id);
            txtUserId.Text = userDTO.C_identy;
            txtUserName.Text = userDTO.C_name;
            txtUserBirth.Text = userDTO.C_birth;
            string[] phone = userDTO.C_phone.Split('-');
            txtUserPhone1.Text = phone[0];
            txtUserPhone2.Text = phone[1];
            txtUserPhone3.Text = phone[2];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            ComboRental.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = true;
            txtUserBirth.Enabled = true;
            txtUserPhone1.Enabled = true;
            txtUserPhone2.Enabled = true;
            txtUserPhone3.Enabled = true;
            btnUserUpdate.Visible = false;
            btnUserUpdateExecute.Visible = true;
            btnUserUpdateCencel.Visible = true;
        }

        private void btnUserUpdateExecute_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = false;
            txtUserBirth.Enabled = false;
            txtUserPhone1.Enabled = false;
            txtUserPhone2.Enabled = false;
            txtUserPhone3.Enabled = false;
            btnUserUpdate.Visible = true;
            btnUserUpdateExecute.Visible = false;
            btnUserUpdateCencel.Visible = false;

            UserDTO userUpdate = new UserDTO();
            userUpdate.C_identy = userDTO.C_identy;
            userUpdate.C_name = txtUserName.Text;
            userUpdate.C_birth = txtUserBirth.Text;
            string[] phone = new string[] { txtUserPhone1.Text, txtUserPhone2.Text, txtUserPhone3.Text };
            if (userDAO.updateUser(userUpdate, phone))
            {
                MessageBox.Show("수정 완료");
                infoOut();
            }
            else
                MessageBox.Show("수정 실패");
        }

        private void btnUserUpdateCencel_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = false;
            txtUserBirth.Enabled = false;
            txtUserPhone1.Enabled = false;
            txtUserPhone2.Enabled = false;
            txtUserPhone3.Enabled = false;
            btnUserUpdate.Visible = true;
            btnUserUpdateExecute.Visible = false;
            btnUserUpdateCencel.Visible = false;
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            if (txtChangePass.Text != txtChangePassChk.Text)
                MessageBox.Show("비밀번호가 일치하지 않습니다");
            else
            {
                if (userDAO.updatePassWord(txtChangePass.Text, c_id))
                    MessageBox.Show("비밀번호 변경 완료");
                else
                    MessageBox.Show("비밀번호 변경 실패");
            }
            txtChangePass.Text = "";
            txtChangePassChk.Text = "";
        }

        private void ComboRental_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboRental.Text == "대출 신청")
            {
                rentalChkTable.Visible = true;
                rentalChkTable.Rows.Clear();
                List<RentalChkDTO> list = bookRentalChkDAO.getRentalList(c_id);
                foreach (RentalChkDTO item in list)
                {
                    rentalChkTable.Rows.Add(item.BookTitle, item.RentalChkDate);
                }
            }
        }
    }
}
