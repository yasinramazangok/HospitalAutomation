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
            NpgsqlConnection connection = new NpgsqlConnection(@"server=localhost; port=5432; Database=HospitalManagementSystem; user Id=postgres; password=000000");
            connection.Open();
            return connection;
        }
    }
}
