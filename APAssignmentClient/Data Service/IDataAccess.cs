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
        Course RetrieveOneCourse(int courseID);
        void AddNewCourse(Course course);
        void EnrolCourse(int clientID, int courseID);
        void DropCourse(int clientID, int courseID);
        List<Course> RetrieveEnrolledCourses(int clientID);
        CourseClients RetrieveCourseStatus(int clientID, int courseID);
    }
}
