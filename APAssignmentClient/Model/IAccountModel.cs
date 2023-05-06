using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APAssignmentClient.DataService;

namespace APAssignmentClient.Model
{
    public interface IAccountModel
    {
        int UserID { get; set; }
        int UserType { get; set; }
        bool Login (String username, String password);
        void Register (String username, String password);
        Client RetrieveClient();
    }
}
