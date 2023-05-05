using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient.DataService
{
    public interface IDataAccess
    {
        bool IsCourseEmpty();
        List<Client> RetrieveAllClients();
        void DeleteClient(int clientID);
        List<Course> RetrieveAllCourses();
        Course RetrieveOneCourse(int courseID);
        void AddNewCourse(Course course);
        void EditCourse(Course course);
        void DeleteCourse(int courseID);
        void EnrolCourse(int clientID, int courseID);
        void DropCourse(int clientID, int courseID);
        List<Course> RetrieveEnrolledCourses(int clientID);
        CourseClients RetrieveCourseStatus(int clientID, int courseID);
        Client RetrieveClientInformation(int clientID);
        List<Management> RetrieveAllManagement();
        Management RetrieveOneManagement(int managementID);
        void AddNewBooking(int clientID, int managementID, int duration, DateTime date);
        void DropBooking(int clientID, int bookingID);
        List<Booking> RetrieveAllBooking(int clientID);
        String RetrieveCourseStartDate(int clientID, int courseID);
        String RetrieveManagementName(int managementID);
        String RetrieveManagementCourse(int managementID);
        void AddToWaitingList(int clientID, int courseID);
        void DropWaitingList(int clientID, int courseID);
        void DropPendingList(int clientID, int courseID);
    }
}
