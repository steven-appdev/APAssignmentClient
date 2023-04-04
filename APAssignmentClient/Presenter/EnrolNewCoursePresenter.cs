using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClient
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
            List<Course> courses = courseModel.RetrieveAllCourses(clientModel.ClientID);
            if(courses == null)
            {
                MessageBox.Show("No data retrieved!");
            }
            else
            {
                foreach(Course c in courses)
                {
                    screen.availableCourses.Rows.Add(c.CourseId.ToString(), c.CourseName, c.CourseType, courseModel.ConvertDuration(c.CourseDuration), courseModel.ConvertPrice(c.CoursePrice));
                }
            }
        }

        public void btnViewCourseDescription_Click()
        {
            courseModel.CourseID = RetrieveSelectedID();

            CourseDescription screen = new CourseDescription();
            CourseDescriptionPresenter presenter = new CourseDescriptionPresenter(screen, courseModel);

            screen.ShowDialog();
        }

        public bool btnEnrol_Click()
        {
            int enrolID = RetrieveSelectedID();
            DialogResult result = MessageBox.Show("Do you want to enrol the course?", "Enrolment Confirmation", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
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
