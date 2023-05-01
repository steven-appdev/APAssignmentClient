using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using APAssignmentClient.DataService;

namespace APAssignmentClient.Model
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

        public DataTable RetrieveAllCourses(int ClientID)
        {
            //FOR DEVELOPMENT ONLY, REMOVE ONCE CODES WERE MERGE
            //if (access.IsCourseEmpty() == true)
            //{
            //    AddNewCourse("Introduction to the Architectural and Build Option", "Example Description 1", 300.00, "Video Course", 0);
            //    AddNewCourse("Choosing a plot of lang", "Example Description 2", 250.00, "Video Course", 0);
            //    AddNewCourse("Building regulations and inspections", "Example Description 3", 500.00, "Video Course", 0);
            //    AddNewCourse("Groundwork and Foundations", "Example Description 4", 200.00, "Video Course", 0);
            //    AddNewCourse("Drylining and Plastering", "Example Description 5", 1100.00, "Practical Course", 4);
            //}

            try
            {
                List<Course> retrievedCourses = access.RetrieveAllCourses();
                List<Course> retrievedEnrolledCourses = access.RetrieveEnrolledCourses(ClientID);

                DataTable dt = new DataTable();
                dt.Columns.Add("id");
                dt.Columns.Add("name");
                dt.Columns.Add("type");
                dt.Columns.Add("duration");
                dt.Columns.Add("price");
                foreach (Course c in retrievedCourses)
                {
                    if (!retrievedEnrolledCourses.Any(crs => crs.CourseId == c.CourseId))
                    {
                        dt.Rows.Add(c.CourseId.ToString(), c.CourseName, c.CourseType, ConvertDuration(c.CourseDuration), ConvertPrice(c.CoursePrice));
                    }
                }

                if (dt.Rows.Count != 0)
                {
                    return dt;
                }
                throw new Exception("No available courses available at the moment. Please check back later!");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public void AddNewCourse(String _courseName, String _courseDescription, double _coursePrice, String _courseType, int _courseDuration)
        {
            try
            {
                Course newCourse = new Course
                {
                    CourseName = _courseName,
                    CoursePrice = _coursePrice,
                    CourseDescription = _courseDescription,
                    CourseType = _courseType,
                    CourseDuration = _courseDuration
                };
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public String[] RetrieveCourseInformation()
        {
            try
            {
                Course course = access.RetrieveOneCourse(CourseID);
                return course.ToStringArray();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void EnrolSelectedCourse(int ClientID, int CourseID)
        {
            try
            {
                access.EnrolCourse(ClientID, CourseID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public void DropSelectedCourse(int ClientID, int CourseID)
        {
            try
            {
                access.DropCourse(ClientID, CourseID);
                access.DropWaitingList(ClientID, CourseID);
                access.DropPendingList(ClientID, CourseID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public DataTable RetrieveEnrolledCourses(int ClientID)
        {
            try
            {
                List<Course> course = access.RetrieveEnrolledCourses(ClientID);
                DataTable dt = new DataTable();
                dt.Columns.Add("id");
                dt.Columns.Add("title");
                dt.Columns.Add("type");
                dt.Columns.Add("status");
                foreach (Course c in course)
                {
                    dt.Rows.Add(c.CourseId.ToString(), c.CourseName, c.CourseType, RetrieveCourseStatus(ClientID, Int32.Parse(c.CourseId.ToString())));
                }
                return dt;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void ReturnToCourseWaitingList(int ClientID, int CourseID)
        {
            try
            {
                access.DropPendingList(ClientID, CourseID);
                access.AddToWaitingList(ClientID, CourseID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public String RetrieveCourseStatus(int ClientID, int _courseID)
        {
            try
            {
                CourseClients course = access.RetrieveCourseStatus(ClientID, _courseID);
                return course.Status.ToString();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public String RetrieveCourseStartDate(int ClientID, int CourseID)
        {
            try
            {
                return access.RetrieveCourseStartDate(ClientID, CourseID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private String ConvertPrice(double price)
        {
            if (price % 1 != 0)
            {
                return price.ToString() + "0";
            }

            return price.ToString() + ".00";
        }

        private String ConvertDuration(int duration)
        {
            if (duration == 0)
            {
                return "-";
            }
            return duration.ToString();
        }
    }
}
