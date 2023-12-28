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
    public partial class PatientLogin : Form
    {
        public PatientLogin()
        {
            InitializeComponent();
        }

        PostgreSQLConnection connection = new PostgreSQLConnection();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientRegistration patientRegistration = new PatientRegistration();
            patientRegistration.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("select * from patient where patienttc = @p1 and patientpassword = @p2", connection.Connection());
            command.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p2", textBox1.Text);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            if(dataReader.Read())
            {
                PatientScreen patientScreen = new PatientScreen();
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
