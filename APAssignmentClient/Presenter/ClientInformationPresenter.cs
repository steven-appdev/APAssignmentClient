using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Client client = clientModel.GetClient();
            screen.ClientID = client.ClientId.ToString();
            screen.ClientName = client.ClientName;
            screen.ClientAddress = client.ClientAddress;
            screen.ClientEmailAddress = client.ClientEmail;
            screen.ClientContactNumber = client.ClientContact;
        }
    }
}
