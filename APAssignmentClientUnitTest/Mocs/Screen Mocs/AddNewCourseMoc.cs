using APAssignmentClient.Presenter;
using APAssignmentClient.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClientUnitTest.Mocs.ScreenMocs
{
    public class AddNewCourseMoc : IAddNewCourse
    {
        public String CourseID { get; set; }
        public String CourseTitle { get; set; }
        public String Description { get; set; }
        public String CourseType { get; set; }
        public String CoursePrice { get; set; }
        public String CourseDuration { get; set; }
        public String ErrMsg { get; set; }
        public String ErrTitle { get; set; }
        public bool FormClosed { get; set; } = false;

        public void CloseForm()
        {
            FormClosed = true;
        }

        public void DisplayErrorMessage(string msg, string title)
        {
            ErrMsg = msg;
            ErrTitle = title;
        }

        public void Register(AddNewCoursePresenter _presenter){}
    }
}
