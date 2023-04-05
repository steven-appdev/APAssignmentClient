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

        public int ManagementID
        {
            set { management.ManagementID = value; }
            get { return management.ManagementID; }
        }
        
        public String RetrieveSupportSession()
        {
            return access.RetrieveOneManagement(ManagementID).ManagementSupportSession;
        }
    }
}
