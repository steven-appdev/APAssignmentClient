using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APAssignmentClient.Presenter;

namespace APAssignmentClient.View
{
    public interface ICourseDescription
    {
        String CourseID { get; set; }
        String CourseTitle { get; set; }
        String CourseType { get; set; }
        String Description { get; set; }
        Size DescriptionSize { get; set; }
        String Status { get; set; }
        bool StatusVisible { get; set; }
        bool StatusLabelVisible { get; set; }
        bool DateVisible { get; set; }
        bool DateLabelVisible { get; set; }
        String Date { get; set; }
        bool WaitingListButton { get; set; }
        void Register(CourseDescriptionPresenter presenter);
        bool DisplayConfirmationMessage(String msg, String title);
        void DisplayErrorMessage(String msg, String title);
        void CloseForm();
    }
}
