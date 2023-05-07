using APAssignmentClient.Presenter;
using APAssignmentClient.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClientUnitTest.Mocs.ScreenMocs
{
    public class AddNewStaffMoc : IAddNewStaff
    {
        public String StaffID { get; set; }
        public String StaffName { get; set; }
        public int StaffCourseTaughtID { get; set; }
        public String StaffCourseTaught { get; }
        public String StaffSupportSession { get; set; }
        public bool FormClosed { get; set; } = false;
        public DataTable dt { get; set; }

        public void SetCourseTaughtData(String value, String display, DataTable dt)
        {
            this.dt = dt;
        }

        public bool DisplayConfirmationMessage(String msg, String title)
        {
            return false;
        }

        public void DisplayErrorMessage(String msg, String title)
        {

        }

        public void Register(AddNewStaffPresenter _presenter)
        {

        }

        public void CloseForm()
        {
            FormClosed = true;
        }
    }
}
