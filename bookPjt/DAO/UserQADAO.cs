using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using bookPjt.DTO;

namespace bookPjt.DAO
{
    class UserQADAO
    {
        private static UserQADAO userQADAO = null;
        private string dbInfo = "Server=localhost;Database=library;Uid=root;Pwd=apmsetup;charset=utf8";
        public static UserQADAO getInstance()
        {
            if (userQADAO == null)
                userQADAO = new UserQADAO();
            return userQADAO;
        }

        private UserQADAO()
        {

        }

        public List<UserQADTO> getUserQAList()
        {
            List<UserQADTO> list = new List<UserQADTO>();
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            string sql = "SELECT c_name,q_title,q_content,q_date,IF(q_status=1,'답변 완료','미 답변'),q_c_idx FROM userquestion, customer WHERE userquestion.q_c_idx = customer.c_idx";
            try
            {
                mySqlConnection.Open();
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new UserQADTO(
                            Convert.ToInt32(rdr[5]),
                            rdr[1].ToString(),
                            rdr[2].ToString(),
                            rdr[3].ToString(),
                            rdr[4].ToString(),
                            rdr[0].ToString()
                        ));
                }
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
            }
            return list;
        }

        public bool answerQA(string title, string content, int idx)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            mySqlConnection.Open();
            try
            {
                string sql = "UPDATE userquestion SET q_status = 1 WHERE q_idx = " + idx;
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand.ExecuteNonQuery();
                sql = "INSERT INTO adminanswar VALUES (" + idx + ",'" + title + "','" + content + "',LEFT(NOW(),10))";
                mysqlCommand = new MySqlCommand(sql, mySqlConnection);
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
