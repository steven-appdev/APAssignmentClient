using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APAssignmentClient.Presenter;

namespace APAssignmentClient.View
{
    public interface INewBooking
    {
        String GetDuration { get; }
        DateTime DateTime { get; }
        String SupportSession { get; set; }
        ComboBox ManagementName { get; }
        ComboBox Duration { get; }
        void Register(NewBookingPresenter _presenter);
        bool DisplayConfirmationMessage(String msg, String title);
        void DisplayErrorMessage(String msg, String title);
        void SetManagementNameData(String value, String display, DataTable dt);
        void CloseForm();
    }
}
