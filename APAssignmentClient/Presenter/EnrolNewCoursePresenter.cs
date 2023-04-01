using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public class EnrolNewCoursePresenter
    {
        private IEnrolNewCourse screen;

        public EnrolNewCoursePresenter(IEnrolNewCourse _screen)
        {
            screen = _screen;
            screen.Register(this);
        }
    }
}
