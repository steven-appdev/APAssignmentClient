using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APAssignmentClient.DataService;

namespace APAssignmentClient.Model
{
    public interface ICourseModel
    {
        int CourseID { get; set; }
        DataTable RetrieveAllCourses();
        DataTable RetrieveEnrollableCourses(int id);
        void AddNewCourse(String _courseName, String _courseDescription, double _coursePrice, String _courseType, int _courseDuration);
        void EditCourse(int _courseID, String _courseName, String _courseDescription, double _coursePrice, String _courseType, int _courseDuration);
        void DeleteCourse();
        String[] RetrieveCourseInformation();
        void EnrolSelectedCourse(int clientID, int courseID);
        void DropSelectedCourse(int clientID, int courseID);
        void ReturnToCourseWaitingList(int ClientID, int CourseID);
        DataTable RetrieveEnrolledCourses(int id);
        String RetrieveCourseStatus(int ClientID, int _courseID);
        String RetrieveCourseStartDate(int ClientID, int CourseID);
    }
}
