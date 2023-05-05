using APAssignmentClient.Model;
using APAssignmentClient.View;
using System;

namespace APAssignmentClient.Presenter
{
    public class AddNewCoursePresenter
    {
        private IAddNewCourse screen;
        private ICourseModel courseModel;
        private bool editMode;

        public AddNewCoursePresenter(IAddNewCourse _screen, ICourseModel _courseModel, bool _editMode)
        {
            courseModel = _courseModel;
            editMode = _editMode;
            screen = _screen;
            screen.Register(this);
            Console.WriteLine(_editMode);
        }

        public void AddNewCourse_Load()
        {
            if(editMode == true)
            {
                String[] course = courseModel.RetrieveCourseInformation();
                screen.CourseID = course[0];
                screen.CourseTitle = course[1];
                screen.Description = course[2];
                screen.CourseType = course[3];
                screen.CourseDuration = course[4];
                screen.CoursePrice = double.Parse(course[5]).ToString();
            }
            else
            {
                screen.CourseID = "New";
            }
        }

        public void AddButton_Click()
        {
            if (editMode == false)
            {
                courseModel.AddNewCourse(screen.CourseTitle, screen.Description, double.Parse(screen.CoursePrice), screen.CourseType, Int32.Parse(screen.CourseDuration));
                screen.CloseForm();
            }
            else
            {
                courseModel.EditCourse(Int32.Parse(screen.CourseID), screen.CourseTitle, screen.Description, double.Parse(screen.CoursePrice), screen.CourseType, Int32.Parse(screen.CourseDuration));
                screen.CloseForm();
            }
        }
    }
}
