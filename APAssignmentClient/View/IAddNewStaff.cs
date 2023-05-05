using APAssignmentClient.Presenter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient.View
{
    public interface IAddNewStaff
    {
        String StaffID { get; set; }
        String StaffName { get; set; }
        int StaffCourseTaughtID { get; set; }
        String StaffCourseTaught { get; }
        String StaffSupportSession { get; set; }
        void SetCourseTaughtData(String value, String display, DataTable dt);
        bool DisplayConfirmationMessage(String msg, String title);
        void DisplayErrorMessage(String msg, String title);
        void Register(AddNewStaffPresenter _presenter);
        void CloseForm();
    }
}
