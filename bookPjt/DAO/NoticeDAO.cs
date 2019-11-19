using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using bookPjt.DTO;

namespace bookPjt.DAO
{
    class NoticeDAO
    {
        private static NoticeDAO noticeDAO = null;
        private string dbInfo = "Server=localhost;Database=library;Uid=root;Pwd=apmsetup;charset=utf8";
        public static NoticeDAO getInstance()
        {
            if (noticeDAO == null)
                noticeDAO = new NoticeDAO();
            return noticeDAO;
        }

        private NoticeDAO()
        {

        }

        public List<NoticeDTO> getNoticeList()
        {
            List<NoticeDTO> list = new List<NoticeDTO>();
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            string sql = "SELECT * FROM noticeboard";
            try
            {
                mySqlConnection.Open();
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new NoticeDTO(
                            Convert.ToInt32(rdr[4]),
                            rdr[0].ToString(),
                            rdr[1].ToString(),
                            rdr[2].ToString(),
                            Convert.ToInt32(rdr[3])
                        ));
                }
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
            }
            return list;
        }

        public bool deleteNotice(int idx)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            mySqlConnection.Open();
            try
            {
                string sql = "delete from noticeboard where no_idx = " + idx;
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

        public bool updateNotice(string title, string content, int idx)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            mySqlConnection.Open();
            try
            {
                string sql = "UPDATE noticeboard SET no_title = '" + title + "', no_content = '" + content + "' WHERE no_idx = " + idx;
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

        public bool insertNotice(string title, string content)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            mySqlConnection.Open();
            try
            {
                string sql = "INSERT INTO noticeboard VALUES ('" + title + "','" + content + "',LEFT(NOW(),10),0,NULL)";
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
