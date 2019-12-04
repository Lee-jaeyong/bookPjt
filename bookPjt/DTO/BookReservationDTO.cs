using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookPjt.DTO
{
    class BookReservationDTO
    {
        private int b_idx;
        private string b_name;
        private string reservationDate;
        private int c_idx;
        private string c_id;
        private string c_name;
        private int rc_idx;

        public BookReservationDTO(int b_idx, string b_name, string reservationDate)
        {
            this.b_idx = b_idx;
            this.b_name = b_name;
            this.reservationDate = reservationDate;
        }
        public BookReservationDTO(int rc_idx,int b_idx, string c_id, string b_name, string c_name,string reservationDate)
        {
            this.rc_idx = rc_idx;
            this.c_name = c_name;
            this.c_id = c_id;
            this.b_idx = b_idx;
            this.b_name = b_name;
            this.reservationDate = reservationDate;
        }

        public int B_idx { get { return b_idx; } set { b_idx = value; } }
        public int Rc_idx { get { return rc_idx; } set { rc_idx = value; } }
        public string C_name { get { return c_name; } set { c_name = value; } }
        public string B_name { get { return b_name; } set { b_name = value; } }
        public string ReservationDate { get { return reservationDate; } set { reservationDate = value; } }
        public string C_id { get { return c_id; } set { c_id = value; } }
        public int C_idx { get { return c_idx; } set { c_idx = value; } }
    }
}
