using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APAssignmentClient.Presenter;

namespace APAssignmentClient.View
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
        void DisplayErrorMessage(String msg, String title);
        void CloseForm();
    }
}
