using APAssignmentClient.DataService;
using APAssignmentClient.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClientUnitTest.Mocs.ModelMocs
{
    public class ClientMoc : IClientModel
    {
        int IClientModel.ClientID => throw new NotImplementedException();

        string IClientModel.ClientName => throw new NotImplementedException();

        string IClientModel.ClientAddress => throw new NotImplementedException();

        string IClientModel.ClientEmailAddress => throw new NotImplementedException();

        string IClientModel.ClientContactNumber => throw new NotImplementedException();

        double IClientModel.ClientBill => throw new NotImplementedException();

        void IClientModel.DeleteClient()
        {
            throw new NotImplementedException();
        }

        string[] IClientModel.GetClient()
        {
            throw new NotImplementedException();
        }

        DataTable IClientModel.RetrieveAllClients()
        {
            throw new NotImplementedException();
        }

        Client IClientModel.RetrieveOneClient(int clientID)
        {
            throw new NotImplementedException();
        }

        void IClientModel.SetClient(Client client)
        {
            throw new NotImplementedException();
        }

        void IClientModel.UpdateClientBill()
        {
            throw new NotImplementedException();
        }
    }
}
