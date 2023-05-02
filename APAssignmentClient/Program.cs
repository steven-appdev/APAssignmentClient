using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using APAssignmentClient.View;
using APAssignmentClient.Presenter;
using APAssignmentClient.Model;
using APAssignmentClient.DataService;

namespace APAssignmentClient
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ClientDashboard screen = new ClientDashboard();
            ClientModel clientModel = ClientModel.GetInstance();
            CourseModel courseModel = CourseModel.GetInstance();
            BookingModel bookingModel = BookingModel.GetInstance();

            //Simulate user has login (DEV MODE ONLY) (REMOVE IN FINAL PRODUCT)
            IDataAccess data = new DataAccess();
            clientModel.SetClient(data.RetrieveClientInformation(1));

            ClientDashboardPresenter presenter = new ClientDashboardPresenter(screen, clientModel, courseModel, bookingModel);
            Application.Run(screen);
        }
    }
}
