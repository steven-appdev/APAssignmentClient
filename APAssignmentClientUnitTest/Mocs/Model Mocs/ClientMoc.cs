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
        public bool Deleted {  get; set; }
        public Client Client { get; set; }

        public void DeleteClient()
        {
            Deleted = true;
        }

        string[] IClientModel.GetClient()
        {
            throw new NotImplementedException();
        }

        public DataTable RetrieveAllClients()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("address");
            dt.Columns.Add("email");
            dt.Columns.Add("contact");
            return dt;
        }

        public Client RetrieveOneClient(int clientID)
        {
            return new Client
            {
                ClientId = 1,
                ClientName = "Test",
                ClientAddress = "Test",
                ClientEmail = "Test",
                ClientContact = "07000000000",
                ClientBill = 0.00
            };
        }

        void IClientModel.SetClient(Client client)
        {
            Client = client;
        }

        void IClientModel.UpdateClientBill()
        {
            throw new NotImplementedException();
        }
    }
}
