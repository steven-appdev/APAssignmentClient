using APAssignmentClient.Presenter;
using APAssignmentClient.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClientUnitTest.Mocs.ScreenMocs
{
    public class CourseDescriptionMoc : ICourseDescription
    {
        public String CourseID { get; set; }
        public String CourseTitle { get; set; }
        public String CourseType { get; set; }
        public String Description { get; set; }
        public String CoursePrice { get; set; }
        public String CourseDuration { get; set; }
        public Size FormSize { get; set; }
        public Point CloseButtonLocation { get; set; }
        public String Status { get; set; }
        public bool StatusVisible { get; set; }
        public bool StatusLabelVisible { get; set; }
        public bool DateVisible { get; set; }
        public bool DateLabelVisible { get; set; }
        public String Date { get; set; }
        public bool WaitingListButton { get; set; }
        public String Message { get; set; }
        public String MessageTitle { get; set; }
        public String ErrorMsg { get; set; }
        public String ErrorTitle { get; set; }
        public bool FormClosed { get; set; } = false;

        public void Register(CourseDescriptionPresenter _presenter){}

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

        public void CloseForm()
        {
            FormClosed = true;
        }
    }
}
