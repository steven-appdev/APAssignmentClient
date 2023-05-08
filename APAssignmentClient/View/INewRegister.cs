using APAssignmentClient.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient.View
{
    public interface INewRegister
    {
        String Username { set; get; }
        String Password { set; get; }
        String FullName { set; get; }
        String Address { set; get; }
        String EmailAddress { set; get; }
        String ContactNumber { set; get; }
        void SetRegisterButtonsEnabled(bool enabled);
        void DisplayErrorMessage(String msg, String title);
        void Register(NewRegisterPresenter presenter);
        void CloseForm();
    }
}
