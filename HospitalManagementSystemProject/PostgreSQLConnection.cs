// This class defined by developer.
using Npgsql; // PostgreSQL library for C#

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
