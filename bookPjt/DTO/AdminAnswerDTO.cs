using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookPjt.DTO
{
    class AdminAnswerDTO
    {
        private int ans_q_idx;
        private string ans_title;
        private string ans_content;
        private string ans_date;

        public AdminAnswerDTO(int ans_q_idx,string ans_title,string ans_content,string ans_date)
        {
            this.ans_q_idx = ans_q_idx;
            this.ans_title = ans_title;
            this.ans_content = ans_content;
            this.ans_date = ans_date;
        }

        public int Ans_q_idx { get { return ans_q_idx; } set { ans_q_idx = value; } }
        public string Ans_title { get { return ans_title; } set { ans_title = value; } }
        public string Ans_content { get { return ans_content; } set { ans_content = value; } }
        public string Ans_date { get { return ans_date; } set { ans_date = value; } }
    }
}
