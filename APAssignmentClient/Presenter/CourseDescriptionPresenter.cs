using System;
using APAssignmentClient.View;
using APAssignmentClient.Model;

namespace APAssignmentClient.Presenter
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
            String[] course = courseModel.RetrieveCourseInformation();
            screen.CourseID = course[0];
            screen.CourseTitle = course[1];
            screen.CourseType = course[2];
            screen.Description = course[3];
            screen.DescriptionSize = new System.Drawing.Size(357, 191);

            if (displayFullDetail)
            {
                screen.DescriptionSize = new System.Drawing.Size(357, 132);
                screen.DateLabelVisible = true;
                screen.DateVisible = true;
                screen.StatusLabelVisible = true;
                screen.StatusVisible = true;

                PopulateFullDetail(clientModel.ClientID, Int32.Parse(course[0]));

                if (screen.Status.Contains("Course will started on"))
                {
                    screen.WaitingListButton = true;
                }
            }
        }

        public void btnPlaceBackToWaiting_Click()
        {
            int ID = Int32.Parse(screen.CourseID);
            bool result = screen.DisplayConfirmationMessage("Do you want to place back to the waiting list?", "Are you sure?");
            if (result == true)
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
