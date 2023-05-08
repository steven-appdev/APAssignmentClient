using APAssignmentClient.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClientUnitTest.Mocs.ModelMocs
{
    public class CourseMoc : ICourseModel
    {
        public int CourseID { set; get; }
        public String CourseName { set; get; }
        public String CourseDescription { set; get; }
        public Double CoursePrice { set; get; }
        public String CourseType { set; get; }
        public int CourseDuration { set; get; }
        public bool Deleted { get; set; } = false;
        public bool Dropped { get; set; } = false;
        public bool Returned { get; set; } = false;
        public bool Enrolled { get; set; } = false;

        public void AddNewCourse(string _courseName, string _courseDescription, double _coursePrice, string _courseType, int _courseDuration)
        {
            CourseName = _courseName;
            CourseDescription = _courseDescription;
            CoursePrice = _coursePrice;
            CourseType = _courseType;
            CourseDuration = _courseDuration;
        }

        public void DeleteCourse()
        {
            Deleted = true;
        }

        public void DropSelectedCourse(int clientID, int courseID)
        {
            Dropped = true;
        }

        public void EditCourse(int _courseID, string _courseName, string _courseDescription, double _coursePrice, string _courseType, int _courseDuration)
        {
            CourseID = _courseID;
            CourseName = _courseName;
            CourseDescription = _courseDescription;
            CoursePrice = _coursePrice;
            CourseType = _courseType;
            CourseDuration = _courseDuration;
        }

        public void EnrolSelectedCourse(int clientID, int courseID)
        {
            Enrolled = true;
        }

        public DataTable RetrieveAllCourses()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("type");
            return dt;
        }

        public String[] RetrieveCourseInformation()
        {
            return new string[]{ "1", "Test", "Test Desc", "Video Course", "0", "0.00"};
        }

        public String RetrieveCourseStartDate(int ClientID, int CourseID)
        {
            return "Returned date";
        }

        public String RetrieveCourseStatus(int ClientID, int _courseID)
        {
            return "Course will started on";
        }

        public DataTable RetrieveEnrollableCourses(int id)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("type");
            dt.Columns.Add("duration");
            dt.Columns.Add("price");
            return dt;
        }

        public DataTable RetrieveEnrolledCourses(int id)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("type");
            dt.Columns.Add("duration");
            dt.Columns.Add("price");
            return dt;
        }

        public void ReturnToCourseWaitingList(int ClientID, int CourseID)
        {
            Returned = true;
        }
    }
}
