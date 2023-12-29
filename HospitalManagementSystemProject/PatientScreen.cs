using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystemProject
{
    public partial class PatientScreen : Form
    {
        public PatientScreen()
        {
            InitializeComponent();
        }

        public string TCIdentityNumber;

        PostgreSQLConnection connection = new PostgreSQLConnection();

        private void PatientScreen_Load(object sender, EventArgs e)
        {
            label3.Text = TCIdentityNumber;

            NpgsqlCommand command = new NpgsqlCommand("select patientname, patientsurname from patient where patienttc = @p1", connection.Connection());
            command.Parameters.AddWithValue("@p1", TCIdentityNumber);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                label4.Text = dataReader[0] + " " + dataReader[1];
            }
            connection.Connection().Close();


            DataTable dataTable = new DataTable();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("select * from meeting where meetingpatienttc::character varying = " + TCIdentityNumber, connection.Connection());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;


            NpgsqlCommand command2 = new NpgsqlCommand("select branchname from branch", connection.Connection());
            NpgsqlDataReader dataReader2 = command2.ExecuteReader();
            while (dataReader2.Read())
            {
                comboBox1.Items.Add(dataReader2[0]);
            }
            connection.Connection().Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            NpgsqlCommand command3 = new NpgsqlCommand("select doctorname, doctorsurname from doctor where doctorbranch = @p1 ", connection.Connection());
            command3.Parameters.AddWithValue("@p1", comboBox1.Text);
            NpgsqlDataReader dataReader3 = command3.ExecuteReader();
            while (dataReader3.Read())
            {
                comboBox2.Items.Add(dataReader3[0] + " " + dataReader3[1]);
            }
            connection.Connection().Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable2 = new DataTable();
            NpgsqlDataAdapter dataAdapter2 = new NpgsqlDataAdapter("select * from meeting where meetingbranch = '" + comboBox1.Text + "'", connection.Connection());
            dataAdapter2.Fill(dataTable2);
            dataGridView2.DataSource = dataTable2;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientEditInformation patientEditInformation = new PatientEditInformation();
            patientEditInformation.patienttc = TCIdentityNumber;
            patientEditInformation.Show();
        }
    }
}
