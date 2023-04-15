using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClient
{
    public class CourseDescriptionPresenter
    {
        private IClientModel clientModel;
        private ICourseDescription screen;
        private ICourseModel courseModel;
        private bool displayFullDetail;
        public CourseDescriptionPresenter(ICourseDescription _screen, IClientModel _clientModel, ICourseModel _courseModel, bool _displayFullDetail)
        {
            screen = _screen;
            clientModel = _clientModel;
            courseModel = _courseModel;
            displayFullDetail = _displayFullDetail;
            screen.Register(this);
        }

        public void CourseDescription_Load()
        {
            Course course = courseModel.RetrieveCourseInformation();
            screen.CourseID = course.CourseId.ToString();
            screen.CourseTitle = course.CourseName.ToString();
            screen.CourseType = course.CourseType.ToString();
            screen.Description = course.CourseDescription.ToString();
            screen.DescriptionSize = new System.Drawing.Size(357, 191);

            if (displayFullDetail)
            {
                screen.DescriptionSize = new System.Drawing.Size(357, 132);
                screen.DateLabelVisible = true;
                screen.DateVisible = true;
                screen.StatusLabelVisible = true;
                screen.StatusVisible = true;

                PopulateFullDetail(clientModel.ClientID, course.CourseId);

                if (screen.Status.Contains("Course will started on"))
                {
                    screen.WaitingListButton = true;
                }
            }
        }

        public void btnPlaceBackToWaiting_Click()
        {
            int ID = Int32.Parse(screen.CourseID);
            DialogResult result = MessageBox.Show("Do you want to place back to the waiting list?", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                courseModel.ReturnToCourseWaitingList(clientModel.ClientID, ID);
                PopulateFullDetail(clientModel.ClientID, ID);
                screen.WaitingListButton = false;
            }
        }

        private void PopulateFullDetail(int ClientID, int CourseID)
        {
            screen.Date = courseModel.RetrieveCourseStartDate(ClientID, CourseID);
            screen.Status = courseModel.RetrieveCourseStatus(ClientID, CourseID);
        }
    }
}
