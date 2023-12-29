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
    public partial class SecretaryBranchEdit : Form
    {
        public SecretaryBranchEdit()
        {
            InitializeComponent();
        }

        PostgreSQLConnection connection = new PostgreSQLConnection();   

        private void SecretaryBranchEdit_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("select branchid as \"Id\", branchname as \"Branş Adı\" from branch order by branchid asc", connection.Connection());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Connection().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command1 = new NpgsqlCommand("insert into branch (branchname) values (@p1)", connection.Connection());
            command1.Parameters.AddWithValue("@p1", textBox2.Text);
            command1.ExecuteNonQuery();
            dataGridView1.Refresh();
            connection.Connection().Close();
            MessageBox.Show("Branş eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command2 = new NpgsqlCommand("delete from branch where branchid = @p1", connection.Connection());
            command2.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            command2.ExecuteNonQuery();
            dataGridView1.Refresh();
            connection.Connection().Close();
            MessageBox.Show("Branş kaydı silindi!", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NpgsqlCommand command3 = new NpgsqlCommand("update branch set branchname = @p1 where branchid ='" + textBox1.Text + "'", connection.Connection());
            command3.Parameters.AddWithValue("@p1", textBox2.Text);
            command3.ExecuteNonQuery();
            dataGridView1.Refresh();
            connection.Connection().Close();
            MessageBox.Show("Branş bilgileri güncellendi!", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }    
    }
}
