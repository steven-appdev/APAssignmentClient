using APAssignmentClient.Data_Service;
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
        private ICourseModel model;

        public EnrolNewCoursePresenter(IEnrolNewCourse _screen, ICourseModel _model)
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
            UpdateSelectedCourseID();

            CourseDescription screen = new CourseDescription();
            CourseDescriptionPresenter presenter = new CourseDescriptionPresenter(screen, model);

            screen.ShowDialog();
        }

        public bool btnEnrol_Click()
        {
            UpdateSelectedCourseID();
            DialogResult result = MessageBox.Show("Do you want to enrol the course?", "Enrolment Confirmation", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                model.EnrolSelectedCourse();
                return true;
            }
            return false;
        }

        private void UpdateSelectedCourseID()
        {
            model.CourseID = Int32.Parse(screen.availableCourses.SelectedRows[0].Cells[0].Value.ToString());
        }
    }
}
