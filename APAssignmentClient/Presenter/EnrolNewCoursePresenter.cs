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
            try
            {
                DataTable courses = courseModel.RetrieveAllCourses(clientModel.ClientID);
                screen.SetNewCourseListDataSource(courses);
            }
            catch(Exception e)
            {
                screen.DisplayErrorMessage(e.Message, "Opps");
                screen.CloseForm();
            }
        }

        public void btnViewCourseDescription_Click()
        {
            courseModel.CourseID = RetrieveSelectedID();

            CourseDescription screen = new CourseDescription();
            CourseDescriptionPresenter presenter = new CourseDescriptionPresenter(screen, clientModel, courseModel, false);
            screen.ShowDialog();
        }

        public void btnEnrol_Click()
        {
            int enrolID = RetrieveSelectedID();
            bool result = screen.DisplayConfirmationMessage("Do you want to enrol the course?", "Enrolment Confirmation");
            if(result == true)
            {
                try
                {
                    courseModel.EnrolSelectedCourse(clientModel.ClientID, enrolID);
                }
                catch (Exception e)
                {
                    screen.DisplayErrorMessage(e.Message, "Opps!");
                }
                screen.CloseForm();
            }
        }

        private int RetrieveSelectedID()
        {
            return Int32.Parse(screen.GetSelectedNewCourse.ToString());
        }
    }
}
