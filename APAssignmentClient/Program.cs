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

            Login screen = new Login();
            AccountModel accountModel = AccountModel.GetInstance();
            ClientModel clientModel = ClientModel.GetInstance();
            LoginPresenter presenter = new LoginPresenter(screen, clientModel, accountModel);

            Application.Run(screen);
        }
    }
}
