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
        public int ClientID { get; set; }
        public String ClientName { get; set; }
        public String ClientAddress { get; set; }
        public String ClientEmailAddress { get; set; }
        public String ClientContactNumber { get; set; }
        public double ClientBill { get; set; }
        public bool Deleted { get; set; }
        public Client Client { get; set; }
        public bool Updated { get; set; }
        
        public void DeleteClient()
        {
            Deleted = true;
        }

        public String[] GetClient()
        {
            return new string[] { "1", "Test", "Test", "Test", "07000000000", "0.00" };
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

        public void SetClient(Client client)
        {
            Client = client;
        }

        public void UpdateClientBill()
        {
            Updated = true;
        }
    }
}
