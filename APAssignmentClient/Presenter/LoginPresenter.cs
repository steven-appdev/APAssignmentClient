using APAssignmentClient.Model;
using APAssignmentClient.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient.Presenter
{
    public class LoginPresenter
    {
        private ILogin screen;
        private IClientModel clientModel;
        private IAccountModel accountModel;

        public LoginPresenter(ILogin _screen, IClientModel _clientModel, IAccountModel _accountModel)
        {
            screen = _screen;
            clientModel = _clientModel;
            accountModel = _accountModel;
            screen.Register(this);
        }

        public void btnLogin_Click()
        {
            screen.SetAccountButtonsEnabled(false);
            if(accountModel.Login(screen.Username, screen.Password))
            {
                Console.WriteLine("Account logged in!");
                if(accountModel.UserType == 1)
                {
                    ClientDashboard screen = new ClientDashboard();
                    ClientModel clientModel = ClientModel.GetInstance();
                    CourseModel courseModel = CourseModel.GetInstance();
                    BookingModel bookingModel = BookingModel.GetInstance();

                    clientModel.SetClient(accountModel.RetrieveClient());

                    ClientDashboardPresenter presenter = new ClientDashboardPresenter(screen, clientModel, courseModel, bookingModel);
                    screen.Show();
                    this.screen.HideForm();
                }
                else if(accountModel.UserType == 2)
                {
                    AdminDashboard screen = new AdminDashboard();
                    CourseModel courseModel = CourseModel.GetInstance();
                    ClientModel clientModel = ClientModel.GetInstance();
                    StaffModel staffModel = StaffModel.GetInstance();
                    AdminDashboardPresenter presenter = new AdminDashboardPresenter(screen, courseModel, clientModel, staffModel);
                    screen.Show();
                    this.screen.HideForm();
                }
            }
            else
            {
                screen.DisplayErrorMessage("Incorrect Username or Password! Please try again!", "Oh no!");
                screen.SetAccountButtonsEnabled(true);
            }
        }

        public void btnRegister_Click()
        {
            //Open register screen
        }
    }
}
