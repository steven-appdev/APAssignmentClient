using APAssignmentClient.Presenter;
using APAssignmentClient.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClientUnitTest.Mocs.ScreenMocs
{
    public class ClientInformationMoc : IClientInformation
    {
        public String ClientID { set; get; }
        public String ClientName { set; get; }
        public String ClientAddress { set; get; }
        public String ClientEmailAddress { set; get; }
        public String ClientContactNumber { set; get; }
        public String ClientBill { set; get; }
        public String ErrorMsg { set; get; }
        public String ErrorTitle { set; get; }
        public bool FormClosed { set; get; } = false;

        public void Register(ClientInformationPresenter _presenter) { }
        public void DisplayErrorMessage(String msg, String title)
        {
            ErrorMsg = msg;
            ErrorTitle = title;
        }

        public void CloseForm()
        {
            FormClosed = true;
        }
    }
}
