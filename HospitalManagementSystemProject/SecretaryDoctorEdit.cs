using System.Data; // Necessary for DataTable class
using Npgsql; // PostgreSQL library for C#

namespace HospitalManagementSystemProject
{
    public partial class SecretaryDoctorEdit : Form
    {
        public SecretaryDoctorEdit()
        {
            InitializeComponent();
        }

        PostgreSQLConnection connection = new PostgreSQLConnection(); // Connecting to PostgreSQL database

        private void SecretaryDoctorEdit_Load(object sender, EventArgs e)
        {
            // Pulling data from database to dataGridView1
            DataTable dataTable = new DataTable();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("select doctorname as \"Adı\", doctorsurname as \"Soyadı\", doctorbranch as \"Branşı\", doctortc, doctorpassword, doctortitle from doctor order by doctorid asc", connection.Connection());
            dataAdapter.Fill(dataTable);
            dataTable.Columns["doctortc"].ColumnName = "TC Kimlik Numarası";
            dataTable.Columns["doctorpassword"].ColumnName = "Şifre";
            dataTable.Columns["doctortitle"].ColumnName = "Ünvan";
            dataGridView1.DataSource = dataTable;
            connection.Connection().Close();

            // Adding to branch from database to comboBox1
            NpgsqlCommand command = new NpgsqlCommand("select branchname from branch", connection.Connection());
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                comboBox1.Items.Add(dataReader[0]);
            }
            connection.Connection().Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Adding new doctor
            NpgsqlCommand command1 = new NpgsqlCommand("insert into doctor (doctorname, doctorsurname, doctorbranch, doctortc, doctorpassword, doctortitle) values (@p1, @p2, @p3, @p4, @p5, @p6)", connection.Connection());
            command1.Parameters.AddWithValue("@p1", textBox1.Text);
            command1.Parameters.AddWithValue("@p2", textBox2.Text);
            command1.Parameters.AddWithValue("@p3", comboBox1.Text);
            command1.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            command1.Parameters.AddWithValue("@p5", textBox3.Text);
            command1.Parameters.AddWithValue("@p6", comboBox2.Text);
            command1.ExecuteNonQuery();
            dataGridView1.Refresh();
            connection.Connection().Close();
            MessageBox.Show("Doktor kaydı yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Select cell and send data to form components
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Delete doctor
            NpgsqlCommand command2 = new NpgsqlCommand("delete from doctor where doctortc = @p1", connection.Connection());
            command2.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            command2.ExecuteNonQuery();
            dataGridView1.Refresh();
            connection.Connection().Close();
            MessageBox.Show("Doktor kaydı silindi!", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Update doctor
            NpgsqlCommand command3 = new NpgsqlCommand("update doctor set doctorname = @p1, doctorsurname = @p2, doctorbranch = @p3, doctortc = @p4, doctorpassword = @p5, doctortitle = @p6 where doctortc ='" + maskedTextBox1.Text + "'", connection.Connection());
            command3.Parameters.AddWithValue("@p1", textBox1.Text);
            command3.Parameters.AddWithValue("@p2", textBox2.Text);
            command3.Parameters.AddWithValue("@p3", comboBox1.Text);
            command3.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            command3.Parameters.AddWithValue("@p5", textBox3.Text);
            command3.Parameters.AddWithValue("@p6", comboBox2.Text);
            command3.ExecuteNonQuery();
            dataGridView1.Refresh();
            connection.Connection().Close();
            MessageBox.Show("Doktor bilgileri güncellendi!", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
