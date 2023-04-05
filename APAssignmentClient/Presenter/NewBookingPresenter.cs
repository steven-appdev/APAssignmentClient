using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public class NewBookingPresenter
    {
        private INewBooking screen;
        private IClientModel clientModel;
        private IBookingModel bookingModel;
        
        public NewBookingPresenter(INewBooking _screen, IClientModel _clientModel, IBookingModel _bookingModel)
        {
            screen = _screen;
            clientModel = _clientModel;
            bookingModel = _bookingModel;
            screen.Register(this);
        }

        public void NewBooking_Load()
        {
            List<Management> managements = bookingModel.RetrieveAllManagement();
            screen.ManagementName.ValueMember = "ManagementID";
            screen.ManagementName.DisplayMember = "ManagementName";
            screen.ManagementName.DataSource = managements;
        }

        public void cmbManagementName_SelectedIndexChanged()
        {
            bookingModel.ManagementID = (int)(screen.ManagementName.SelectedValue);
            screen.SupportSession = bookingModel.RetrieveSupportSession();
        }
    }
}
