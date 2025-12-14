namespace RollandKnow
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();



            UserDatabase.LoadUsers();

            Application.Run(new signupandlogin());
        }
    }
}