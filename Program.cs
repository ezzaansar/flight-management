namespace SE3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = "Server=localhost;Port=3306;User ID=root;Password=password;Database=UFE1_Airlines";
            var databaseService = DatabaseService.Instance;
            databaseService.SetConnectionString(connectionString);

            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}