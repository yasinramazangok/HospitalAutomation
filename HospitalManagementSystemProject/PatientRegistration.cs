﻿using System;
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
    public partial class PatientRegistration : Form
    {
        public PatientRegistration()
        {
            InitializeComponent();
        }

        PostgreSQLConnection connection = new PostgreSQLConnection();

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("insert into patient (patientname, patientsurname, patienttc, patientphonenumber,patientpassword, patientgender) values (@p1, @p2, @p3, @p4, @p5, @p6)", connection.Connection());
            command.Parameters.AddWithValue("@p1", textBox1.Text);
            command.Parameters.AddWithValue("@p2", textBox2.Text);
            command.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p4", maskedTextBox2.Text);
            command.Parameters.AddWithValue("@p5", textBox3.Text);
            command.Parameters.AddWithValue("@p6", comboBox1.Text);
            command.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Kaydınız yapılmıştır! Şifreniz : " + textBox3.Text, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
