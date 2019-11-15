using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookPjt.DTO
{
    class RentalChkDTO
    {
        private int rentalChk_idx;
        private int b_idx;
        private string c_id;
        private string bookImg;
        private string bookTitle;
        private string rentalUser;
        private string rentalChkDate;

        public RentalChkDTO(int b_idx,string c_id, string bookImg,string bookTitle,string rentalUser,string rentalChkDate)
        {
            this.b_idx = b_idx;
            this.c_id = c_id;
            this.bookImg = bookImg;
            this.bookTitle = bookTitle;
            this.rentalChkDate = rentalChkDate;
            this.rentalUser = rentalUser;
        }

        public int B_idx { get { return b_idx; } set { b_idx = value; } }
        public string C_id { get { return c_id; } set { c_id = value; } }
        public int RentalChk_idx { get { return rentalChk_idx; } set { rentalChk_idx = value; } }
        public string BookImg { get {return bookImg; } set { bookImg = value; } }
        public string BookTitle { get { return bookTitle; } set { bookTitle = value; } }
        public string RentalUser { get { return rentalUser; } set { rentalUser = value; } }
        public string RentalChkDate { get { return rentalChkDate; } set { rentalChkDate = value; } }
    }
}
