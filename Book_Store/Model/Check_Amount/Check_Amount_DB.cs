using Book_Store.CRUD.Add_Book;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store.Check_Amount
{
    internal class Check_Amount_DB
    {
        public static Book Check(int code)
        {
            try
            {
                Connection conn = new Connection();
                string sql = "SELECT Amount FROM Book WHERE Code = " + code + ";";
                SqlCommand command = new SqlCommand(sql, conn.Connect());
                SqlDataReader dataReader = command.ExecuteReader();
                Book book = new Book();
                if (dataReader.Read())
                {
                    book.Amount = Convert.ToInt32(dataReader["Amount"].ToString());
                    return book;
                }else return null;

            }catch(Exception)
            {
                return null;
            }
        }
    }
}
