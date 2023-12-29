using Npgsql;
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
    public partial class Announcements : Form
    {
        public Announcements()
        {
            InitializeComponent();
        }
        
        PostgreSQLConnection connection = new PostgreSQLConnection();

        private void Announcements_Load(object sender, EventArgs e)
        {
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
