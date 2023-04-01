using APAssignmentClient.Model;
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
        private IEnrollNewCourseModel model;

        public EnrolNewCoursePresenter(IEnrolNewCourse _screen, IEnrollNewCourseModel _model)
        {
            screen = _screen;
            model = _model;
            screen.Register(this);
        }

        public void EnrolNewCourse_Load()
        {
            List<Course> courses = model.RetrieveAllCourses();
            if(courses == null)
            {
                MessageBox.Show("No data retrieved!");
            }
            else
            {
                foreach(Course c in courses)
                {
                    screen.availableCourses.Items.Add(c.courseName.ToString() + " (£" + c.coursePrice.ToString() + ")");
                }
            }
        }
    }
}
