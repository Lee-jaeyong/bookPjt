﻿using BookManagement;
using System;
using System.Windows.Forms;

namespace bookPjt
{
    public partial class IdPw_SearchForm : Form
    {
        UserDAO dao = UserDAO.getInstance();
        public IdPw_SearchForm()
        {
            InitializeComponent();
        }

        private void idFindBtn_Click(object sender, EventArgs e)
        {
            string name = idFindName.Text;
            string ph0 = idFindPh0.Text;
            string ph1 = idFindPh1.Text;
            string ph2 = idFindPh2.Text;

            string re = dao.findId(name, ph0, ph1, ph2);
            MessageBox.Show(re);
            Dispose();
        }

        private void pwFindBtn_Click(object sender, EventArgs e)
        {
            string name = pwFindName.Text;
            string id = pwFindId.Text;

            string re = dao.findPw(name, id);
            MessageBox.Show(re);
            Dispose();
        }

        private void idFindPh2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                idFindBtn_Click(sender, e);
            }
        }

        private void pwFindId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pwFindBtn_Click(sender, e);
            }
        }
    }
}
