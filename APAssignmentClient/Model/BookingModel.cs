using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
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

        public List<Management> RetrieveAllManagement()
        {
            return access.RetrieveAllManagement();
        }

        public List<Booking> RetrieveAllBooking(int clientID)
        {
            return access.RetrieveAllBooking(clientID);
        }

        public int ManagementID
        {
            set { management.ManagementID = value; }
            get { return management.ManagementID; }
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
