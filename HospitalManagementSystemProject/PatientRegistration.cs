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
    public partial class PatientRegistration : Form
    {
        public PatientRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PostgreSQLConnection connection = new PostgreSQLConnection();
            NpgsqlCommand command = new NpgsqlCommand("insert into Patient (PatientName, PatientSurname, PatientTC, PatientPhoneNumber,PatientPassword, PatientGender) values (@p1, @p2, @p3, @p4, @p5, @p6", connection.Connection());
        }
    }
}
