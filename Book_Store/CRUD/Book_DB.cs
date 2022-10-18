using Book_Store.CRUD.Add_Book;
using Book_Store.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store.CRUD
{
    internal class Book_DB
    {
        public static bool Save(Book book)
        {
            try
            {
                Connection conn = new Connection();
                string sql = "INSERT INTO Book VALUES('"+ book.Code + "','"+ book.Name + "','"+ book.Category + "','"+ book.Amount + "','"+ book.Value +"')";
                SqlCommand command = new SqlCommand(sql,conn.Connect());
                int amount = command.ExecuteNonQuery();
                if (amount == 1)
                {
                    conn.Disconnect();
                    return true;
                }
                else
                {
                    conn.Disconnect();
                    return false;
                } 

            }catch(Exception)
            {
                return false;
            }
        }
        public static bool Modify(Book book)
        {
            try
            {
                Connection conn = new Connection();
                string sql = "UPDATE Book SET code='" + book.Code + "',name='" + book.Name + "',category='" + book.Category + "',amount='" + book.Amount + "',value='" + book.Value + "' where code='"+ book.Code +"'";
                SqlCommand command = new SqlCommand(sql, conn.Connect());
                int amount = command.ExecuteNonQuery();
                if (amount == 1)
                {
                    conn.Disconnect();
                    return true;
                }
                else
                {
                    conn.Disconnect();
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Delete(int code)
        {
            try
            {
                Connection conn = new Connection();
                string sql = "DELETE FROM Book where code='" + code + "'";
                SqlCommand command = new SqlCommand(sql, conn.Connect());
                int amount = command.ExecuteNonQuery();
                if (amount == 1)
                {
                    conn.Disconnect();
                    return true;
                }
                else
                {
                    conn.Disconnect();
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Book Validate_Book(int Code)
        {
            try
            {
                Connection conn = new Connection();
                string sql = "SELECT * FROM Book WHERE Code = " + Code + ";";
                SqlCommand command = new SqlCommand(sql, conn.Connect());
                SqlDataReader dataReader = command.ExecuteReader();
                Book book = new Book();
                if (dataReader.Read())
                {
                    book.Code = Convert.ToInt32(dataReader["Code"].ToString());
                    book.Name = dataReader["Name"].ToString();
                    book.Category = dataReader["Category"].ToString();
                    book.Amount = Convert.ToInt32(dataReader["Amount"].ToString());
                    book.Value = Convert.ToInt32(dataReader["Value"].ToString());
                    conn.Disconnect();
                    return book;
                }
                else return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
