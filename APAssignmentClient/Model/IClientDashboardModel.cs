using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public interface IClientDashboardModel
    {
        int ClientID { set; get; }
        string testname(String name); 
    }
}
