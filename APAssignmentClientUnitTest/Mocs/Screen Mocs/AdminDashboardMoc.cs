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
    public class AdminDashboardMoc : IAdminDashboard
    {
        public DataGridView AllCourses { get; }
        public DataGridView AllClients { get; }
        public DataGridView AllStaffs { get; }
        public Object GetSelectedCourse { get { return 1; } }
        public Object GetSelectedClient { get { return 1; } }
        public Object GetSelectedStaff { get { return 1; } }
        public int GetCourseListCount { get { return 1; } }
        public int GetClientListCount { get { return 1; } }
        public int GetStaffListCount { get { return 1; } }
        public DataTable Courses { get; set; }
        public DataTable Clients { get; set; }
        public DataTable Staffs { get; set; }
        public String message { get; set; }
        public String msgTitle { get; set; }

        public void Register(AdminDashboardPresenter presenter) { }
        public bool DisplayConfirmationMessage(String msg, String title) 
        {
            message = msg;
            msgTitle = title;
            return true;
        }

        public void DisplayErrorMessage(String msg, String title) { }
        public void SetCourseListDataSource(DataTable dt) 
        {
            Courses = dt;
        }

        public void SetClientListDataSource(DataTable dt) 
        { 
            Clients = dt;
        }

        public void SetStaffListDataSource(DataTable dt) 
        {
            Staffs = dt;
        }

        public void SetCourseButtonsEnabled(bool enabled) { }
        public void SetClientButtonsEnabled(bool enabled) { }
        public void SetStaffButtonsEnabled(bool enabled) { }
        public void CloseForm() { }
    }
}
