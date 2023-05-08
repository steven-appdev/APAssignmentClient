using APAssignmentClient.Presenter;
using APAssignmentClient.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClientUnitTest.Mocs.Screen_Mocs
{
    public class NewRegisterMoc : INewRegister
    {
        public String Username { set; get; }
        public String Password { set; get; }
        public String FullName { set; get; }
        public String Address { set; get; }
        public String EmailAddress { set; get; }
        public String ContactNumber { set; get; }
        public String Message { get; set; }
        public String MessageTitle { get; set; }
        public bool FormClosed { get; set; } = false;
        public bool RegisterButtonEnabled { get; set; } = true;
        public void SetRegisterButtonsEnabled(bool enabled)
        {
            RegisterButtonEnabled = enabled;
        }

        public void DisplayErrorMessage(String msg, String title)
        {
            Message = msg;
            MessageTitle = title;
        }

        public void Register(NewRegisterPresenter _presenter){}

        public void CloseForm()
        {
            FormClosed = true;
        }
    }
}
