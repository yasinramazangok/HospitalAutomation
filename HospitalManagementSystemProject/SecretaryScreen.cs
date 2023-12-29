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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalManagementSystemProject
{
    public partial class SecretaryScreen : Form
    {
        public SecretaryScreen()
        {
            InitializeComponent();
        }

        public string secretaryTC;

        PostgreSQLConnection connection = new PostgreSQLConnection();

        private void SecretaryScreen_Load(object sender, EventArgs e)
        {
            label3.Text = secretaryTC;

            NpgsqlCommand command = new NpgsqlCommand("select * from secretary where secretarytc = '" + secretaryTC + "'", connection.Connection());
            NpgsqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                label4.Text = dataReader[1].ToString();
            }
            connection.Connection().Close();


            DataTable dataTable = new DataTable();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("select * from branch order by branchid asc", connection.Connection());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["branchid"].HeaderText = "Id";
            dataGridView1.Columns["branchname"].HeaderText = "Branş Adı";
            connection.Connection().Close();

            DataTable dataTable2 = new DataTable();
            NpgsqlDataAdapter dataAdapter2 = new NpgsqlDataAdapter("select (doctorname || ' ' || doctorsurname) as \"Adı Soyadı\", doctorbranch as \"Branşı\", doctortc, doctorpassword from doctor order by doctorid asc", connection.Connection());
            dataAdapter2.Fill(dataTable2);
            dataTable2.Columns["doctortc"].ColumnName = "TC Kimlik Numarası";
            dataTable2.Columns["doctorpassword"].ColumnName = "Şifre";
            dataGridView2.DataSource = dataTable2;
            connection.Connection().Close();


            NpgsqlCommand command2 = new NpgsqlCommand("select branchname from branch", connection.Connection());
            NpgsqlDataReader dataReader2 = command2.ExecuteReader();
            while (dataReader2.Read())
            {
                comboBox1.Items.Add(dataReader2[0]);
            }
            connection.Connection().Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            NpgsqlCommand command3 = new NpgsqlCommand("select (doctorname || ' ' || doctorsurname) from doctor where doctorbranch = @p1", connection.Connection());
            command3.Parameters.AddWithValue("@p1", comboBox1.Text);
            NpgsqlDataReader dataReader3 = command3.ExecuteReader();
            while (dataReader3.Read())
            {
                comboBox2.Items.Add(dataReader3[0]);
            }
            connection.Connection().Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command4 = new NpgsqlCommand("insert into meeting (meetingdate, meetingtime, meetingbranch, meetingdoctor, meetingstate, meetingpatienttc) values (@p1, @p2, @p3, @p4, @p5, @p6)", connection.Connection());
            command4.Parameters.AddWithValue("@p1", maskedTextBox2.Text);
            command4.Parameters.AddWithValue("@p2", maskedTextBox3.Text);
            command4.Parameters.AddWithValue("@p3", comboBox1.Text);
            command4.Parameters.AddWithValue("@p4", comboBox2.Text);
            command4.Parameters.AddWithValue("@p5", checkBox1.Checked);
            command4.Parameters.AddWithValue("@p6", maskedTextBox1.Text);
            command4.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Randevu oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command5 = new NpgsqlCommand("insert into announcement (announcementtext) values (@p1)", connection.Connection());
            command5.Parameters.AddWithValue("@p1", richTextBox1.Text);
            command5.ExecuteNonQuery();
            connection.Connection().Close();
            MessageBox.Show("Duyuru oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SecretaryDoctorEdit secretaryDoctorEdit = new SecretaryDoctorEdit();
            secretaryDoctorEdit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecretaryBranchEdit secretaryBranchEdit = new SecretaryBranchEdit();
            secretaryBranchEdit.Show();
        }
    }
}
