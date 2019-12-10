using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace bookPjt
{
    class BookDAO
    {
        private static BookDAO bookDAO = null;
        private string dbInfo = "Server=localhost;Database=library;Uid=root;Pwd=apmsetup;charset=utf8";
        public static BookDAO getInstance()
        {
            if (bookDAO == null)
                bookDAO = new BookDAO();
            return bookDAO;
        }

        private BookDAO()
        {

        }

        public bool deleteBook(int bookid)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            mySqlConnection.Open();
            MySqlTransaction trans = mySqlConnection.BeginTransaction();

            try
            {
                string sql = "delete from book where b_idx = " + bookid;
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand.ExecuteNonQuery();
                sql = "delete from category where ct_b_id = " + bookid;
                mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand.ExecuteNonQuery();
                sql = "delete from publisher where p_b_id = " + bookid;
                mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand.ExecuteNonQuery();
                trans.Commit();
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                trans.Rollback();
                return false;
            }
            return true;
        }

        public bool updateBook(int bookid, string bookName, string summary)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);

            string sql = "update book set b_name = '" + bookName + "',b_summary = '" + summary + "' where b_idx = " + bookid;

            try
            {
                mySqlConnection.Open();
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand.ExecuteNonQuery();

                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public List<BookDTO> getBookList(string type, string search, int age)
        {
            List<BookDTO> list = new List<BookDTO>();
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            string ageWhere = "";
            if (age >= 19)
                ageWhere = "";
            else if (age >= 15 && age < 19)
                ageWhere = " AND b_guest < 19 ";
            else if (age >= 12 && age <= 15)
                ageWhere = " AND b_guest <= 15 ";
            else if (age <= 12)
                ageWhere = " AND b_guest <= 12 ";
            else
                ageWhere = " AND b_guest != 19 AND b_guest != 15 AND b_guest != 12 ";
            string sql = "SELECT b_idx,b_name,b_author,c_n_name,p_n_name,IF(b_stock = 0,'대출 불가','대출 가능'),b_img,b_summary FROM book, category, categoryName, publisher, publisherName WHERE book.b_idx = category.ct_b_id AND book.b_idx = publisher.p_b_id AND categoryname.c_n_idx = category.ct_idx AND publisherName.p_n_idx = publisher.p_idx " + ageWhere;
            if (search != "")
                sql += " AND " + type + " like '%" + search + "%'";
            try
            {
                mySqlConnection.Open();
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new BookDTO(
                        Convert.ToInt32(rdr[0]),
                        rdr[1].ToString(),
                        rdr[2].ToString(),
                        rdr[3].ToString(),
                        rdr[4].ToString(),
                        rdr[5].ToString(),
                        rdr[6].ToString(),
                        rdr[7].ToString()
                        ));
                }
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return list;
        }
        public BookDTO selectBook(int bookid)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            BookDTO bookDTO = null;
            string sql = "select b_idx ,b_name,b_stock,b_author, p_n_name , c_n_name , b_summary , b_img, b_guest, b_date, searchBook(b_idx)";
            sql += " from book, category, categoryName, publisher, publisherName";
            sql += " where book.b_idx = category.ct_b_id and book.b_idx = publisher.p_b_id";
            sql += " and category.ct_idx = categoryName.c_n_idx and publisher.p_idx = publisherName.p_n_idx and b_idx = " + bookid;

            try
            {
                mySqlConnection.Open();
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                while (rdr.Read())
                {
                    string status = "대출 가능";
                    if (Convert.ToInt32(rdr[10]) >= 3)
                        status = "대출 불가";
                    bookDTO = new BookDTO(
                        Convert.ToInt32(rdr[0]),
                        Convert.ToString(rdr[1]),
                        Convert.ToInt32(rdr[2]),
                        Convert.ToString(rdr[3]),
                        Convert.ToString(rdr[4]),
                        Convert.ToString(rdr[5]),
                        Convert.ToString(rdr[6]),
                        Convert.ToString(rdr[7]),
                        Convert.ToString(rdr[8]),
                        Convert.ToString(rdr[9]),
                        status
                        );
                }
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return bookDTO;
        }

        private int resultPublisher(string publisher)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            int result = 0;

            string sql = "select p_n_idx from publisherName where p_n_name = '" + publisher + "'";
            try
            {
                mySqlConnection.Open();
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                while (rdr.Read())
                {
                    result = Convert.ToInt32(rdr[0]);
                }
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return result;
        }

        private int resultCategory(string category)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            int result = 0;

            string sql = "select c_n_idx from categoryname where c_n_name = '" + category + "'";
            try
            {
                mySqlConnection.Open();
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                while (rdr.Read())
                {
                    result = Convert.ToInt32(rdr[0]);
                }
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return result;
        }

        public bool insertBook(BookDTO bookDTO)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            mySqlConnection.Open();
            MySqlTransaction trans = mySqlConnection.BeginTransaction();

            string b_name = bookDTO.B_name;
            string b_author = bookDTO.B_author;
            string b_publisher = bookDTO.B_puBlisher;
            string b_category = bookDTO.B_category;
            string b_summery = bookDTO.B_summary;
            string b_img = bookDTO.B_img;
            int b_stock = bookDTO.B_stock;
            string b_guest = "0";
            if (bookDTO.B_guest == "전체 이용")
                b_guest = "0";
            else if (bookDTO.B_guest == "12세 이용")
                b_guest = "12";
            else if (bookDTO.B_guest == "15세 이용")
                b_guest = "15";
            else if (bookDTO.B_guest == "성인")
                b_guest = "19";
            try
            {
                string sql = "insert into book values (NULL,'" + b_name + "'," + b_stock + ",'" + b_author + "','" + b_summery + "','" + b_img + "','" + b_guest + "',now())";

                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand.ExecuteNonQuery();

                int categoryNum = resultCategory(b_category);
                int publisherNum = resultPublisher(b_publisher);

                sql = "insert into category values (" + categoryNum + ",NULL)";
                mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand.ExecuteNonQuery();

                sql = "insert into publisher values (" + publisherNum + ",NULL)";
                mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand.ExecuteNonQuery();

                trans.Commit();

                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                trans.Rollback();
                MessageBox.Show(e.Message);
            }
            return true;
        }
        public List<string> getPublisherList()
        {
            List<string> list = new List<string>();
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);

            string sql = "SELECT p_n_name FROM publisherName";
            try
            {
                mySqlConnection.Open();
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(rdr[0].ToString());
                }
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return list;
        }

        public bool updateCategory(string before, string after)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);

            string sql = "UPDATE categoryName SET c_n_name = '" + after + "' WHERE c_n_name = '" + before + "' ";
            try
            {
                mySqlConnection.Open();
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public List<string> getCategoryList()
        {
            List<string> list = new List<string>();
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);

            string sql = "SELECT c_n_name FROM categoryName";
            try
            {
                mySqlConnection.Open();
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(rdr[0].ToString());
                }
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return list;
        }

        public List<BookDTO> selectList(string category, string search, bool sort)
        {
            List<BookDTO> list = new List<BookDTO>();
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            string ageWhere = "";
            string sql = "select b_idx ,b_name,b_stock,b_author, p_n_name , c_n_name, b_summary, b_img, b_guest, b_date, searchBook(b_idx)";
            sql += " from book, category, categoryName, publisher, publisherName";
            sql += " where book.b_idx = category.ct_b_id and book.b_idx = publisher.p_b_id";
            sql += " and category.ct_idx = categoryName.c_n_idx and publisher.p_idx = publisherName.p_n_idx";
            sql += " and b_name like '%" + search + "%'" + ageWhere;
            if (category != "도서 분류" && category != "")
                sql += " and c_n_name = '" + category + "'";
            if (sort)
                sql += "order by b_idx desc";
            try
            {
                mySqlConnection.Open();
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                while (rdr.Read())
                {
                    string guest = Convert.ToString(rdr[8]) + "세 이용";
                    if (Convert.ToString(rdr[8]) == "0")
                        guest = "전체 이용";
                    string status = "대출 가능";
                    if (Convert.ToInt32(rdr[10]) >= 3)
                    {
                        status = "대출 불가";
                    }
                    BookDTO bookDTO = new BookDTO(
                        Convert.ToInt32(rdr[0]),
                        Convert.ToString(rdr[1]),
                        Convert.ToInt32(rdr[2]),
                        Convert.ToString(rdr[3]),
                        Convert.ToString(rdr[4]),
                        Convert.ToString(rdr[5]),
                        Convert.ToString(rdr[6]),
                        Convert.ToString(rdr[7]),
                        guest,
                        Convert.ToString(rdr[9]),
                        status);
                    list.Add(bookDTO);
                }
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return list;
        }

        public bool insertCategory(string categoryName)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            try
            {
                mySqlConnection.Open();
                string sql = "insert into categoryName values (NULL,'" + categoryName + "')";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }

        public bool updatePublisher(string beforePublisherName, string publisherName)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            try
            {
                mySqlConnection.Open();
                string sql = "UPDATE publisherName SET p_n_name = '" + publisherName + "' WHERE p_n_name = '" + beforePublisherName + "' ";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }
        public bool insertPublisher(string publisherName)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            try
            {
                mySqlConnection.Open();
                string sql = "insert into publisherName values (NULL,'" + publisherName + "')";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }
    }
}
