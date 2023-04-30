using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APAssignmentClient.View;
using APAssignmentClient.Model;
using System.Windows.Forms.VisualStyles;

namespace APAssignmentClient.Presenter
{
    public class ClientInformationPresenter
    {
        private IClientInformation screen;
        private IClientModel clientModel;

        public ClientInformationPresenter(IClientInformation _screen, IClientModel _clientModel)
        {
            screen = _screen;
            clientModel = _clientModel;
            screen.Register(this);
            PopulateClientInformation();
        }

        private void PopulateClientInformation()
        {
            String[] client = clientModel.GetClient();
            screen.ClientID = client[0];
            screen.ClientName = client[1];
            screen.ClientAddress = client[2];
            screen.ClientEmailAddress = client[3];
            screen.ClientContactNumber = client[4];
            screen.ClientBill = client[5];
        }
    }
}
