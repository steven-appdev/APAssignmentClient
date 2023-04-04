using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public class ClientModel : IClientModel
    {
        private Client client;
        public void SetClient(Client _client)
        {
            client = _client;
        }

        public Client GetClient()
        {
            return client;
        }

        public int GetClientID()
        {
            return client.ClientId;
        }

        public String GetClientName()
        {
            return client.ClientName;
        }
    }
}
