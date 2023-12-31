﻿using Npgsql; // PostgreSQL library for C#

namespace HospitalManagementSystemProject
{
    public partial class PatientEditInformation : Form
    {
        public PatientEditInformation()
        {
            InitializeComponent();
        }

        PostgreSQLConnection connection = new PostgreSQLConnection(); // Connecting to PostgreSQL database

        public string? patientEditInformationTCIdentityNumber; // Patient edit information screen parameter

        private void PatientEditInformation_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = patientEditInformationTCIdentityNumber;

            // Pulling data from database to form components
            NpgsqlCommand command = new NpgsqlCommand("select * from patient where patienttc = @p1", connection.Connection());
            command.Parameters.AddWithValue("@p1", patientEditInformationTCIdentityNumber);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                textBox1.Text = dataReader[1].ToString();
                textBox2.Text = dataReader[2].ToString();
                maskedTextBox2.Text = dataReader[4].ToString();
                comboBox1.Text = dataReader[6].ToString();
                textBox3.Text = dataReader[5].ToString();
            }
            connection.Connection().Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Update patient information in database
            NpgsqlCommand command2 = new NpgsqlCommand("update patient set patientname = @p1, patientsurname = @p2, patienttc = @p3, patientphonenumber = @p4, patientgender = @p5, patientpassword = @p6 where patienttc = '" + patientEditInformationTCIdentityNumber + "'", connection.Connection());
            command2.Parameters.AddWithValue("@p1", textBox1.Text);
            command2.Parameters.AddWithValue("@p2", textBox2.Text);
            command2.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            command2.Parameters.AddWithValue("@p4", maskedTextBox2.Text);
            command2.Parameters.AddWithValue("@p5", comboBox1.Text);
            command2.Parameters.AddWithValue("@p6", textBox3.Text);
            command2.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Hasta bilgileri güncellendi!", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close(); // Patient edit information screen closing when clicked the message box ok button
        }
    }
}
