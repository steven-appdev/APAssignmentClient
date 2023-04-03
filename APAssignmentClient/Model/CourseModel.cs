using APAssignmentClient.Data_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public class CourseModel : ICourseModel
    {
        private static CourseModel _instance = null;
        IDataAccess access;
        private int _courseID = 0;
        private int _currentUser = 1;

        private CourseModel()
        {
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

        public int CurrentUser
        {
            set { _currentUser = value; }
            get { return _currentUser; }
        }

        public int CourseID
        {
            set { _courseID = value; }
            get { return _courseID; }
        }

        public List<Course> RetrieveAllCourses()
        {
            if (access.IsCourseEmpty() == true)
            {
                AddNewCourse("Introduction to the Architectural and Build Option", "Example Description 1", 300.00);
                AddNewCourse("Choosing a plot of lang", "Example Description 2", 250.00);
                AddNewCourse("Building regulations and inspections", "Example Description 3", 500.00);
                AddNewCourse("Groundwork and Foundations", "Example Description 4", 200.00);
                AddNewCourse("Insulation", "Example Description 5", 150.00);
            }

            List<Course> retrievedCourses = access.RetrieveAllCourses();
            List<Course> retrievedEnrolledCourses = RetrieveEnrolledCourses();
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

        public void AddNewCourse(String _courseName, String _courseDescription, double _coursePrice)
        {
            Course course = Course.GetInstance();
            course.CourseName = _courseName;
            course.CoursePrice = _coursePrice;
            course.CourseDescription = _courseDescription;
            access.AddNewCourse(course);
        }

        public String ConvertPrice(double price)
        {
            if (price % 1 != 0)
            {
                return price.ToString() + "0";
            }

            return price.ToString() + ".00";
        }

        public Course RetrieveCourseInformation()
        {
            return access.RetrieveOneCourse(_courseID);
        }

        public void EnrolSelectedCourse()
        {
            access.EnrolCourse(_currentUser, _courseID);
        }

        public List<Course> RetrieveEnrolledCourses()
        {
            return access.RetrieveEnrolledCourses(_currentUser);
        }
    }
}
