using System.Runtime.InteropServices;

namespace ProcessExplorer.WinForms.WinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm());
            }
            else
            {
                return;
            }
        }
    }
}