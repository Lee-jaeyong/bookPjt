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

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
                int joinResult = command.ExecuteNonQuery();

                if (joinResult == 0)
                {
                    connection.Close();
                    return false;
                }
                else
                {
                    connection.Close();
                    return true;
                }
            }catch(Exception e)
            {
                Console.Write("오류");
            }
            return false;
        }

        public bool dupCheck(string id)
        {
                MySqlConnection connection = new MySqlConnection(dbInfo);
                string sql = "select count(*) from customer where c_identy = '"+id+"'";
                try { 
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader dupResult = command.ExecuteReader();
                dupResult.Read();
                int dupCount = int.Parse(dupResult["count(*)"].ToString());
                connection.Close();

                if(dupCount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception e)
            {
                Console.Write("오류");
            }
            return true;


        }

        public string findId(string name,string ph0,string ph1,string ph2)
        {
            MySqlConnection connection = new MySqlConnection(dbInfo);
            string sql = "select c_identy from customer where c_name='" + name + "' and c_phone1='" + ph0 + "' and c_phone2='" + ph1 + "'and c_phone3='" + ph2 + "'";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader findId = command.ExecuteReader();
                findId.Read();
                string result = findId["c_identy"].ToString();
                connection.Close();

                return "ID  :  "+result;

            }
            catch(Exception e)
            {
                Console.Write("오류");
            }

            return "일치하는 정보가 없습니다.";
        }

        public string findPw(string name, string id)
        {
            MySqlConnection connection = new MySqlConnection(dbInfo);
            string sql = "select c_password from customer where c_name='" + name + "' and c_identy='" + id + "'";

            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader findPw = command.ExecuteReader();
                findPw.Read();
                string result = findPw["c_password"].ToString();
                connection.Close();

                return "PASSWORD  :  " + result;

            }
            catch (Exception e)
            {
                Console.Write("오류");
            }

            return "일치하는 정보가 없습니다.";
        }

    }
}
