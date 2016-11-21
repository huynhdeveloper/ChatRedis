using System;
using System.Windows.Forms;

namespace RedisChatClient
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Json.Server config = new Json.Server();
            ///Pre-config
            config.Instance = "localhost";
            config.TargetingDB = 0;
            ///Config
            Clients.Connection.Init(config);
            Forms.FormController.Init();
            Forms.FormController.getInstance().getForm("SignIn").Toggle();
            ///AppStart
            Application.Run();
        }
    }
}