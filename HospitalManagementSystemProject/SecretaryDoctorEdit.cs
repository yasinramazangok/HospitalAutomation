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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalManagementSystemProject
{
    public partial class SecretaryDoctorEdit : Form
    {
        public SecretaryDoctorEdit()
        {
            InitializeComponent();
        }

        PostgreSQLConnection connection = new PostgreSQLConnection();

        private void SecretaryDoctorEdit_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("select doctorname as \"Adı\", doctorsurname as \"Soyadı\", doctorbranch as \"Branşı\", doctortc, doctorpassword, doctortitle from doctor order by doctorid asc", connection.Connection());
            dataAdapter.Fill(dataTable);
            dataTable.Columns["doctortc"].ColumnName = "TC Kimlik Numarası";
            dataTable.Columns["doctorpassword"].ColumnName = "Şifre";
            dataTable.Columns["doctortitle"].ColumnName = "Ünvan";
            dataGridView1.DataSource = dataTable;
            connection.Connection().Close();


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
            NpgsqlCommand command1 = new NpgsqlCommand("insert into doctor (doctorname, doctorsurname, doctorbranch, doctortc, doctorpassword, doctortitle) values (@p1, @p2, @p3, @p4, @p5, @p6)", connection.Connection());
            command1.Parameters.AddWithValue("@p1", textBox1.Text);
            command1.Parameters.AddWithValue("@p2", textBox2.Text);
            command1.Parameters.AddWithValue("@p3", comboBox1.Text);
            command1.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            command1.Parameters.AddWithValue("@p5", textBox3.Text);
            command1.Parameters.AddWithValue("@p6", comboBox2.Text);
            command1.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Doktor kaydı yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
        }
    }
}
