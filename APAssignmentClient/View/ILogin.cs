using APAssignmentClient.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClient.View
{
    public interface ILogin
    {
        String Username { get; }
        String Password { get; }
        void SetAccountButtonsEnabled(bool enabled);
        void Register(LoginPresenter presenter);
        void DisplayErrorMessage(String msg, String title);
        void HideForm();
    }
}
