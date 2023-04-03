using APAssignmentClient.Data_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void ChangeClientName()
        {
            screen.username = clientModel.testname("Test");
        }

        public void ClientDashboard_Activated()
        {
            //courseModel.CurrentUser = clientModel.ClientID;
            List<Course> courses = courseModel.RetrieveEnrolledCourses();
            screen.enrolledCourses.Rows.Clear();
            if(courses != null )
            {
                foreach (Course c in courses)
                {
                    screen.enrolledCourses.Rows.Add(c.CourseId.ToString(), c.CourseName.ToString(), "temp placeholder text");
                }
            }
            return;
        }

        public void btnEnrolNew_Click()
        {
            EnrolNewCourse screen = new EnrolNewCourse();
            CourseModel model = CourseModel.GetInstance();
            EnrolNewCoursePresenter presenter = new EnrolNewCoursePresenter(screen, model);
            screen.ShowDialog();
        }
    }
}
