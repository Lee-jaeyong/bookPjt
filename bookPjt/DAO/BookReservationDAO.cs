using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using bookPjt.DTO;

namespace bookPjt.DAO
{
    class BookReservationDAO
    {
        private static BookReservationDAO bookReservationDAO = null;
        private string dbInfo = "Server=localhost;Database=library;Uid=root;Pwd=apmsetup;charset=utf8";
        public static BookReservationDAO getInstance()
        {
            if (bookReservationDAO == null)
                bookReservationDAO = new BookReservationDAO();
            return bookReservationDAO;
        }

        private BookReservationDAO()
        {

        }

        public List<BookReservationDTO> selectReservation(string id)
        {
            List<BookReservationDTO> list = new List<BookReservationDTO>();
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            mySqlConnection.Open();
            try
            {
                string _sql = "";
                if(id == "")
                    _sql += " AND c_identy = '" + id +"'";
                string sql = "SELECT re_idx,b_idx,c_identy,b_name,c_name,reservationDate from book, customer, bookreservation where book.b_idx = bookreservation.re_b_idx and customer.c_idx = bookreservation.c_idx";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new BookReservationDTO(
                            Convert.ToInt32(rdr[0]),
                            Convert.ToInt32(rdr[1]),
                            rdr[2].ToString(),
                            rdr[3].ToString(),
                            rdr[4].ToString(),
                            rdr[5].ToString()
                        ));
                }
                rdr.Close();
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return list;
            }
            return list;
        }

        public bool insertReservation(string c_id, string b_idx, string date)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            mySqlConnection.Open();
            try
            {
                string sql = "SELECT c_idx FROM customer WHERE c_identy = '" + c_id + "'";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                rdr.Read();
                int c_idx = Convert.ToInt32(rdr[0]);
                rdr.Close();
                sql = "insert into bookReservation values (NULL," + b_idx + "," + c_idx + ",'" + date + "')";
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

        public bool deleteReservation(string re_idx)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            mySqlConnection.Open();
            try
            {
                string sql = "DELETE FROM bookreservation where re_idx = " + re_idx;
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
