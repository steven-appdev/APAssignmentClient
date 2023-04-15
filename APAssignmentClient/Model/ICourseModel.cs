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
        void ReturnToCourseWaitingList(int ClientID, int CourseID);
        List<String> RetrieveEnrolledCourses(int id);
        String RetrieveCourseStatus(int ClientID, int _courseID);
        String[] SplitCourseInformation(String s);
        String RetrieveCourseStartDate(int ClientID, int CourseID);
    }
}
