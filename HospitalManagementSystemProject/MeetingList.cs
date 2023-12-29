using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace HospitalManagementSystemProject
{
    public partial class MeetingList : Form
    {
        public MeetingList()
        {
            InitializeComponent();
        }

        PostgreSQLConnection connection = new PostgreSQLConnection();

        private void MeetingList_Load(object sender, EventArgs e)
        {
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
