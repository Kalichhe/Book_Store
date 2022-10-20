using Book_Store.CRUD.Add_Book;
using Book_Store.Guarantor.Guarantor_1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store
{
    internal class Guarantor_DB
    {
        public static bool SaveGuarantor(Guarantor_ guarantor_)
        {
            try
            {
                Connection conn = new Connection();
                string sql = "INSERT INTO Guarantor VALUES(" + guarantor_.Cedula + ", '"+ guarantor_.Name +"', "+guarantor_.Debt+")";
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
            }catch (Exception)
            {
                return false;
            }

        }
    }
}
