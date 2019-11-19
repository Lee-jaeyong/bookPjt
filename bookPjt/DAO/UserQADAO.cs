using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using bookPjt.DTO;
using System.Windows.Forms;

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

        public bool insertUserQ(string id, string title, string content)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            mySqlConnection.Open();
            try
            {
                string sql = "SELECT c_idx FROM customer WHERE c_identy = '" + id + "'";
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                rdr.Read();
                int idx = Convert.ToInt32(rdr[0]);
                rdr.Close();
                sql = "INSERT INTO userquestion VALUES (NULL,'" + title + "','" + content + "',LEFT(NOW(),10),0," + idx + ")";
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

        public AdminAnswerDTO getAnswerInfo(int idx)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            AdminAnswerDTO info = null;
            try
            {
                mySqlConnection.Open();
                string sql = "SELECT * FROM adminanswar WHERE ans_q_idx = " + idx;
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                rdr.Read();
                info = new AdminAnswerDTO(
                        Convert.ToInt32(rdr[0]),
                        rdr[1].ToString(),
                        rdr[2].ToString(),
                        rdr[3].ToString()
                    );
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return info;
        }

        public List<UserQADTO> getUserQAList(string id)
        {
            List<UserQADTO> list = new List<UserQADTO>();
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            try
            {
                mySqlConnection.Open();
                int idx = -1;
                MySqlCommand mysqlCommand;
                MySqlDataReader rdr;
                string sql;
                if (id != "")
                {
                    sql = "SELECT c_idx from customer WHERE c_identy = '" + id + "'";
                    mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                    rdr = mysqlCommand.ExecuteReader();
                    rdr.Read();
                    idx = Convert.ToInt32(rdr[0]);
                    rdr.Close();
                }
                if (idx == -1)
                    sql = "SELECT c_name,q_title,q_content,q_date,IF(q_status=1,'답변 완료','미 답변'),q_idx FROM userquestion, customer WHERE userquestion.q_c_idx = customer.c_idx";
                else
                    sql = "SELECT c_name,q_title,q_content,q_date,IF(q_status=1,'답변 완료','미 답변'),q_idx FROM userquestion, customer WHERE userquestion.q_c_idx = customer.c_idx AND c_idx = " + idx;
                mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                rdr = mysqlCommand.ExecuteReader();
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
                MessageBox.Show(e.Message);
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
