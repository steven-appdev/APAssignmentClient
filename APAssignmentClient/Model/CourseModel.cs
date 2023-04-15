using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public class CourseModel : ICourseModel
    {
        private static CourseModel _instance = null;
        IDataAccess access;
        private Course course;

        private CourseModel()
        {
            course = new Course();
            access = new DataAccess();
        }

        public static CourseModel GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CourseModel();
            }
            return _instance;
        }

        public int CourseID
        {
            set { course.CourseId = value; }
            get { return course.CourseId; }
        }

        public List<Course> RetrieveAllCourses(int ClientID)
        {
            if (access.IsCourseEmpty() == true)
            {
                AddNewCourse("Introduction to the Architectural and Build Option", "Example Description 1", 300.00, "Video Course", 0);
                AddNewCourse("Choosing a plot of lang", "Example Description 2", 250.00, "Video Course", 0);
                AddNewCourse("Building regulations and inspections", "Example Description 3", 500.00, "Video Course", 0);
                AddNewCourse("Groundwork and Foundations", "Example Description 4", 200.00, "Video Course", 0);
                AddNewCourse("Drylining and Plastering", "Example Description 5", 1100.00, "Practical Course", 4);
            }

            List<Course> retrievedCourses = access.RetrieveAllCourses();
            List<Course> retrievedEnrolledCourses = access.RetrieveEnrolledCourses(ClientID);
            List<Course> currentAvailableCourses = new List<Course>();

            foreach(Course c in retrievedCourses)
            {
                if (!retrievedEnrolledCourses.Any(crs => crs.CourseId == c.CourseId))
                {
                    currentAvailableCourses.Add(c);
                }
            }

            return currentAvailableCourses;
        }

        public void AddNewCourse(String _courseName, String _courseDescription, double _coursePrice, String _courseType, int _courseDuration)
        {
            Course newCourse = new Course
            {
                CourseName = _courseName,
                CoursePrice = _coursePrice,
                CourseDescription = _courseDescription,
                CourseType = _courseType,
                CourseDuration = _courseDuration
            };      
            access.AddNewCourse(newCourse);
        }

        public String ConvertPrice(double price)
        {
            if (price % 1 != 0)
            {
                return price.ToString() + "0";
            }

            return price.ToString() + ".00";
        }

        public String ConvertDuration(int duration)
        {
            if (duration == 0)
            {
                return "-";
            }
            return duration.ToString();
        }

        public Course RetrieveCourseInformation()
        {
            return access.RetrieveOneCourse(CourseID);
        }

        public void EnrolSelectedCourse(int ClientID, int CourseID)
        {
            access.EnrolCourse(ClientID, CourseID);
        }

        public void DropSelectedCourse(int ClientID, int CourseID)
        {
            access.DropCourse(ClientID, CourseID);
            access.DropWaitingList(ClientID, CourseID);
            access.DropPendingList(ClientID, CourseID);
        }

        public List<String> RetrieveEnrolledCourses(int ClientID)
        {
            List<Course> course = access.RetrieveEnrolledCourses(ClientID);
            List<String> enrolledCourses = new List<String>();
            foreach(Course c in course)
            {
                enrolledCourses.Add(c.CourseId.ToString()+";"+c.CourseName+";"+c.CourseType+";"+ RetrieveCourseStatus(ClientID, Int32.Parse(c.CourseId.ToString())));
            }
            return enrolledCourses;
        }

        public void ReturnToCourseWaitingList(int ClientID, int CourseID)
        {
            access.DropPendingList(ClientID, CourseID);
            access.AddToWaitingList(ClientID, CourseID);
        }

        public String[] SplitCourseInformation(String s)
        {
            return s.Split(';');
        }

        public String RetrieveCourseStatus(int ClientID, int _courseID)
        {
            CourseClients course = access.RetrieveCourseStatus(ClientID, _courseID);
            return course.Status.ToString();
        }

        public String RetrieveCourseStartDate(int ClientID, int CourseID)
        {
            return access.RetrieveCourseStartDate(ClientID, CourseID);
        }
    }
}
