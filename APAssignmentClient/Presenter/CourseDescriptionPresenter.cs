using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClient
{
    public class CourseDescriptionPresenter
    {
        private ICourseDescription screen;
        private ICourseDescriptionModel model;
        public CourseDescriptionPresenter(ICourseDescription _screen, ICourseDescriptionModel _model)
        {
            screen = _screen;
            model = _model;
            screen.Register(this);
        }

        public void CourseDescription_Load()
        {
            Course course = model.RetrieveCourseInformation();
            screen.CourseID = course.CourseId.ToString();
            screen.CourseTitle = course.CourseName.ToString();
            screen.Description = course.CourseDescription.ToString();
        }
    }
}
