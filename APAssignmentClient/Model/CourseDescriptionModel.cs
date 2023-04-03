using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public class CourseDescriptionModel : ICourseDescriptionModel
    {
        private int courseID;
        IDataAccess access;

        public CourseDescriptionModel(IDataAccess _access)
        {
            access = _access;
        }

        public int CourseID
        {
            set { courseID = value; }
            get { return courseID; }
        }

        public Course RetrieveCourseInformation()
        {
            return access.RetrieveOneCourse(courseID);
        }
    }
}
