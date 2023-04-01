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
        private IClientDashboardView screen;

        public ClientDashboardPresenter(IClientDashboardView _screen, IClientDashboardModel _model)
        {
            model = _model;
            screen = _screen;
            screen.register(this);
        }

        public void ChangeClientName()
        {
            screen.username = model.testname("Test");
        }
    }
}
