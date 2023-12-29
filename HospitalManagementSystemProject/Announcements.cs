using System.Data; // Necessary for DataTable class
using Npgsql; // PostgreSQL library for C#

namespace HospitalManagementSystemProject
{
    public partial class Announcements : Form
    {
        public Announcements()
        {
            InitializeComponent();
        }
        
        PostgreSQLConnection connection = new PostgreSQLConnection(); // Connecting to PostgreSQL database

        private void Announcements_Load(object sender, EventArgs e)
        {
            // Pulling data from database to dataGridView1
            DataTable dataTable = new DataTable();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("select * from announcement order by announcementid asc", connection.Connection());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["announcementid"].HeaderText = "Id";
            dataGridView1.Columns["announcementtext"].HeaderText = "Duyuru Metni";
            connection.Connection().Close();
        }
    }
}
