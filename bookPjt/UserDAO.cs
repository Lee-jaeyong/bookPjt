using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BookManagement
{
    class UserDAO
    {
        //MySqlConnection connection = new MySqlConnection("Server=localhost;Database=library;Uid=root;Pwd=apmsetup;");

        private static UserDAO userDAO = null;
        private string dbInfo = "Server=localhost;Database=library;Uid=root;Pwd=apmsetup;charset=utf8";
        public static UserDAO getInstance()
        {
            if (userDAO == null)
                userDAO = new UserDAO();
            return userDAO;
        }

        private UserDAO()
        {

        }

        public bool userLogin(string id,string pw)
        {
            MySqlConnection connection = new MySqlConnection(dbInfo);

            string sql = "select count(c_idx) from customer where c_identy = '" + id + "' and c_password = '" + pw + "'";
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader loginRe = command.ExecuteReader();

                loginRe.Read();
                int loginCount = int.Parse(loginRe["count(c_idx)"].ToString());
                connection.Close();
                if (loginCount > 0)
                {
                    return true;//로그인성공
                }
                else
                {
                    return false;//로그인실패
                }
                
            }
            catch(Exception e)
            {
                Console.Write("오류");
            }
            return false;
            
        }

        public bool joinDB(string name,string ph1,string ph2,string ph3,string id,string pw)
        {
            MySqlConnection connection = new MySqlConnection(dbInfo);
            string sql = "insert customer values(NULL,'"+name+"','"+ph1+"','"+ph2+"','"+ph3+"','"+id+"','"+pw+"')";

            connection.Open();
            MySqlCommand command = new MySqlCommand(sql, connection);
            int joinResult = command.ExecuteNonQuery();

            if(joinResult == 0)
            {
                connection.Close();
                return false;
            }
            else
            {
                connection.Close();
                return true;
            }
            
        }

        public int dupCheck(string id)
        {
            MySqlConnection connection = new MySqlConnection(dbInfo);
            string sql = "";

            connection.Open();
            MySqlCommand command = new MySqlCommand(sql, connection);
            int joinResult = command.ExecuteNonQuery();

            return 0;
        }

    }
}
