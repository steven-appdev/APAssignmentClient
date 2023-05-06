using APAssignmentClient.Model;
using APAssignmentClient.View;
using System;

namespace APAssignmentClient.Presenter
{
    public class NewRegisterPresenter
    {
        private INewRegister screen;
        private IAccountModel accountModel;

        public NewRegisterPresenter(INewRegister _screen, IAccountModel _accountModel)
        {
            screen = _screen;
            accountModel = _accountModel;
            screen.Register(this);
        }

        public void btnRegister_Click()
        {
            try
            {
                screen.SetRegisterButtonsEnabled(false);
                accountModel.Register(screen.Username, screen.Password, screen.FullName, screen.Address, screen.EmailAddress, screen.ContactNumber);
                screen.CloseForm();
            }
            catch (Exception e)
            {
                screen.SetRegisterButtonsEnabled(true);
                screen.DisplayErrorMessage(e.Message, "Oh no!");
            }
        }
    }
}
