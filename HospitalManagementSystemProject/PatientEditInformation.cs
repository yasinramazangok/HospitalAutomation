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
    public partial class PatientEditInformation : Form
    {
        public PatientEditInformation()
        {
            InitializeComponent();
        }

        public string patienttc;

        private void PatientEditInformation_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = patienttc;
        }
    }
}
