using APAssignmentClient.Presenter;
using APAssignmentClient.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClientUnitTest.Mocs.ScreenMocs
{
    public class EnrolNewCourseMoc : IEnrolNewCourse
    {
        public DataGridView availableCourses { get; }
        public Object GetSelectedNewCourse { get { return 1; } }
        public String Message { get; set; }
        public String MessageTitle { get; set; }
        public String ErrorMsg { get; set; }
        public String ErrorTitle { get; set; }
        public DataTable AvailableCourses { get; set; }
        public bool FormClosed { get; set; } = false;

        public void Register(EnrolNewCoursePresenter presenter) { }
        public bool DisplayConfirmationMessage(String msg, String title)
        {
            Message = msg;
            MessageTitle = title;
            return true;
        }

        public void DisplayErrorMessage(String msg, String title)
        {
            ErrorMsg = msg;
            ErrorTitle = title;
        }

        public void SetNewCourseListDataSource(DataTable dt)
        {
            AvailableCourses = dt;
        }

        public void CloseForm()
        {
            FormClosed = true;
        }
    }
}
