﻿using System;
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

        public bool selectChkRentalCount(string c_id)
        {
            bool chk = true;
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
                sql = "SELECT COUNT(bm_idx) FROM book_management WHERE bm_status = 0 AND bm_c_idx = " + c_idx;
                mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                rdr = mysqlCommand.ExecuteReader();
                rdr.Read();
                if (Convert.ToInt32(rdr[0]) >= 3)
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

        public bool selectCheckReservation(int b_idx)
        {
            bool chk = true;
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            mySqlConnection.Open();
            try
            {
                string sql = "SELECT COUNT(RE_IDX) FROM bookreservation where re_b_idx = " + b_idx;
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                rdr.Read();
                if (Convert.ToInt32(rdr[0]) > 0)
                    chk = false;
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return chk;
        }
        public bool insertRentalChk(string u_id, int b_idx)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            mySqlConnection.Open();
            try
            {
                string sql = "INSERT INTO rentalchk VALUES (" + b_idx + ",'" + u_id + "',LEFT(NOW(),10),NULL)";
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
        public List<RentalChkDTO> getRentalList(string id)
        {
            List<RentalChkDTO> list = new List<RentalChkDTO>();
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);

            string sql = "SELECT b_name,rc_date,rc_idx FROM book, rentalchk WHERE book.b_idx = rentalchk.rc_b_idx AND rc_c_id = '" + id + "'";
            try
            {
                mySqlConnection.Open();
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new RentalChkDTO(
                            rdr[0].ToString(),
                            rdr[1].ToString(),
                            Convert.ToInt32(rdr[2])));
                }
                mySqlConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return list;
        }
        public bool getChkRental(string id, int b_idx)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            mySqlConnection.Open();
            try
            {
                string sql = "select b_stock from book where b_idx = " + b_idx;
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                rdr.Read();
                bool chkStock = Convert.ToInt32(rdr[0]) > 0 ? true : false;
                rdr.Close();
                if (!chkStock)
                    return false;

                sql = "SELECT COUNT(rc_idx) FROM rentalchk WHERE rc_c_id = '" + id + "' AND rc_b_idx = " + b_idx;
                mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                rdr = mysqlCommand.ExecuteReader();
                rdr.Read();
                int count = Convert.ToInt32(rdr[0]);
                rdr.Close();
                mySqlConnection.Close();
                if (count >= 1)
                    return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            return true;
        }
        public List<RentalChkDTO> getRentalChkList()
        {
            List<RentalChkDTO> list = new List<RentalChkDTO>();
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);

            string sql = "SELECT b_idx,c_identy,b_img,b_name, c_name, rc_date FROM rentalchk, book, customer WHERE rentalchk.rc_b_idx = book.b_idx AND rentalchk.rc_c_id = customer.c_identy";
            try
            {
                mySqlConnection.Open();
                MySqlCommand mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader rdr = mysqlCommand.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new RentalChkDTO(
                            Convert.ToInt32(rdr[0]),
                            rdr[1].ToString(),
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

        public bool insertRental(int b_idx, string c_id)
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
                sql = "INSERT INTO book_management VALUES (NULL," + c_idx + "," + b_idx + ",left(now(),10),DATE_ADD(left(now(),10), INTERVAL 7 DAY),0,0)";
                mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand.ExecuteNonQuery();
                sql = "DELETE FROM rentalchk WHERE rc_c_id = '" + c_id + "' AND rc_b_idx = " + b_idx;
                mysqlCommand = new MySqlCommand(sql, mySqlConnection);
                mysqlCommand.ExecuteNonQuery();
                sql = "update book set b_stock = b_stock - 1 where b_idx = " + b_idx;
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
        public bool deleteRentalChk(int b_idx, string c_id)

        {

            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            mySqlConnection.Open();
            try

            {
                string sql = "DELETE FROM rentalchk WHERE rc_c_id = '" + c_id + "' AND rc_b_idx = " + b_idx;
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
        public bool deleteRentalChk(string idx)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            mySqlConnection.Open();
            try
            {
                string sql = "DELETE FROM rentalchk WHERE rc_idx = " + idx;
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

        public bool deleteRentalChkFront(string idx)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(dbInfo);
            mySqlConnection.Open();
            try
            {
                string sql = "DELETE FROM rentalchk WHERE rc_idx = " + idx;
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
