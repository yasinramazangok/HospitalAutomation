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

        public string? doctorTCIdentityNumber; // Doctor screen parameter
        /* 
            C# 8.0'dan önce, tüm referans tipler (örneğin, string, object, class türleri) otomatik olarak nullable idi. 
            Yani, herhangi bir referans tipin değeri null olabilir. 
            Ancak, bu durum bazen null reference hatalarına yol açabiliyordu. 
            C# 8.0 ile birlikte, nullable reference type özelliği getirilerek, referans tiplerin null olup olmadığını açıkça belirtme imkanı sağlandı.
            Bu yüzden burada değişken nullable olarak tanımlanmıştır.
        */

        PostgreSQLConnection connection = new PostgreSQLConnection(); // Connecting to PostgreSQL database

        private void DoctorScreen_Load(object sender, EventArgs e)
        {
            // Pulling data from database to groupBox1

            label3.Text = doctorTCIdentityNumber;

            NpgsqlCommand command = new NpgsqlCommand("select doctorname,doctorsurname from doctor where doctortc = @p1", connection.Connection());
            command.Parameters.AddWithValue("@p1", doctorTCIdentityNumber);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                label4.Text = dataReader[0] + " " + dataReader[1];
            }
            connection.Connection().Close();

            // Pulling data from database to dataGridView1
            DataTable dataTable = new DataTable();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("select * from meeting where meetingdoctor = '" + label4.Text + "'", connection.Connection());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Connection().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Redirect to doctor edit information screen from button1
            DoctorEditInformation doctorEditInformation = new DoctorEditInformation();
            doctorEditInformation.doctorTCIdentityNumber = doctorTCIdentityNumber; // Passing parameters to the doctor edit information screen
            doctorEditInformation.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Redirect to announcements screen from button2

            Announcements announcements = new Announcements();
            announcements.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Hospital Management System exit

            Application.Exit();
        }
    }
}
