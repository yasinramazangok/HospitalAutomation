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

namespace HospitalManagementSystemProject
{
    public partial class SecretaryScreen : Form
    {
        public SecretaryScreen()
        {
            InitializeComponent();
        }

        public string secretaryTC;

        PostgreSQLConnection connection = new PostgreSQLConnection();

        private void SecretaryScreen_Load(object sender, EventArgs e)
        {
            label3.Text = secretaryTC;

            NpgsqlCommand command = new NpgsqlCommand("select * from secretary where secretarytc = '" + secretaryTC + "'", connection.Connection());
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                label4.Text = dataReader[1].ToString();
            }
            connection.Connection().Close();


            DataTable dataTable = new DataTable();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("select * from branch", connection.Connection());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
