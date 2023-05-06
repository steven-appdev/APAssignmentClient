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
    public partial class Login : Form, ILogin
    {
        private LoginPresenter presenter;

        public Login()
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

        public void SetAccountButtonsEnabled(bool enabled)
        {
            btnLogin.Enabled = enabled;
            btnRegister.Enabled = enabled;
        }

        public void Register(LoginPresenter _presenter)
        {
            presenter = _presenter;
        }

        public void DisplayErrorMessage(String msg, String title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void HideForm()
        {
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            presenter.btnLogin_Click();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            presenter.btnRegister_Click();
        }
    }
}
