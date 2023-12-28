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
    public partial class SecretaryLogin : Form
    {
        public SecretaryLogin()
        {
            InitializeComponent();
        }

        PostgreSQLConnection connection = new PostgreSQLConnection();

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand("select * from secretary where secretarytc = @p1 and secretarypassword = @p2", connection.Connection());
            command.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p2", textBox1.Text);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                SecretaryScreen secretaryScreen = new SecretaryScreen();
                secretaryScreen.secretaryTC = maskedTextBox1.Text;
                secretaryScreen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş! Lütfen tekrar deneyiniz.");
            }
            connection.Connection().Close();
        }
    }
}
