using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClient
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ClientDashboard screen = new ClientDashboard();
            ClientDashboardModel model = new ClientDashboardModel();
            ClientDashboardPresenter presenter = new ClientDashboardPresenter(screen, model);
            Application.Run(screen);
        }
    }
}
