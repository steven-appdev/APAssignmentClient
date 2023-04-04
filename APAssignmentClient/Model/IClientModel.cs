using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public interface IClientModel
    {
        void SetClient(Client client);
        Client GetClient();
        int ClientID { get; }
        String ClientName { get; }
        String ClientAddress { get; }
        String ClientEmailAddress { get; }
        String ClientContactNumber { get; }
        double ClientBill { get; }
        String ConvertBill(double bill);
    }
}
