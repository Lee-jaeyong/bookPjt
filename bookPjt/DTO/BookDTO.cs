namespace bookPjt
{
    class BookDTO
    {
        private int b_idx;
        private string b_name;
        private int b_stock;
        private string b_author;
        private string b_summary;
        private string b_img;
        private string b_category;
        private string b_publisher;
        private string b_guest;
        private string b_date;
        private string b_status;

        public BookDTO(string bookname, string author, string publisher, string category, string content, string img, int stock)
        {
            this.b_name = bookname;
            this.b_author = author;
            this.b_publisher = publisher;
            this.b_category = category;
            this.b_summary = content;
            this.b_img = img;
            this.b_stock = stock;
        }
        public BookDTO(int b_idx, string b_name, int b_stock, string b_author, string b_publisher, string b_category, string content, string b_img,string b_guest,string b_date,string b_status)
        {
            this.b_name = b_name;
            this.b_stock = b_stock;
            this.b_author = b_author;
            this.b_idx = b_idx;
            this.b_publisher = b_publisher;
            this.b_category = b_category;
            this.b_summary = content;
            this.b_img = b_img;
            this.b_date = b_date;
            this.b_guest = b_guest;
            this.b_status = b_status;
        }
        public string B_status
        {
            get
            {
                return this.b_status;
            }
            set
            {
                b_status = value;
            }
        }
        public string B_guest
        {
            get
            {
                return this.b_guest;
            }
            set
            {
                b_guest = value;
            }
        }

        public string B_date
        {
            get
            {
                return this.b_date;
            }
            set
            {
                b_date = value;
            }
        }

        public string B_puBlisher
        {
            get
            {
                return b_publisher;
            }
            set
            {
                b_publisher = value;
            }
        }

        public string B_category
        {
            get
            {
                return b_category;
            }
            set
            {
                b_category = value;
            }
        }

        public string B_img
        {
            get
            {
                return b_img;
            }
            set
            {
                b_img = value;
            }
        }

        public string B_summary
        {
            get
            {
                return b_summary;
            }
            set
            {
                b_summary = value;
            }
        }
        public string B_author
        {
            get
            {
                return b_author;
            }
            set
            {
                b_author = value;
            }
        }

        public int B_stock
        {
            get
            {
                return b_stock;
            }
            set
            {
                b_stock = value;
            }
        }
        public string B_name
        {
            get
            {
                return b_name;
            }
            set
            {
                b_name = value;
            }
        }

        public int B_idx
        {
            get
            {
                return b_idx;
            }
            set
            {
                b_idx = value;
            }
        }
    }
}
