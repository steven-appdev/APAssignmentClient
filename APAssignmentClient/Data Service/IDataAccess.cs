using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public interface IDataAccess
    {
        bool IsCourseEmpty();
        List<Course> RetrieveAllCourses();
        void AddNewCourse(Course course);
    }
}
