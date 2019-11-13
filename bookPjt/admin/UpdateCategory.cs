using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookPjt.admin
{
    public partial class updateCategoryForm : Form
    {
        bookManagement form;
        public updateCategoryForm(bookManagement form,string updateCategory)
        {
            InitializeComponent();
            txtBefore.Text = updateCategory;
            this.form = form;
        }

        private void btnCategoryUpdateExecute_Click(object sender, EventArgs e)
        {
            BookDAO bookDAO = BookDAO.getInstance();
            if (bookDAO.updateCategory(txtBefore.Text, txtAfter.Text))
            {
                MessageBox.Show("수정 완료");
                form.categoryListShow();
                Hide();
            }
            else
                MessageBox.Show("수정 실패");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }


    }
}
