using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public String ConvertBill(double bill)
        {
            if (bill % 1 != 0)
            {
                return bill.ToString() + "0";
            }

            return bill.ToString() + ".00";
        }
    }
}
