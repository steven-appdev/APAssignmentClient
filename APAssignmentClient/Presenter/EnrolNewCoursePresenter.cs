using System;
using APAssignmentClient.View;
using APAssignmentClient.Model;
using System.Data;

namespace APAssignmentClient.Presenter
{
    public class EnrolNewCoursePresenter
    {
        private IEnrolNewCourse screen;
        private IClientModel clientModel;
        private ICourseModel courseModel;

        public EnrolNewCoursePresenter(IEnrolNewCourse _screen, IClientModel _clientModel, ICourseModel _courseModel)
        {
            screen = _screen;
            clientModel = _clientModel;
            courseModel = _courseModel;
            screen.Register(this);
        }

        public void EnrolNewCourse_Load()
        {
            DataTable courses = courseModel.RetrieveAllCourses(clientModel.ClientID);
            screen.availableCourses.DataSource = courses;
        }

        public void btnViewCourseDescription_Click()
        {
            courseModel.CourseID = RetrieveSelectedID();

            CourseDescription screen = new CourseDescription();
            CourseDescriptionPresenter presenter = new CourseDescriptionPresenter(screen, clientModel, courseModel, false);
            screen.ShowDialog();
        }

        public bool btnEnrol_Click()
        {
            int enrolID = RetrieveSelectedID();
            bool result = screen.DisplayConfirmationMessage("Do you want to enrol the course?", "Enrolment Confirmation");
            if(result == true)
            {
                courseModel.EnrolSelectedCourse(clientModel.ClientID, enrolID);
                return true;
            }
            return false;
        }

        private int RetrieveSelectedID()
        {
            return Int32.Parse(screen.GetSelectedNewCourse.ToString());
        }
    }
}
