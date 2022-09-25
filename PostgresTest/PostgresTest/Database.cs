using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PostgresTest
{
    static class Database
    {
        public static NpgsqlConnection GetConnection()
        {
            string s = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            return new NpgsqlConnection(s);
        }
    }
}
