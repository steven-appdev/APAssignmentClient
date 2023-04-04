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
        int GetClientID();
        String GetClientName();
    }
}
