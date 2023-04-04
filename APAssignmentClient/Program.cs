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
            ClientModel clientModel = new ClientModel();
            CourseModel courseModel = CourseModel.GetInstance();

            //Simulate user has login (DEV MODE ONLY) (REMOVE IN FINAL PRODUCT)
            IDataAccess data = new DataAccess();
            clientModel.SetClient(data.RetrieveClientInformation(1));

            ClientDashboardPresenter presenter = new ClientDashboardPresenter(screen, clientModel, courseModel);
            Application.Run(screen);
        }
    }
}
