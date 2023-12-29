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

        public string TCIdentityNumber;

        PostgreSQLConnection connection = new PostgreSQLConnection();

        private void DoctorEditInformation_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = TCIdentityNumber;


            NpgsqlCommand command = new NpgsqlCommand("select * from doctor where doctortc = '" + TCIdentityNumber + "'", connection.Connection());
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
