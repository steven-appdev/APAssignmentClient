using System;
using APAssignmentClient.View;
using APAssignmentClient.Model;
using System.Data;

namespace APAssignmentClient.Presenter
{
    public class ClientDashboardPresenter
    {
        private IClientModel clientModel;
        private ICourseModel courseModel;
        private IBookingModel bookingModel;
        private IClientDashboard screen;

        public ClientDashboardPresenter(IClientDashboard _screen, IClientModel _clientModel, ICourseModel _courseModel, IBookingModel _bookingModel)
        {
            clientModel = _clientModel;
            courseModel = _courseModel;
            bookingModel = _bookingModel;
            screen = _screen;
            screen.Register(this);
        }

        public void ClientDashboard_Load()
        {
            screen.Username = clientModel.ClientName;
            PopulateDataTable();
        }

        public void ClientDashboard_Activated()
        {
            clientModel.UpdateClientBill();
            PopulateDataTable();
        }

        public void btnEnrolNew_Click()
        {
            EnrolNewCourse screen = new EnrolNewCourse();
            EnrolNewCoursePresenter presenter = new EnrolNewCoursePresenter(screen, clientModel, courseModel);
            screen.ShowDialog();
        }

        public void btnClientInformation_Click()
        {
            ClientInformation screen = new ClientInformation();
            ClientInformationPresenter presenter = new ClientInformationPresenter(screen, clientModel);
            screen.ShowDialog();
        }

        public void btnNewBooking_Click()
        {
            NewBooking screen = new NewBooking();
            NewBookingPresenter presenter = new NewBookingPresenter(screen, clientModel, bookingModel);
            screen.ShowDialog();
        }

        public void btnDropCourse_Click()
        {
            int dropID = RetrieveSelectedID();
            bool result = screen.DisplayConfirmationMessage("Do you want to drop this course?", "Are you sure?");
            if (result == true)
            {
                courseModel.DropSelectedCourse(clientModel.ClientID, dropID);
                clientModel.UpdateClientBill();
                PopulateDataTable();
            }
        }

        public void btnDropBooking_Click()
        {
            bookingModel.BookingID = RetrieveSelectedBookingID();
            bool result = screen.DisplayConfirmationMessage("Do you want to drop this booking?", "Are you sure?");
            if (result == true)
            {
                bookingModel.DropBooking(clientModel.ClientID);
                clientModel.UpdateClientBill();
                PopulateDataTable();
            }
        }

        public void dgvEnrolledCourses_DataSourceChanged()
        {
            CheckCourseListRowCount();
        }

        public void dgvBooking_DataSourceChanged()
        {
            CheckBookingListRowCount();
        }

        public void btnViewCourse_Click()
        {
            courseModel.CourseID = RetrieveSelectedID();

            CourseDescription screen = new CourseDescription();
            CourseDescriptionPresenter presenter = new CourseDescriptionPresenter(screen, clientModel, courseModel, true);
            screen.ShowDialog();
        }

        private void PopulateDataTable()
        {
            try
            {
                DataTable enrolledDT = courseModel.RetrieveEnrolledCourses(clientModel.ClientID);
                screen.SetCourseListDataSource(enrolledDT);

                DataTable bookingDT = bookingModel.RetrieveAllBooking(clientModel.ClientID);
                screen.SetBookingListDataSource(bookingDT);
            }
            catch (Exception e)
            {
                screen.DisplayErrorMessage(e.Message, "Opps!");
            }
        }

        private void CheckCourseListRowCount()
        {
            if(screen.GetCourseListCount > 0)
            {
                screen.SetCourseButtonsEnabled(true);
            }
            else
            {
                screen.SetCourseButtonsEnabled(false);
            }
        }

        private void CheckBookingListRowCount()
        {
            if (screen.GetBookingListCount > 0)
            {
                screen.SetBookingButtonsEnabled(true);
            }
            else
            {
                screen.SetBookingButtonsEnabled(false);
            }
        }

        private int RetrieveSelectedID()
        {
            return Int32.Parse(screen.GetSelectedValue.ToString());
        }

        private int RetrieveSelectedBookingID()
        {
            return Int32.Parse(screen.GetSelectedBookingID.ToString());
        }
    }
}
