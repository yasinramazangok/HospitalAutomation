using Npgsql; // PostgreSQL library for C#

namespace HospitalManagementSystemProject
{
    public partial class PatientLogin : Form
    {
        public PatientLogin()
        {
            InitializeComponent();
        }

        PostgreSQLConnection connection = new PostgreSQLConnection(); // Connecting to PostgreSQL database

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Patient registration screen showing
            PatientRegistration patientRegistration = new PatientRegistration();
            patientRegistration.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Database query for patient login
            NpgsqlCommand command = new NpgsqlCommand("select * from patient where patienttc = @p1 and patientpassword = @p2", connection.Connection());
            command.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p2", textBox1.Text);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            if(dataReader.Read())
            {
                PatientScreen patientScreen = new PatientScreen();
                patientScreen.patientScreenTCIdentityNumber = maskedTextBox1.Text; // Passing parameters to the patient screen
                patientScreen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş! Lütfen tekrar deneyiniz.");
            }
        }
    }
}
