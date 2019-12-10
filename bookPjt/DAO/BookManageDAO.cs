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

        public bool selectChkReturnBook(int c_idx)
        {
            bool chk = true;
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            string sql = "SELECT count(bm_status) FROM book_management where bm_status = 0 AND bm_c_idx = " + c_idx;
            try
            {
                mySqlConnection.Open();
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                rdr.Read();
                if (Convert.ToInt32(rdr[0]) > 0)
                    chk = false;
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return chk;
        }

        public int selectPenalty(int c_idx)
        {
            int penalty = 0;
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            string sql = "SELECT SUM(DATEDIFF(bm_returnDate, now())) from book_management where bm_status = 0 AND bm_returnDate<left(now(),10) AND bm_c_idx = " + c_idx;
            mySqlConnection.Open();
            MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
            MySqlDataReader rdr = mysqlCommand.ExecuteReader();
            try
            {
                rdr.Read();
                penalty = Convert.ToInt32(rdr[0]) * -100;
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                rdr.Close();
                sql = "SELECT d_penalty FROM delinquent WHERE d_c_idx = " + c_idx;
                mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                rdr = mysqlCommand.ExecuteReader();
                rdr.Read();
                penalty = Convert.ToInt32(rdr[0]);
                mySqlConnection.Close();
            }
            return penalty;
        }

        public bool updatePenalty(int originPenalty, int inputPenalty, int c_idx)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            try
            {
                mySqlConnection.Open();
                string sql = "";
                if (originPenalty == inputPenalty)
                    sql = "DELETE FROM delinquent WHERE d_c_idx = " + c_idx;
                else
                    sql = "UPDATE delinquent SET d_penalty = d_penalty - " + inputPenalty + " WHERE d_c_idx = " + c_idx;
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool userChkOverDue(string c_id)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            try
            {
                mySqlConnection.Open();
                string sql = "SELECT c_idx FROM customer WHERE c_identy = '" + c_id + "'";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                rdr.Read();
                int c_idx = Convert.ToInt32(rdr[0]);
                rdr.Close();
                sql = "SELECT count(bm_c_idx) FROM book, book_management WHERE book.b_idx = book_management.bm_b_idx AND bm_status = 0 AND bm_c_idx = " + c_idx + " AND bm_returnDate < left(now(),10)";
                mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                rdr = mysqlCommand.ExecuteReader();
                rdr.Read();
                if (Convert.ToInt32(rdr[0]) > 0)
                    return true;
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }

        public List<BookManageDTO> getUserManageList(string c_id, int status, bool overDue)
        {
            List<BookManageDTO> list = new List<BookManageDTO>();
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            try
            {
                mySqlConnection.Open();
                string sql = "SELECT c_idx FROM customer WHERE c_identy = '" + c_id + "'";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                rdr.Read();
                int c_idx = Convert.ToInt32(rdr[0]);
                rdr.Close();
                sql = "SELECT b_name, bm_takeDate, bm_returnDate, bm_extend, bm_status FROM book, book_management WHERE book.b_idx = book_management.bm_b_idx AND bm_c_idx = " + c_idx + " AND bm_status = " + status;
                if (overDue)
                    sql += " AND bm_returnDate < left(now(),10)";
                mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                rdr = mysqlCommand.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new BookManageDTO(
                            Convert.ToString(rdr[0]),
                            Convert.ToString(rdr[1]),
                            Convert.ToString(rdr[2]),
                            Convert.ToInt32(rdr[3]),
                            Convert.ToInt32(rdr[4])));
                }
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return list;
        }
        public List<BookManageDTO> getManageList(string search)
        {
            List<BookManageDTO> list = new List<BookManageDTO>();
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);

            string sql = "SELECT bm_idx,c_idx,b_idx,b_name,c_name,bm_takeDate,bm_returnDate,bm_extend,bm_status FROM customer, book_management, book WHERE customer.c_idx = book_management.bm_c_idx AND book_management.bm_b_idx = book.b_idx";
            if (search != "")
                sql += " AND c_name like '%" + search + "%'";
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

        public bool addReturnOverdue(int overdueDay, int idx, int c_idx)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);

            string sql = "INSERT INTO delinquent VALUES (" + idx + "," + overdueDay * 100 + "," + c_idx + ")";
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

            try
            {
                mySqlConnection.Open();
                string sql = "UPDATE book_management SET bm_status = 1 WHERE bm_idx = " + rental_idx;
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand.ExecuteNonQuery();
                sql = "update book set b_stock = b_stock + 1 where b_idx in (select bm_b_idx from book_management where bm_idx = " + rental_idx + ")";
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
    }
}
