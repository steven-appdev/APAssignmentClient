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
        String Username { get; }
        String Password { get; }
        String FullName { get; }
        String Address { get; }
        String EmailAddress { get; }
        String ContactNumber { get; }
        void SetRegisterButtonsEnabled(bool enabled);
        void DisplayErrorMessage(String msg, String title);
        void Register(NewRegisterPresenter presenter);
        void CloseForm();
    }
}
