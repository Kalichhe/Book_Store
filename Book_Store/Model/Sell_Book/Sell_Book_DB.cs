using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Store.CRUD.Add_Book;
using Book_Store.Interface;
using Book_Store.Model.Sell_Book.Sell;


namespace Book_Store.Model.Sell_Book
{
    internal class Sell_Book_DB
    {
        public static bool Sell(Sell_Book_ sell_Book_)
        {
            try
            {
                Connection conn = new Connection();
                string sql = "";
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
