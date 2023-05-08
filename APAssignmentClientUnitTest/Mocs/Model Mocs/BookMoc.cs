using APAssignmentClient.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClientUnitTest.Mocs.ModelMocs
{
    public class BookMoc : IBookingModel
    {
        public int ManagementID { get; set; }
        public int BookingID { get; set; }
        public bool Dropped { get; set; } = false;
        public int ClientID { get; set; }
        public int Duration { get; set; }
        public DateTime Date { get; set; }

        void IBookingModel.AddNewBooking(int clientID, int duration, DateTime date)
        {
            ClientID = clientID;
            Duration = duration;
            Date = date;
        }

        public void DropBooking(int clientID)
        {
            Dropped = true;
        }

        public DataTable RetrieveAllBooking(int clientID)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("date");
            dt.Columns.Add("duration");
            return dt;
        }

        public DataTable RetrieveAllManagement()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            return dt;
        }

        public String RetrieveSupportSession()
        {
            return "Support Session";
        }
    }
}
