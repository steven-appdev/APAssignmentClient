using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public interface ICourseModel
    {
        int CourseID { get; set; }
        List<Course> RetrieveAllCourses();
        void AddNewCourse(String _courseName, String _courseDescription, double _coursePrice);
        String ConvertPrice(double price);
        Course RetrieveCourseInformation();
    }
}
