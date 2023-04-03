using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClient
{
    public class ClientDashboardPresenter
    {
        private IClientDashboardModel clientModel;
        private ICourseModel courseModel;
        private IClientDashboard screen;

        public ClientDashboardPresenter(IClientDashboard _screen, IClientDashboardModel _clientModel, ICourseModel _courseModel)
        {
            clientModel = _clientModel;
            courseModel = _courseModel;
            screen = _screen;
            screen.Register(this);
        }

        public void ClientDashboard_Load()
        {
            screen.username = clientModel.testname("Test");
        }

        public void ClientDashboard_Activated()
        {
            //courseModel.CurrentUser = clientModel.ClientID;
            screen.enrolledCourses.Rows.Clear();
            PopulateDataTable();
        }

        public void btnEnrolNew_Click()
        {
            EnrolNewCourse screen = new EnrolNewCourse();
            CourseModel model = CourseModel.GetInstance();
            EnrolNewCoursePresenter presenter = new EnrolNewCoursePresenter(screen, model);
            screen.ShowDialog();
        }

        public void btnDropCourse_Click()
        {
            UpdateSelectedCourseID();
            DialogResult result = MessageBox.Show("Do you want to drop the course?", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                courseModel.DropSelectedCourse();
                PopulateDataTable();
            }
        }

        public void dgvEnrolledCourses_RowsAdded()
        {
            if(screen.dropCourse == false)
            {
                screen.dropCourse = true;
            }
        }

        public void dgvEnrolledCourses_RowsRemoved()
        {
            if (screen.dropCourse == true)
            {
                screen.dropCourse = false;
            }
        }

        private void UpdateSelectedCourseID()
        {
            courseModel.CourseID = Int32.Parse(screen.enrolledCourses.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void PopulateDataTable()
        {
            List<String> courses = courseModel.RetrieveEnrolledCourses();
            screen.enrolledCourses.Rows.Clear();
            if (courses != null)
            {
                foreach (String s in courses)
                {
                    String[] course = courseModel.SplitCourseInformation(s);
                    screen.enrolledCourses.Rows.Add(course[0], course[1], course[2]);
                }
            }
        }
    }
}
