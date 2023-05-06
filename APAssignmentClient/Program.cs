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

            ///Running Client side
            //ClientDashboard screen = new ClientDashboard();
            //ClientModel clientModel = ClientModel.GetInstance();
            //CourseModel courseModel = CourseModel.GetInstance();
            //BookingModel bookingModel = BookingModel.GetInstance();

            ////Simulate user has login (DEV MODE ONLY) (REMOVE IN FINAL PRODUCT)
            //IDataAccess data = new DataAccess();
            //clientModel.SetClient(data.RetrieveClientInformation(1));
            //ClientDashboardPresenter presenter = new ClientDashboardPresenter(screen, clientModel, courseModel, bookingModel);

            ///Running Admin side
            //AdminDashboard screen = new AdminDashboard();
            //CourseModel courseModel = CourseModel.GetInstance();
            //ClientModel clientModel = ClientModel.GetInstance();
            //StaffModel staffModel = StaffModel.GetInstance();
            //AdminDashboardPresenter presenter = new AdminDashboardPresenter(screen, courseModel, clientModel, staffModel);

            ///Running Login client
            Login screen = new Login();
            AccountModel accountModel = AccountModel.GetInstance();
            ClientModel clientModel = ClientModel.GetInstance();
            LoginPresenter presenter = new LoginPresenter(screen, clientModel, accountModel);

            Application.Run(screen);
        }
    }
}
