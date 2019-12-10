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
        BookAdmin form;
        public updateCategoryForm(BookAdmin form,string updateCategory)
        {
            InitializeComponent();
            txtBefore.Text = updateCategory;
            this.form = form;
        }

        private void btnCategoryUpdateExecute_Click(object sender, EventArgs e)
        {
            if(txtAfter.Text.Trim() == "")
            {
                MessageBox.Show("카테고리를 입력해주세요.");
                return;
            }
            if (MessageBox.Show("정말 카테고리를 수정하시겠습니까?", "카테고리 수정", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BookDAO bookDAO = BookDAO.getInstance();
                if (txtAfter.Text.Trim() != null)
                    if (bookDAO.updateCategory(txtBefore.Text, replaceAll(txtAfter.Text)))
                    {
                        MessageBox.Show("수정 완료");
                        form.categoryListShow();
                        Hide();
                    }
                    else
                        MessageBox.Show("수정 실패");
                else
                    MessageBox.Show("수정할 카테고리 명을 입력해주세요.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private string replaceAll(string str)
        {
            return str.Replace("'", "\\singleQ\\");
        }
    }
}
