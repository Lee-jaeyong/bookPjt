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

        public List<BookManageDTO> getManageList()
        {
            List<BookManageDTO> list = new List<BookManageDTO>();
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);

            string sql = "SELECT c_idx,b_idx,b_name,c_name,bm_takeDate,bm_returnDate,bm_extend FROM customer, book_management, book WHERE customer.c_idx = book_management.bm_c_idx AND book_management.bm_b_idx = book.b_idx";
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
                            Convert.ToString(rdr[2]),
                            Convert.ToString(rdr[3]),
                            Convert.ToString(rdr[4]),
                            Convert.ToString(rdr[5]),
                            Convert.ToInt32(rdr[6])
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
    }
}
