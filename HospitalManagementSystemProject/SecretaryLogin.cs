using Npgsql; // PostgreSQL library for C#

namespace HospitalManagementSystemProject
{
    public partial class SecretaryLogin : Form
    {
        public SecretaryLogin()
        {
            InitializeComponent();
        }

        PostgreSQLConnection connection = new PostgreSQLConnection(); // Connecting to PostgreSQL database

        private void button1_Click(object sender, EventArgs e)
        {
            // Database query for secretary login
            NpgsqlCommand command = new NpgsqlCommand("select * from secretary where secretarytc = @p1 and secretarypassword = @p2", connection.Connection());
            command.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            command.Parameters.AddWithValue("@p2", textBox1.Text);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                SecretaryScreen secretaryScreen = new SecretaryScreen();
                secretaryScreen.secretaryScreenTCIdentityNumber = maskedTextBox1.Text; // Passing parameters to the secretary screen
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
