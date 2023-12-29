namespace HospitalManagementSystemProject
{
    public partial class SystemWelcomeScreen : Form
    {
        public SystemWelcomeScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
