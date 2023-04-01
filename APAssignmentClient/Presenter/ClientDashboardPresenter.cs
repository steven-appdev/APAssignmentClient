using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public class ClientDashboardPresenter
    {
        private IClientDashboardModel model;
        private IClientDashboard screen;

        public ClientDashboardPresenter(IClientDashboard _screen, IClientDashboardModel _model)
        {
            model = _model;
            screen = _screen;
            screen.Register(this);
        }

        public void ChangeClientName()
        {
            screen.username = model.testname("Test");
        }

        public void ClientDashboard_Activated()
        {
            screen.enrolledCourses.Items.Add("Test");
        }
    }
}
