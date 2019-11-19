using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookPjt.DTO
{
    class UserQADTO
    {
       
        private int q_idx;
        private string q_title;
        private string q_content;
        private string q_date;
        private string q_status;
        private string q_c_name;

        public UserQADTO(int q_idx,string q_title,string q_content,string q_date,string q_status, string q_c_name)
        {
            this.q_idx = q_idx;
            this.q_title = q_title;
            this.q_content = q_content;
            this.q_date = q_date;
            this.q_status = q_status;
            this.q_c_name = q_c_name;
        }

        public int Q_idx { get { return q_idx; } set { q_idx = value; } }
        public string Q_title { get { return q_title; } set { q_title = value; } }
        public string Q_content { get { return q_content; } set { q_content = value; } }
        public string Q_date { get { return q_date; } set { q_date = value; } }
        public string Q_status { get { return q_status; } set { q_status = value; } }
        public string Q_c_name { get { return q_c_name; } set { q_c_name = value; } }
    }
}
