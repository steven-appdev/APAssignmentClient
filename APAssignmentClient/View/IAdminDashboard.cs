using APAssignmentClient.Presenter;
using System;
using System.Data;
using System.Windows.Forms;

namespace APAssignmentClient.View
{
    public interface IAdminDashboard
    {
        DataGridView AllCourses { get; }   
        DataGridView AllClients { get; }
        DataGridView AllStaffs { get; }
        Object GetSelectedCourse { get; }
        Object GetSelectedClient { get; }
        Object GetSelectedStaff { get; }
        int GetCourseListCount { get; }
        int GetClientListCount { get; }
        int GetStaffListCount { get; }
        void Register(AdminDashboardPresenter presenter);
        bool DisplayConfirmationMessage(String msg, String title);
        void DisplayErrorMessage(String msg, String title);
        void SetCourseListDataSource(DataTable dt);
        void SetClientListDataSource(DataTable dt);
        void SetStaffListDataSource(DataTable dt);
        void SetCourseButtonsEnabled(bool enabled);
        void SetClientButtonsEnabled(bool enabled);
        void SetStaffButtonsEnabled(bool enabled);
        void CloseForm();
    }
}
