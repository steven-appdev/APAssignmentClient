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
            try
            {
                List<Management> management = access.RetrieveAllManagement();
                DataTable dt = new DataTable();
                dt.Columns.Add("id");
                dt.Columns.Add("name");
                foreach (Management m in management)
                {
                    dt.Rows.Add(m.ManagementId, m.ManagementName);
                }
                return dt;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public DataTable RetrieveAllBooking(int clientID)
        {
            try
            {
                List<Booking> booking = access.RetrieveAllBooking(clientID);
                DataTable dt = new DataTable();
                dt.Columns.Add("id");
                dt.Columns.Add("name");
                dt.Columns.Add("date");
                dt.Columns.Add("duration");
                foreach (Booking bk in booking)
                {
                    dt.Rows.Add(bk.BookingID, RetrieveManagementName(bk.ManagementId), bk.BookingDate, bk.BookingDuration);
                }
                return dt;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
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

        private String RetrieveManagementName(int managementID)
        {
            try
            {
                return access.RetrieveManagementName(managementID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
        public String RetrieveSupportSession()
        {
            try
            {
                return access.RetrieveOneManagement(ManagementID).ManagementSupportSession;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void AddNewBooking(int clientID, int duration, DateTime date)
        {
            try
            {
                access.AddNewBooking(clientID, ManagementID, duration, date);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DropBooking(int clientID)
        {
            try
            {
                access.DropBooking(clientID, BookingID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
