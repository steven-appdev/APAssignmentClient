using APAssignmentClient.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClient
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
            screen.username = clientModel.ClientName;
        }

        public void ClientDashboard_Activated()
        {
            screen.enrolledCourses.Rows.Clear();
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
            DialogResult result = MessageBox.Show("Do you want to drop the course?", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                courseModel.DropSelectedCourse(clientModel.ClientID, dropID);
                clientModel.UpdateClientBill();
                PopulateDataTable();
            }
        }

        public void btnDropBooking_Click()
        {
            bookingModel.BookingID = RetrieveSelectedBookingID();
            DialogResult result = MessageBox.Show("Do you want to drop the booking?", "Are you sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bookingModel.DropBooking(clientModel.ClientID);
                clientModel.UpdateClientBill();
                PopulateDataTable();
            }
        }

        public void dgvEnrolledCourses_RowsAdded()
        {
            if(screen.dropCourse == false)
            {
                screen.dropCourse = true;
            }
        }

        public void dgvEnrolledCourses_RowsRemoved()
        {
            if (screen.dropCourse == true)
            {
                screen.dropCourse = false;
            }
        }

        private void PopulateDataTable()
        {
            List<String> courses = courseModel.RetrieveEnrolledCourses(clientModel.ClientID);
            screen.enrolledCourses.Rows.Clear();
            if (courses != null)
            {
                foreach (String s in courses)
                {
                    String[] course = courseModel.SplitCourseInformation(s);
                    screen.enrolledCourses.Rows.Add(course[0], course[1], course[2], course[3]);
                }
                screen.enrolledCourses.Sort(screen.enrolledCourses.Columns["id"], ListSortDirection.Ascending);
            }

            List<Booking> booking = bookingModel.RetrieveAllBooking(clientModel.ClientID);
            screen.BookedSession.Rows.Clear();
            if(booking != null)
            {
                foreach (Booking bk in booking)
                {
                    screen.BookedSession.Rows.Add(bk.BookingID, bookingModel.RetrieveManagementName(bk.ManagementId), bk.BookingDate, bk.BookingDuration);
                }
                screen.BookedSession.Sort(screen.BookedSession.Columns["clmID"], ListSortDirection.Ascending);
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
