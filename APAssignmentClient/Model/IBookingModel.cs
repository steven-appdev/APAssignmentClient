using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APAssignmentClient.DataService;

namespace APAssignmentClient.Model
{
    public interface IBookingModel
    {
        int ManagementID { set; get; }
        int BookingID { set; get; }
        DataTable RetrieveAllManagement();
        String RetrieveSupportSession();
        void AddNewBooking(int clientID, int duration, DateTime date);
        void DropBooking(int clientID);
        DataTable RetrieveAllBooking(int clientID);
    }
}
