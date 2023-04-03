using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClient
{
    public interface IEnrolNewCourse
    {
        DataGridView availableCourses { get; }
        void Register(EnrolNewCoursePresenter presenter);
    }
}
