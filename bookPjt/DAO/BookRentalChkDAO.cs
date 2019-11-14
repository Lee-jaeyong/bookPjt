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
    class BookRentalChkDAO
    {
        public static int status = 1;
        private static BookRentalChkDAO bookRentalChkDAO = null;
        private string dbInfo = "Server=localhost;Database=library;Uid=root;Pwd=apmsetup;charset=utf8";
        public static BookRentalChkDAO getInstance()
        {
            if (bookRentalChkDAO == null)
                bookRentalChkDAO = new BookRentalChkDAO();
            return bookRentalChkDAO;
        }

        private BookRentalChkDAO()
        {

        }

        public List<RentalChkDTO> getRentalChkList()
        {
            List<RentalChkDTO> list = new List<RentalChkDTO>();
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);

            string sql = "SELECT b_idx,c_idx,b_img,b_name, c_name, rc_date FROM rentalchk, book, customer WHERE rentalchk.rc_b_idx = book.b_idx AND rentalchk.rc_c_idx = customer.c_idx";
            try
            {
                mySqlConnection.Open();
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new RentalChkDTO(
                            Convert.ToInt32(rdr[0]),
                            Convert.ToInt32(rdr[1]),
                            rdr[2].ToString(),
                            rdr[3].ToString(),
                            rdr[4].ToString(),
                            rdr[5].ToString()
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

        public bool insertRental(int b_idx, int c_idx)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            mySqlConnection.Open();
            MySqlTransaction trans = mySqlConnection.BeginTransaction();
            try
            {
                string sql = "INSERT INTO book_management VALUES (NULL," + b_idx + "," + c_idx + ",left(now(),10),DATE_ADD(left(now(),10), INTERVAL 7 DAY),0)";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand.ExecuteNonQuery();
                sql = "DELETE FROM rentalchk WHERE rc_c_idx = "+c_idx+" AND rc_b_idx = " + b_idx;
                mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand.ExecuteNonQuery();
                mySqlConnection.Close();
                trans.Commit();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool deleteRentalChk(int b_idx, int c_idx)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            mySqlConnection.Open();
            try
            {
                string sql = "DELETE FROM rentalchk WHERE rc_c_idx = " + c_idx + " AND rc_b_idx = " + b_idx;
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
    }
}
