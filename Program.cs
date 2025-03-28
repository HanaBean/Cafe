using System.Diagnostics;

namespace Cafe
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
            Process[] Proc = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            if (Proc.Length > 1)
            {
                MessageBox.Show("프로그램이 실행중 입니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            (new LoginView()).Show();
            Application.Run();
        }
    }
}