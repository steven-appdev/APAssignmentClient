using APAssignmentClient.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClient.View
{
    public partial class NewRegister : Form, INewRegister
    {
        private NewRegisterPresenter presenter;

        public NewRegister()
        {
            InitializeComponent();
        }

        public String Username
        {
            get { return txtbUsername.Text; }
        }

        public String Password
        {
            get { return txtbPassword.Text; }
        }

        public String FullName
        {
            get { return txtbName.Text; }
        }

        public String Address
        {
            get { return txtbAddress.Text; }
        }

        public String EmailAddress
        {
            get { return txtbEmail.Text; }
        }

        public String ContactNumber
        {
            get { return txtbContact.Text; }
        }

        public void SetRegisterButtonsEnabled(bool enabled)
        {
            btnRegister.Enabled = enabled;
        }

        public void DisplayErrorMessage(String msg, String title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Register(NewRegisterPresenter _presenter)
        {
            presenter = _presenter;
        }

        public void CloseForm()
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            presenter.btnRegister_Click();
        }
    }
}
