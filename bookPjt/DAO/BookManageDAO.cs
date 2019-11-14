using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bookPjt.DTO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace bookPjt.DAO
{
    class BookManageDAO
    {
        public static int status = 1;
        private static BookManageDAO bookManageDAO = null;
        private string dbInfo = "Server=localhost;Database=library;Uid=root;Pwd=apmsetup;charset=utf8";
        public static BookManageDAO getInstance()
        {
            if (bookManageDAO == null)
                bookManageDAO = new BookManageDAO();
            return bookManageDAO;
        }

        private BookManageDAO()
        {

        }

        public List<BookManageDTO> getManageList(string search)
        {
            List<BookManageDTO> list = new List<BookManageDTO>();
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);

            string sql = "SELECT bm_idx,c_idx,b_idx,b_name,c_name,bm_takeDate,bm_returnDate,bm_extend,bm_status FROM customer, book_management, book WHERE customer.c_idx = book_management.bm_c_idx AND book_management.bm_b_idx = book.b_idx";
            if (search != "")
                sql += " AND c_name like '" + search + "'";
            try
            {
                mySqlConnection.Open();
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new BookManageDTO(
                            Convert.ToInt32(rdr[0]),
                            Convert.ToInt32(rdr[1]),
                            Convert.ToInt32(rdr[2]),
                            Convert.ToString(rdr[3]),
                            Convert.ToString(rdr[4]),
                            Convert.ToString(rdr[5]),
                            Convert.ToString(rdr[6]),
                            Convert.ToInt32(rdr[7]),
                            Convert.ToInt32(rdr[8])
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

        public bool extendRental(int rental_idx)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);

            string sql = "UPDATE book_management SET bm_extend = bm_extend + 1,bm_returnDate = DATE_ADD(bm_returnDate, INTERVAL 3 DAY) WHERE bm_idx = " + rental_idx;
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

        public bool overdueRelease(int c_idx)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            try
            {
                mySqlConnection.Open();
                string sql = "UPDATE book_management SET bm_status = 1 WHERE bm_c_idx = " + c_idx;
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand.ExecuteNonQuery();

                sql = "DELETE FROM delinquent WHERE d_c_idx = " + c_idx;
                mysqlCommand = new MySqlCommand(sql, mySqlConnection);
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

        public bool addReturnOverdue(int overdueDay, int idx)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);

            string sql = "INSERT INTO delinquent VALUES (" + idx + "," + overdueDay * 1000 + ")";
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

        public bool returnBook(int rental_idx)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);

            string sql = "UPDATE book_management SET bm_status = 1 WHERE bm_idx = " + rental_idx;
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
    }
}
