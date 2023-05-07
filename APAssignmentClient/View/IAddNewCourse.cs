using System;
using APAssignmentClient.Presenter;

namespace APAssignmentClient.View
{
    public interface IAddNewCourse
    {
        String CourseID { get; set; }
        String CourseTitle { get; set; }
        String Description { get; set; }
        String CourseType { get; set; } 
        String CoursePrice { get; set; }
        String CourseDuration { get; set; }
        void Register(AddNewCoursePresenter _presenter);
        void DisplayErrorMessage(String msg, String title);
        void CloseForm();
    }
}
