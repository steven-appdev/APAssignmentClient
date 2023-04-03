using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient.Data_Service
{
    public class DataAccess : IDataAccess
    {
        public bool IsCourseEmpty()
        {
            using(var context = new Context())
            {
                var courses = context.Courses.ToList();

                if (courses == null || courses.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<Course> RetrieveAllCourses()
        {
            using (var context = new Context())
            {
                return context.Courses.ToList();
            }
        }

        public Course RetrieveOneCourse(int courseID)
        {
            using (var context = new Context())
            {
                return context.Courses.Where(c => c.CourseId == courseID).First<Course>();
            }
        }

        public void AddNewCourse(Course course)
        {
            using (var context = new Context())
            {
                context.Courses.Add(course);
                context.SaveChanges();
            }
        }
    }
}
