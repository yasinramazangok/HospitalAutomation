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
            // Redirect to doctor login screen
            DoctorLogin doctorLogin = new DoctorLogin();
            doctorLogin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Redirect to patient login screen
            PatientLogin patientLogin = new PatientLogin();
            patientLogin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Redirect to secretary login screen
            SecretaryLogin secretaryLogin = new SecretaryLogin();
            secretaryLogin.Show();
            this.Hide();
        }
    }
}
