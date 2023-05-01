using System;
using APAssignmentClient.View;
using APAssignmentClient.Model;
using System.Data;
using System.Windows.Forms;

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
            try
            {
                DataTable managements = bookingModel.RetrieveAllManagement();
                screen.SetManagementNameData("id", "name", managements);
            }
            catch (Exception e)
            {
                screen.DisplayErrorMessage(e.Message, "Opps!");
                screen.CloseForm();
            }
        }

        public void cmbManagementName_SelectedIndexChanged()
        {
            UpdateManagementID();
            try
            {
                screen.SupportSession = bookingModel.RetrieveSupportSession();
            }
            catch(Exception e)
            {
                screen.DisplayErrorMessage(e.Message, "Opps!");
            }
        }

        public void btnConfirmBooking_Click()
        {
            bool result = screen.DisplayConfirmationMessage("Do you want to create this booking?", "Booking Confirmation");
            if (result == true)
            {
                UpdateManagementID();
                try
                {
                    bookingModel.AddNewBooking(clientModel.ClientID, Int32.Parse(screen.Duration.SelectedItem.ToString()), screen.DateTime);
                    screen.CloseForm();
                }
                catch (Exception e)
                {
                    screen.DisplayErrorMessage(e.Message, "Opps!");
                }
            }
        }

        private void UpdateManagementID()
        {
            bookingModel.ManagementID = Int32.Parse(screen.ManagementName.SelectedValue.ToString());
        }
    }
}
