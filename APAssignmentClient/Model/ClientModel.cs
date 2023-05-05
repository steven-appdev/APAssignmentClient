using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APAssignmentClient.DataService;

namespace APAssignmentClient.Model
{
    public class ClientModel : IClientModel
    {
        private static ClientModel _instance = null;
        IDataAccess access;
        private Client client;

        private ClientModel()
        {
            access = new DataAccess();
        }

        public static ClientModel GetInstance()
        {
            if(_instance == null)
            {
                _instance = new ClientModel();
            }
            return _instance;
        }

        public void SetClient(Client _client)
        {
            client = _client;
        }

        public String[] GetClient()
        {
            return client.ToStringArray();
        }

        public int ClientID
        {
            get { return client.ClientId; }
        }

        public String ClientName
        {
            get { return client.ClientName; }
        }

        public String ClientAddress
        {
            get { return client.ClientAddress; }
        }

        public String ClientEmailAddress
        {
            get { return client.ClientEmail; }
        }

        public String ClientContactNumber
        {
            get { return client.ClientContact; }
        }

        public double ClientBill
        {
            get { return client.ClientBill; }
        }

        public void UpdateClientBill()
        {
            try
            {
                client.ClientBill = access.RetrieveClientInformation(ClientID).ClientBill;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public DataTable RetrieveAllClients()
        {
            try
            {
                List<Client> retrievedClients = access.RetrieveAllClients();
                DataTable dt = new DataTable();
                dt.Columns.Add("id");
                dt.Columns.Add("name");
                dt.Columns.Add("address");
                dt.Columns.Add("email");
                dt.Columns.Add("contact");
                foreach (Client c in retrievedClients)
                {
                    dt.Rows.Add(c.ClientId.ToString(), c.ClientName, c.ClientAddress, c.ClientEmail, c.ClientContact.ToString());
                }

                return dt;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
