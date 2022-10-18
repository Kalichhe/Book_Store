using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store
{
    class Connection
    {
        SqlConnection conn;
        public Connection()
        {
            conn = new SqlConnection("Server=KALICHHE\\SQLEXPRESS;DataBase=Book_Store;integrated security=true");
        }

        public SqlConnection Connect()
        {
            try
            {
                conn.Open();
                return conn;
            }catch(Exception)
            {
                return null;
            }
        }
        public bool Disconnect()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
    }
}