using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgresTest
{
    static class Database
    {
        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User ID=postgres;Password=gwh28DGCMP;Database=Repairs;");
        }
    }
}
