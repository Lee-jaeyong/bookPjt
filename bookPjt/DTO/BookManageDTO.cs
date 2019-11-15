using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookPjt.DTO
{
    class BookManageDTO
    {
        private int bm_idx;
        private int c_idx;
        private string c_name;
        private string c_phone;
        private string c_identy;
        private string c_birth;
        private int bm_b_idx;
        private string b_name;
        private string bm_takeDate;
        private string bm_returnDate;
        private int bm_extend;
        private int status;
        public BookManageDTO(string b_name,string bm_takeDate, string bm_returnDate, int bm_extend,int bm_status)
        {
            this.b_name = b_name;
            this.bm_takeDate = bm_takeDate;
            this.bm_returnDate = bm_returnDate;
            this.bm_extend = bm_extend;
            this.status = bm_status;
        }
        public BookManageDTO(int bm_idx, int b_idx, int c_idx, string b_name, string c_name, string bm_takeDate, string bm_returnDate, int bm_extend, int status)
        {
            this.status = status;
            this.bm_idx = bm_idx;
            this.c_idx = c_idx;
            bm_b_idx = b_idx;
            this.b_name = b_name;
            this.c_name = c_name;
            this.bm_takeDate = bm_takeDate;
            this.bm_returnDate = bm_returnDate;
            this.bm_extend = bm_extend;
        }
        public int Status { get { return status; } set { status = value; } }
        public int Bm_idx { get { return bm_idx; } set { bm_idx = value; } }
        public string B_name { get { return b_name; } set { b_name = value; } }
        public int C_idx { get { return c_idx; } set { c_idx = value; } }
        public string C_name { get { return c_name; } set { c_name = value; } }
        public string C_phone { get { return c_phone; } set { c_phone = value; } }
        public string C_identy { get { return c_identy; } set { c_identy = value; } }
        public string C_birth { get { return c_birth; } set { c_birth = value; } }
        public int Bm_b_idx { get { return bm_b_idx; } set { bm_b_idx = value; } }
        public string Bm_takeDate { get { return bm_takeDate; } set { bm_takeDate = value; } }
        public string Bm_returnDate { get { return bm_returnDate; } set { bm_returnDate = value; } }
        public int Bm_extend { get { return bm_extend; } set { bm_extend = value; } }
    }


}
