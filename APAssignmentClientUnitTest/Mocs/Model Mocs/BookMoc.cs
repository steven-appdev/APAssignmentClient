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
        int IBookingModel.ManagementID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IBookingModel.BookingID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IBookingModel.AddNewBooking(int clientID, int duration, DateTime date)
        {
            throw new NotImplementedException();
        }

        void IBookingModel.DropBooking(int clientID)
        {
            throw new NotImplementedException();
        }

        DataTable IBookingModel.RetrieveAllBooking(int clientID)
        {
            throw new NotImplementedException();
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
