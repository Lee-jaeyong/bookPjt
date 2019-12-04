using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bookPjt.DAO;
using System.Windows.Forms;

namespace bookPjt.admin
{
    public partial class BookReservation : Form
    {
        string b_idx;
        string id;
        string b_name;
        BookReservationDAO bookReservationDAO = BookReservationDAO.getInstance();
        public BookReservation(string b_name, string b_idx, string id)
        {
            InitializeComponent();
            this.b_idx = b_idx;
            this.id = id;
            this.b_name = b_name;
            bookName.Text = "'" + b_name + "' 도서를 예약합니다.";
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            if (bookReservationDAO.insertReservation(id, b_idx, dateTimePicker.Text))
            {
                MessageBox.Show("예약 완료");
                Dispose();
            }
            else
                MessageBox.Show("예약 실패");
        }
    }
}
