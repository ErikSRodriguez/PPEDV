using Serilog;

namespace ppedv.Personenverwaltung.UI.WinForms
{
    internal static class Program
    {
        public static ILogger Log;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log = new LoggerConfiguration()
                        .WriteTo.File("log.txt", rollingInterval: RollingInterval.Month)
                        .CreateLogger();

            Log.Information("Personenverwaltung gestartet");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}