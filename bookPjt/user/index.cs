using System;
using System.Windows.Forms;

namespace BookManagement
{
    public partial class index : Form
    {
        private string id;

        public index(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void outBtn_Click(object sender, EventArgs e)
        {
            loginForm frm = new loginForm();
            MessageBox.Show("로그아웃 완료");
            id = "";
            frm.Show();
            Hide();
        }

        private void index_Load(object sender, EventArgs e)
        {

        }
    }
}
