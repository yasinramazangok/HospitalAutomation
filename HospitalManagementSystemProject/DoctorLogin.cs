﻿using Npgsql; // PostgreSQL library for C#

namespace HospitalManagementSystemProject
{
    public partial class DoctorLogin : Form
    {
        public DoctorLogin()
        {
            InitializeComponent();
        }

        PostgreSQLConnection connection = new PostgreSQLConnection(); // Connecting to PostgreSQL database

        private void button1_Click(object sender, EventArgs e)
        {
            // Database query for doctor login
            NpgsqlCommand command = new NpgsqlCommand("select * from doctor where doctortc = @p1 and doctorpassword = @p2", connection.Connection());
            command.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p2", textBox1.Text);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                DoctorScreen doctorScreen = new DoctorScreen();
                doctorScreen.doctorScreenTCIdentityNumber = maskedTextBox1.Text; // Passing parameters to the doctor screen
                doctorScreen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş! Lütfen tekrar deneyiniz.");
            }
        }
    }
}
