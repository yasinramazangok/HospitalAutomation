namespace HospitalManagementSystemProject
{
    public partial class SystemLogin : Form
    {
        public SystemLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorLogin doctorLogin = new DoctorLogin();
            doctorLogin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientLogin patientLogin = new PatientLogin();
            patientLogin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SecretaryLogin secretaryLogin = new SecretaryLogin();
            secretaryLogin.Show();
            this.Hide();
        }
    }
}
