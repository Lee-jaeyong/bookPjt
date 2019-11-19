using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookPjt.DTO
{
    class NoticeDTO
    {
        private int no_idx;
        private string no_title;
        private string no_content;
        private string no_date;
        private int no_hit;

        public NoticeDTO(int no_idx, string no_title, string no_content, string no_date, int no_hit)
        {
            this.no_idx = no_idx;
            this.no_title = no_title;
            this.no_content = no_content;
            this.no_date = no_date;
            this.no_hit = no_hit;
        }
        public int No_idx { get { return no_idx; } set { no_idx = value; } }
        public string No_title { get { return no_title; } set { no_title = value; } }
        public string No_content { get { return no_content; } set { no_content = value; } }
        public string No_date { get { return no_date; } set { no_date = value; } }
        public int No_hit { get { return no_hit; } set { no_hit = value; } }
    }
}
