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

        void IBookingModel.AddNewBooking(int clientID, int duration, DateTime date)
        {
            throw new NotImplementedException();
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

        DataTable IBookingModel.RetrieveAllManagement()
        {
            throw new NotImplementedException();
        }

        string IBookingModel.RetrieveSupportSession()
        {
            throw new NotImplementedException();
        }
    }
}
