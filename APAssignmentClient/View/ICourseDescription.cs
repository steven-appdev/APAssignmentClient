using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public interface ICourseDescription
    {
        String CourseID { get; set; }
        String CourseTitle { get; set; }
        String Description { get; set; }
        void Register(CourseDescriptionPresenter presenter);
    }
}
