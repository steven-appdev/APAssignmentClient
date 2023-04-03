using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient.Model
{
    public interface IEnrollNewCourseModel
    {
        List<Course> RetrieveAllCourses();
        String ConvertPrice(double price);
    }
}
