using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APAssignmentClient
{
    public partial class NewBooking : Form, INewBooking
    {
        NewBookingPresenter presenter;
        public NewBooking()
        {
            InitializeComponent();
        }

        public String GetDuration
        {
            get { return cmbSessionDuration.SelectedItem.ToString();  }
        }

        public DateTime DateTime
        {
            get { return dtSessionDate.Value; }
        }

        public String SupportSession
        {
            get { return txtbSupportSession.Text; }
            set { txtbSupportSession.Text = value; }
        }

        public ComboBox ManagementName
        {
            get { return cmbManagementName; }
        }

        public void Register(NewBookingPresenter _presenter)
        {
            presenter = _presenter;
        }

        public void AddName(String name)
        {
            cmbManagementName.Items.Add(name);
        }

        private void NewBooking_Load(object sender, EventArgs e)
        {
            presenter.NewBooking_Load();
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbManagementName_SelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.cmbManagementName_SelectedIndexChanged();
        }
    }
}
