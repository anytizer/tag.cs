using configurations;

namespace browser
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

            if (File.Exists(Configs.DATABASE))
            {
                // Browser1: Slim, elegant
                // Browser2: deprecated
                // Browser3: Experimental
                // Browser4: Experimental
                Application.Run(new Browser4());
            }
            else
            {
                MessageBox.Show("Install database first!");
            }
        }
    }
}