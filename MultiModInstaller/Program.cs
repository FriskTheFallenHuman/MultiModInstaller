using Steamworks;
using System;
using System.Windows.Forms;

namespace MultiModInstaller
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindows());
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            SteamClient.Shutdown();
        }
    }
}
