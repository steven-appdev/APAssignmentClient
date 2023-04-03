using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public class ClientDashboardModel : IClientDashboardModel
    {
        private int _clientID;
        public int ClientID
        {
            set { _clientID = value; }
            get { return _clientID; }
        }
        public string testname(String name)
        {
            return name;
        }
    }
}
