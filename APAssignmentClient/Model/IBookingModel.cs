using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public interface IBookingModel
    {
        List<Management> RetrieveAllManagement();
        int ManagementID { set; get; }
        int BookingID { set; get; }
        String RetrieveSupportSession();
        void AddNewBooking(int clientID, int duration, DateTime date);
        void DropBooking(int clientID);
        List<Booking> RetrieveAllBooking(int clientID);
        String RetrieveManagementName(int managementID);
    }
}
