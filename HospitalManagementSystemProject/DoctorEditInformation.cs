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
    public partial class DoctorEditInformation : Form
    {
        public DoctorEditInformation()
        {
            InitializeComponent();
        }

        public string? doctorTCIdentityNumber; // Doctor edit information screen parameter
        /* 
            C# 8.0'dan önce, tüm referans tipler (örneğin, string, object, class türleri) otomatik olarak nullable idi. 
            Yani, herhangi bir referans tipin değeri null olabilir. 
            Ancak, bu durum bazen null reference hatalarına yol açabiliyordu. 
            C# 8.0 ile birlikte, nullable reference type özelliği getirilerek, referans tiplerin null olup olmadığını açıkça belirtme imkanı sağlandı.
            Bu yüzden burada değişken nullable olarak tanımlanmıştır.
        */

        PostgreSQLConnection connection = new PostgreSQLConnection(); // Connecting to PostgreSQL database

        private void DoctorEditInformation_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = doctorTCIdentityNumber; 

            // Pulling data from database to form components
            NpgsqlCommand command = new NpgsqlCommand("select * from doctor where doctortc = '" + doctorTCIdentityNumber + "'", connection.Connection());
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                textBox1.Text = dataReader[1].ToString();
                textBox2.Text = dataReader[2].ToString();
                comboBox1.Text = dataReader[3].ToString();
                maskedTextBox1.Text = dataReader[4].ToString();                
                textBox3.Text = dataReader[5].ToString();
                textBox4.Text = dataReader[6].ToString();
            }
        }
    }
}
