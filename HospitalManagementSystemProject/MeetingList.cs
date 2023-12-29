using System.Data; // Necessary for DataTable class
using Npgsql; // PostgreSQL library for C#

namespace HospitalManagementSystemProject
{
    public partial class MeetingList : Form
    {
        public MeetingList()
        {
            InitializeComponent();
        }

        PostgreSQLConnection connection = new PostgreSQLConnection(); // Connecting to PostgreSQL database

        private void MeetingList_Load(object sender, EventArgs e)
        {
            // Pulling data from database to dataGridView1
            DataTable dataTable = new DataTable();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("select meetingdate as \"Randevu Tarihi\", meetingtime as \"Randevu Saati\", meetingbranch as \"Branş\", meetingdoctor as \"Doktor Adı\", meetingstate, meetingpatienttc from meeting order by meetingid asc", connection.Connection());
            dataAdapter.Fill(dataTable);
            dataTable.Columns["meetingstate"].ColumnName = "Randevu Durumu";
            dataTable.Columns["meetingpatienttc"].ColumnName = "Hasta TC Kimlik Numarası";
            dataGridView1.DataSource = dataTable;
            connection.Connection().Close();
        }
    }
}
