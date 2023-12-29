using System.Data; // Necessary for DataTable class
using Npgsql; // PostgreSQL library for C#

namespace HospitalManagementSystemProject
{
    public partial class PatientScreen : Form
    {
        public PatientScreen()
        {
            InitializeComponent();
        }

        PostgreSQLConnection connection = new PostgreSQLConnection(); // Connecting to PostgreSQL database

        public string patientScreenTCIdentityNumber; // Patient screen parameter

        private void PatientScreen_Load(object sender, EventArgs e)
        {
            label3.Text = patientScreenTCIdentityNumber;

            // Pulling data from database to form components
            NpgsqlCommand command = new NpgsqlCommand("select patientname, patientsurname from patient where patienttc = @p1", connection.Connection());
            command.Parameters.AddWithValue("@p1", patientScreenTCIdentityNumber);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                label4.Text = dataReader[0] + " " + dataReader[1];
            }
            connection.Connection().Close();

            // Pulling data from database to dataGridView1
            DataTable dataTable = new DataTable();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("select * from meeting where meetingpatienttc::character varying = " + patientScreenTCIdentityNumber, connection.Connection());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            // Pulling data from database to form components
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

            // Pulling data from database to form components
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
            // Pulling data from database to form components
            DataTable dataTable2 = new DataTable();
            NpgsqlDataAdapter dataAdapter2 = new NpgsqlDataAdapter("select * from meeting where meetingbranch = '" + comboBox1.Text + "'", connection.Connection());
            dataAdapter2.Fill(dataTable2);
            dataGridView2.DataSource = dataTable2;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientEditInformation patientEditInformation = new PatientEditInformation();
            patientEditInformation.patientEditInformationTCIdentityNumber = patientScreenTCIdentityNumber;
            patientEditInformation.Show();
        }
    }
}
