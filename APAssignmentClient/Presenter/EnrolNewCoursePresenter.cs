using APAssignmentClient.Data_Service;
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
                    screen.availableCourses.Rows.Add(c.CourseId.ToString(), c.CourseName.ToString(), model.ConvertPrice(c.CoursePrice));
                }
            }
        }

        public void btnViewCourseDescription_Click()
        {
            CourseDescription screen = new CourseDescription();
            DataAccess access = new DataAccess();
            CourseDescriptionModel model = new CourseDescriptionModel(access);
            CourseDescriptionPresenter presenter = new CourseDescriptionPresenter(screen, model);
            model.CourseID = Int32.Parse(this.screen.availableCourses.SelectedRows[0].Cells[0].Value.ToString());
            screen.ShowDialog();
        }
    }
}
