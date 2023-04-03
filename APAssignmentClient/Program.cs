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
            ClientDashboardModel clientModel = new ClientDashboardModel();
            CourseModel courseModel = CourseModel.GetInstance();
            ClientDashboardPresenter presenter = new ClientDashboardPresenter(screen, clientModel, courseModel);
            Application.Run(screen);
        }
    }
}
