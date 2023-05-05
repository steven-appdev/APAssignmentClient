using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using APAssignmentClient.DataService;

namespace APAssignmentClient.Model
{
    public interface IClientModel
    {
        void SetClient(Client client);
        String[] GetClient();
        int ClientID { get; }
        String ClientName { get; }
        String ClientAddress { get; }
        String ClientEmailAddress { get; }
        String ClientContactNumber { get; }
        double ClientBill { get; }
        void UpdateClientBill();
        DataTable RetrieveAllClients();
    }
}
