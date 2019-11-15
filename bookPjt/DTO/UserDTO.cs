using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bookPjt.DTO;

namespace bookPjt.DTO
{
    class UserDTO
    {
        private int c_idx;
        private string c_name;
        private string c_phone;
        private string c_identy;
        private string c_birth;
        private string c_rank;
        private int totalManageCount;
        public UserDTO()
        {

        }
        public UserDTO(int c_idx,string c_identy, string c_name, string c_phone, string c_birth)
        {
            this.c_idx = c_idx;
            this.c_name = c_name;
            this.c_identy = c_identy;
            this.c_birth = c_birth;
            this.c_phone = c_phone;
        }
        public UserDTO(string c_identy, string c_name, string c_birth, string c_phone, string c_rank, int c_idx)
        {
            this.c_idx = c_idx;
            this.c_name = c_name;
            this.c_identy = c_identy;
            this.c_birth = c_birth;
            this.c_phone = c_phone;
            this.c_rank = c_rank;
        }

        public UserDTO(string c_identy, string c_birth, string c_phone, int totalManageCount)
        {
            this.c_identy = c_identy;
            this.c_birth = c_birth;
            this.c_phone = c_phone;
            this.totalManageCount = totalManageCount;
        }

        public int TotalManageCount { get { return totalManageCount; } set { totalManageCount = value; } }
        public int C_idx { get { return c_idx; } set { c_idx = value; } }
        public string C_name { get { return c_name; } set { c_name = value; } }
        public string C_phone { get { return c_phone; } set { c_phone = value; } }
        public string C_identy { get { return c_identy; } set { c_identy = value; } }
        public string C_birth { get { return c_birth; } set { c_birth = value; } }
        public string C_rank { get { return c_rank; } set { c_rank = value; } }
    }
}
