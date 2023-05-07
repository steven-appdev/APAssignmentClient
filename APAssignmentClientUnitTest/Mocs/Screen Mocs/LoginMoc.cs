using APAssignmentClient.Presenter;
using APAssignmentClient.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClientUnitTest.Mocs.ScreenMocs
{
    public class LoginMoc : ILogin
    {
        public bool btnActivated = false;
        public String errMsg = "";
        public String title = "";
        public bool formHidden = false;

        public String Username { get; set; }
        public String Password { get; set; }

        public void SetAccountButtonsEnabled(bool enabled)
        {
            btnActivated = enabled;
        }

        public void Register(LoginPresenter presenter) { }

        public void DisplayErrorMessage(String _msg, String _title)
        {
            errMsg = _msg;
            title = _title;
        }

        public void HideForm() 
        { 
            formHidden = true;
        }
    }
}
