using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClient
{
    public class ClientDashboardPresenter
    {
        private IClientModel clientModel;
        private ICourseModel courseModel;
        private IClientDashboard screen;

        public ClientDashboardPresenter(IClientDashboard _screen, IClientModel _clientModel, ICourseModel _courseModel)
        {
            clientModel = _clientModel;
            courseModel = _courseModel;
            screen = _screen;
            screen.Register(this);
        }

        public void ClientDashboard_Load()
        {
            screen.username = clientModel.GetClientName();
        }

        public void ClientDashboard_Activated()
        {
            screen.enrolledCourses.Rows.Clear();
            PopulateDataTable();
        }

        public void btnEnrolNew_Click()
        {
            EnrolNewCourse screen = new EnrolNewCourse();
            EnrolNewCoursePresenter presenter = new EnrolNewCoursePresenter(screen, clientModel, courseModel);
            screen.ShowDialog();
        }

        public void btnDropCourse_Click()
        {
            int dropID = RetrieveSelectedID();
            DialogResult result = MessageBox.Show("Do you want to drop the course?", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                courseModel.DropSelectedCourse(clientModel.GetClientID(), dropID);
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

        private void PopulateDataTable()
        {
            List<String> courses = courseModel.RetrieveEnrolledCourses(clientModel.GetClientID());
            screen.enrolledCourses.Rows.Clear();
            if (courses != null)
            {
                foreach (String s in courses)
                {
                    String[] course = courseModel.SplitCourseInformation(s);
                    screen.enrolledCourses.Rows.Add(course[0], course[1], course[2], course[3]);
                }
            }
            screen.enrolledCourses.Sort(screen.enrolledCourses.Columns["id"], ListSortDirection.Ascending);
        }

        private int RetrieveSelectedID()
        {
            return Int32.Parse(screen.GetSelectedValue.ToString());
        }
    }
}
