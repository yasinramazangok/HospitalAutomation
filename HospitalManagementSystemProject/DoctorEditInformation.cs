using Npgsql; // PostgreSQL library for C#

namespace HospitalManagementSystemProject
{
    public partial class DoctorEditInformation : Form
    {
        public DoctorEditInformation()
        {
            InitializeComponent();
        }

        PostgreSQLConnection connection = new PostgreSQLConnection(); // Connecting to PostgreSQL database

        public string? doctorEditInformationTCIdentityNumber; // Doctor edit information screen parameter
        /* 
            C# 8.0'dan önce, tüm referans tipler (örneğin, string, object, class türleri) otomatik olarak nullable idi. 
            Yani, herhangi bir referans tipin değeri null olabilir. 
            Ancak, bu durum bazen null reference hatalarına yol açabiliyordu. 
            C# 8.0 ile birlikte, nullable reference type özelliği getirilerek, referans tiplerin null olup olmadığını açıkça belirtme imkanı sağlandı.
            Bu yüzden burada değişken nullable olarak tanımlanmıştır.
        */

        private void DoctorEditInformation_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = doctorEditInformationTCIdentityNumber;

            // Pulling data from database to form components
            NpgsqlCommand command = new NpgsqlCommand("select * from doctor where doctortc = '" + doctorEditInformationTCIdentityNumber + "'", connection.Connection());
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                textBox1.Text = dataReader[1].ToString();
                textBox2.Text = dataReader[2].ToString();
                comboBox1.Text = dataReader[3].ToString();
                maskedTextBox1.Text = dataReader[4].ToString();
                textBox3.Text = dataReader[5].ToString();
                comboBox2.Text = dataReader[6].ToString();
            }

            // Adding branches to comboBox1
            NpgsqlCommand command2 = new NpgsqlCommand("select branchname from branch order by branchid asc", connection.Connection());
            NpgsqlDataReader dataReader2 = command2.ExecuteReader();
            while (dataReader2.Read())
            {
                comboBox1.Items.Add(dataReader2[0]);
            }
            connection.Connection().Close();

            // Adding doctor titles to comboBox2
            NpgsqlCommand command3 = new NpgsqlCommand("select titlename from title order by titleid desc", connection.Connection());
            NpgsqlDataReader dataReader3 = command3.ExecuteReader();
            while (dataReader3.Read())
            {
                comboBox2.Items.Add(dataReader3[0]);
            }
            connection.Connection().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Update doctor information in database
            NpgsqlCommand command2 = new NpgsqlCommand("update doctor set doctorname = @p1, doctorsurname = @p2, doctorbranch = @p3, doctortc = @p4, doctorpassword = @p5, doctortitle = @p6 where doctortc = '" + doctorEditInformationTCIdentityNumber + "'", connection.Connection());
            command2.Parameters.AddWithValue("@p1", textBox1.Text);
            command2.Parameters.AddWithValue("@p2", textBox2.Text);
            command2.Parameters.AddWithValue("@p3", comboBox1.Text);
            command2.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            command2.Parameters.AddWithValue("@p5", textBox3.Text);
            command2.Parameters.AddWithValue("@p6", comboBox2.Text);
            command2.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Doktor bilgileri güncellendi!", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close(); // Doctor edit information screen closing when clicked the message box ok button
        }
    }
}
