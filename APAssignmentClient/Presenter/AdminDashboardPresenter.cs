using System;
using System.Data;
using APAssignmentClient.Model;
using APAssignmentClient.View;

namespace APAssignmentClient.Presenter
{
    public class AdminDashboardPresenter
    {
        private IAdminDashboard screen;
        private ICourseModel course;
        private IClientModel client;
        private IStaffModel staff;
        public AdminDashboardPresenter(IAdminDashboard _screen, ICourseModel _course, IClientModel _client, IStaffModel _staff)
        {
            screen = _screen;
            screen.Register(this);
            course = _course;
            client = _client;
            staff = _staff;
        }

        public void Admin_Dashboard_Load()
        {
            PopulateDataTable();
        }

        public void btnAddCourse_Click()
        {
            AddNewCourse screen = new AddNewCourse();
            CourseModel coursemodel = CourseModel.GetInstance();
            AddNewCoursePresenter presenter = new AddNewCoursePresenter(screen, coursemodel, false);
            screen.ShowDialog();
        }

        public void btnEditCourse_Click()
        {
            course.CourseID = RetrieveSelectedCourseID();

            AddNewCourse screen = new AddNewCourse();
            CourseModel coursemodel = CourseModel.GetInstance();
            AddNewCoursePresenter presenter = new AddNewCoursePresenter(screen, coursemodel, true);
            screen.ShowDialog();
        }

        public void btnViewCourse_Click()
        {
            course.CourseID = RetrieveSelectedCourseID();

            CourseDescription screen = new CourseDescription();
            ClientModel clientModel = ClientModel.GetInstance();
            CourseModel courseModel = CourseModel.GetInstance();
            CourseDescriptionPresenter presenter = new CourseDescriptionPresenter(screen, clientModel, courseModel, false);
            screen.ShowDialog();
        }

        public void btnDeleteCourse_Click()
        {
            course.CourseID = RetrieveSelectedCourseID();

            bool result = screen.DisplayConfirmationMessage("Do you want to delete this course?", "Warning! Are you sure?");
            if (result)
            {
                course.DeleteCourse();
                PopulateDataTable();
            }
        }

        public void Admin_Dashboard_Activated() 
        {
            PopulateDataTable();
        }

        public void dgvAllCourses_DataSourceChanged()
        {
            CheckCourseListRowCount();
        }

        public void dgvAllClients_DataSourceChanged()
        {
            CheckClientListRowCount();
        }

        public void dgvAllStaffs_DataSourceChanged()
        {
            CheckStaffListRowCount();
        }

        private void PopulateDataTable()
        {
            try
            {
                DataTable coursedt = course.RetrieveAllCourses();
                screen.SetCourseListDataSource(coursedt);

                DataTable clientdt = client.RetrieveAllClients();
                screen.SetClientListDataSource(clientdt);

                DataTable staffdt = staff.RetrieveAllStaffs();
                screen.SetStaffListDataSource(staffdt);
            }
            catch (Exception e)
            {
                screen.DisplayErrorMessage(e.Message, "Opps!");
            }
        }

        private void CheckCourseListRowCount()
        {
            if (screen.GetCourseListCount > 0)
            {
                screen.SetCourseButtonsEnabled(true);
            }
            else
            {
                screen.SetCourseButtonsEnabled(false);
            }
        }

        private void CheckClientListRowCount()
        {
            if (screen.GetClientListCount > 0)
            {
                screen.SetClientButtonsEnabled(true);
            }
            else
            {
                screen.SetClientButtonsEnabled(false);
            }
        }

        private void CheckStaffListRowCount()
        {
            if (screen.GetStaffListCount > 0)
            {
                screen.SetStaffButtonsEnabled(true);
            }
            else
            {
                screen.SetStaffButtonsEnabled(false);
            }
        }

        private int RetrieveSelectedCourseID()
        {
            return Int32.Parse(screen.GetSelectedCourse.ToString());
        }
    }

}
