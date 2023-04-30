using System;
using APAssignmentClient.View;
using APAssignmentClient.Model;
using System.Data;

namespace APAssignmentClient.Presenter
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
            DataTable managements = bookingModel.RetrieveAllManagement();
            screen.ManagementName.ValueMember = "id";
            screen.ManagementName.DisplayMember = "name";
            screen.ManagementName.DataSource = managements;
            screen.Duration.SelectedIndex = 0;
        }

        public void cmbManagementName_SelectedIndexChanged()
        {
            UpdateManagementID();
            screen.SupportSession = bookingModel.RetrieveSupportSession();
        }

        public bool btnConfirmBooking_Click()
        {
            bool result = screen.DisplayConfirmationMessage("Do you want to create this booking?", "Booking Confirmation");
            if (result == true)
            {
                UpdateManagementID();
                bookingModel.AddNewBooking(clientModel.ClientID, Int32.Parse(screen.Duration.SelectedItem.ToString()), screen.DateTime);
                return true;
            }
            return false;
        }

        private void UpdateManagementID()
        {
            bookingModel.ManagementID = Int32.Parse(screen.ManagementName.SelectedValue.ToString());
        }
    }
}
