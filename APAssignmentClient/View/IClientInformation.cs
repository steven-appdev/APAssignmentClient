using APAssignmentClient.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public interface IClientInformation
    {
        void Register(ClientInformationPresenter presenter);
        String ClientID { get; set; }
        String ClientName { get; set; }
        String ClientAddress { get; set; }
        String ClientEmailAddress { get; set; }
        String ClientContactNumber { get; set; }
        String ClientBill { get; set; }
    }
}
