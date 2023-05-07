using APAssignmentClient.Presenter;
using APAssignmentClient.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClientUnitTest.Mocs.ScreenMocs
{
    public class ClientDashboardMoc : IClientDashboard
    {
        public String Username { get; set; }
        public DataGridView EnrolledCourses { get; }
        public DataGridView BookedSession { get; }
        public Object GetSelectedValue { get { return 1; } }
        public Object GetSelectedBookingID { get { return 1; } }
        public int GetCourseListCount { get; }
        public int GetBookingListCount { get; }
        public DataTable CourseList { get; set; }
        public DataTable BookingList { get; set; }
        public String ErrorMsg { get; set; }
        public String ErrorTitle { get; set; }

        public void Register(ClientDashboardPresenter presenter) { }
        public bool DisplayConfirmationMessage(String msg, String title) 
        {
            ErrorMsg = msg;
            ErrorTitle = title;
            return true;
        }
        public void DisplayErrorMessage(String msg, String title) { }
        public void SetCourseListDataSource(DataTable dt) 
        {
            CourseList = dt;
        }
        public void SetBookingListDataSource(DataTable dt) 
        { 
            BookingList = dt;
        }
        public void SetCourseButtonsEnabled(bool enabled) { }
        public void SetBookingButtonsEnabled(bool enabled) { }
        public void CloseForm() { }
    }
}
