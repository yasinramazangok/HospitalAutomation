namespace HospitalManagementSystemProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
       
            // System welcome screen 
            SystemWelcomeScreen systemWelcomeScreen = new SystemWelcomeScreen();
            Application.Run(systemWelcomeScreen);

            // System login screen
            SystemLogin systemLogin = new SystemLogin();
            Application.Run(new SystemLogin());
        }
    }
}