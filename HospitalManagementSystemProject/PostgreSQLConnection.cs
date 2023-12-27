// This class defined by developer.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql; // for PostgreSQL
using System.Data;
using System.Data.Common;
namespace HospitalManagementSystemProject
{
    internal class PostgreSQLConnection
    {
        public NpgsqlConnection Connection()
        {
            NpgsqlConnection connection = new NpgsqlConnection(@"server=localHost; port=5432; Database=HospitalManagementSystem; user Id=Postgres; password=12345");
            connection.Open();
            return connection;
        }
    }
}
