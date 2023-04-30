using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APAssignmentClient.DataService;

namespace APAssignmentClient.Model
{
    public class BookingModel : IBookingModel
    {
        private static BookingModel _instance = null;
        private IDataAccess access;
        private Management management;
        private int bookingID;

        private BookingModel()
        {
            management = new Management();
            access = new DataAccess();
        }

        public static BookingModel GetInstance()
        {
            if (_instance == null)
            {
                _instance = new BookingModel();
            }
            return _instance;
        }

        public DataTable RetrieveAllManagement()
        {
            List<Management> management = access.RetrieveAllManagement();
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            foreach(Management m in management)
            {
                dt.Rows.Add(m.ManagementId, m.ManagementName);
            }
            return dt;
        }

        public DataTable RetrieveAllBooking(int clientID)
        {
            List<Booking> booking = access.RetrieveAllBooking(clientID);
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("date");
            dt.Columns.Add("duration");
            foreach(Booking bk in booking)
            {
                dt.Rows.Add(bk.BookingID, RetrieveManagementName(bk.ManagementId), bk.BookingDate, bk.BookingDuration);
            }

            return dt;
        }

        public int ManagementID
        {
            set { management.ManagementId = value; }
            get { return management.ManagementId; }
        }

        public int BookingID
        {
            set { bookingID = value; }
            get { return bookingID; }
        }

        public String RetrieveManagementName(int managementID)
        {
            return access.RetrieveManagementName(managementID);
        }
        
        public String RetrieveSupportSession()
        {
            return access.RetrieveOneManagement(ManagementID).ManagementSupportSession;
        }

        public void AddNewBooking(int clientID, int duration, DateTime date)
        {
            access.AddNewBooking(clientID, ManagementID, duration, date);
        }

        public void DropBooking(int clientID)
        {
            access.DropBooking(clientID, BookingID);
        }
    }
}
