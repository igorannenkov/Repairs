using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace PostgresTest
{
    static class Database
    {
        public static NpgsqlConnection GetConnection()
        {
            string s = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString + "User ID ="+ Credentials.UserID +";" + "Password = "+ Credentials.Password+";";
            return new NpgsqlConnection(s);
        }
        public static bool TestConnection()
        {
            try
            {
                using (NpgsqlConnection connection = Database.GetConnection())
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception)
            {
                return false;
                //MessageBox.Show(ex.Message);

            }
        }
    }
}
