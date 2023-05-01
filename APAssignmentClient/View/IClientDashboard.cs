using APAssignmentClient.Presenter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClient.View
{
    public interface IClientDashboard
    {
        String Username { get; set; }
        DataGridView EnrolledCourses { get; }
        DataGridView BookedSession { get; }
        Object GetSelectedValue { get; }
        Object GetSelectedBookingID { get; }
        int GetCourseListCount { get; }
        int GetBookingListCount { get; }
        void Register(ClientDashboardPresenter presenter);
        bool DisplayConfirmationMessage(String msg, String title);
        void SetCourseListDataSource(DataTable dt);
        void SetBookingListDataSource(DataTable dt);
        void SetCourseButtonsEnabled(bool enabled);
        void SetBookingButtonsEnabled(bool enabled);
    }
}
