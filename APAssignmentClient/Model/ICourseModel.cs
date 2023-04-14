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
        List<Course> RetrieveAllCourses(int id);
        void AddNewCourse(String _courseName, String _courseDescription, double _coursePrice, String _courseType, int _courseDuration);
        String ConvertPrice(double price);
        String ConvertDuration(int duration);
        Course RetrieveCourseInformation();
        void EnrolSelectedCourse(int clientID, int courseID);
        void DropSelectedCourse(int clientID, int courseID);
        List<String> RetrieveEnrolledCourses(int id);
        String[] SplitCourseInformation(String s);
    }
}
