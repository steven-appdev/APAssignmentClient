using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient.Model
{
    public class EnrollNewCourseModel : IEnrollNewCourseModel
    {
        IDataAccess access;

        public EnrollNewCourseModel(IDataAccess _access)
        {
            access = _access;
        }

        public List<Course> RetrieveAllCourses()
        {
            if(access.IsCourseEmpty() == true)
            {
                AddNewCourse("Introduction to the Architectural and Build Option", "Example Description 1", 300.00);
                AddNewCourse("Choosing a plot of lang", "Example Description 2", 250.00);
                AddNewCourse("Building regulations and inspections", "Example Description 3", 500.00);
                AddNewCourse("Groundwork and Foundations", "Example Description 4", 200.00);
                AddNewCourse("Insulation", "Example Description 5", 150.00);
                Console.WriteLine("New data added");
            }

            return access.RetrieveAllCourses();
        }

        public void AddNewCourse(String _courseName, String _courseDescription, double _coursePrice)
        {
            Course course = new Course();
            course.CourseName = _courseName;
            course.CoursePrice = _coursePrice;
            course.CourseDescription = _courseDescription;
            access.AddNewCourse(course);
        }

        public String ConvertPrice(double price)
        {
            if(price % 1 != 0)
            {
                return price.ToString() + "0";
            }

            return price.ToString() + ".00";
        }
    }
}
