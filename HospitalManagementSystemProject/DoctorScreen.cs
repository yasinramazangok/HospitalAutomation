using System.Data; // Necessary for DataTable class
using Npgsql; // PostgreSQL library for C#

namespace HospitalManagementSystemProject
{
    public partial class DoctorScreen : Form
    {
        public DoctorScreen()
        {
            InitializeComponent();
        }

        PostgreSQLConnection connection = new PostgreSQLConnection(); // Connecting to PostgreSQL database

        public string? doctorScreenTCIdentityNumber; // Doctor screen parameter
        /* 
            C# 8.0'dan önce, tüm referans tipler (örneğin, string, object, class türleri) otomatik olarak nullable idi. 
            Yani, herhangi bir referans tipin değeri null olabilir. 
            Ancak, bu durum bazen null reference hatalarına yol açabiliyordu. 
            C# 8.0 ile birlikte, nullable reference type özelliği getirilerek, referans tiplerin null olup olmadığını açıkça belirtme imkanı sağlandı.
            Bu yüzden burada değişken nullable olarak tanımlanmıştır.
        */

        private void DoctorScreen_Load(object sender, EventArgs e)
        {
            label3.Text = doctorScreenTCIdentityNumber;

            // Pulling data from database to groupBox1
            NpgsqlCommand command = new NpgsqlCommand("select doctorname,doctorsurname from doctor where doctortc = @p1", connection.Connection());
            command.Parameters.AddWithValue("@p1", doctorScreenTCIdentityNumber);
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
            doctorEditInformation.doctorEditInformationTCIdentityNumber = doctorScreenTCIdentityNumber; // Passing parameters to the doctor edit information screen
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
