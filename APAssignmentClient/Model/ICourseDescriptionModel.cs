using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public interface ICourseDescriptionModel
    {
        int CourseID { set; get; }
        Course RetrieveCourseInformation();
    }
}
