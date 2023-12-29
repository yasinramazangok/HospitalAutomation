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
    public partial class DoctorScreen : Form
    {
        public DoctorScreen()
        {
            InitializeComponent();
        }

        public string TCIdentityNumber;

        PostgreSQLConnection connection = new PostgreSQLConnection();

        private void DoctorScreen_Load(object sender, EventArgs e)
        {
            label3.Text = TCIdentityNumber;

            NpgsqlCommand command = new NpgsqlCommand("select doctorname,doctorsurname from doctor where doctortc = @p1", connection.Connection());
            command.Parameters.AddWithValue("@p1", TCIdentityNumber);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                label4.Text = dataReader[0] + " " + dataReader[1];
            }
            connection.Connection().Close();


            DataTable dataTable = new DataTable();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("select * from meeting where meetingdoctor = '" + label4.Text + "'", connection.Connection());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Connection().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorEditInformation doctorEditInformation = new DoctorEditInformation();
            doctorEditInformation.TCIdentityNumber = TCIdentityNumber;
            doctorEditInformation.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Announcements announcements = new Announcements();
            announcements.Show();
        }

    }
}
