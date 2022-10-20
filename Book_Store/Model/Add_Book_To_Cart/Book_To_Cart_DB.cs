using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Store.Add_Book_To_Cart.Book_To_Cart;

namespace Book_Store.Add_Book_To_Cart
{
    internal class Book_To_Cart_DB
    {
        public static bool Add(Book_To_Cart_ book_To_Cart_)
        {
            try
            {
                Connection conn = new Connection();
                string sql = "INSERT INTO Book_To_Cart VALUES(" + book_To_Cart_.Units + ", " + book_To_Cart_.Code + ")";
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
    }
}
