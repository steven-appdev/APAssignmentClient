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
    public partial class AddNewStaff : Form, IAddNewStaff
    {
        private AddNewStaffPresenter presenter;

        public AddNewStaff()
        {
            InitializeComponent();
        }

        public String StaffID
        {
            get { return txtbStaffID.Text; }
            set { txtbStaffID.Text = value; }
        }

        public String StaffName
        {
            get { return txtbStaffName.Text; }
            set { txtbStaffName.Text = value; }
        }

        public int StaffCourseTaughtID
        {
            get { return Int32.Parse(cmbCourseTaught.SelectedValue.ToString()); }
            set { cmbCourseTaught.SelectedValue = value; }
        }

        public String StaffCourseTaught
        {
            get { return cmbCourseTaught.SelectedItem.ToString(); }
        }

        public String StaffSupportSession
        {
            get { return txtbSupportSession.Text; }
            set { txtbSupportSession.Text = value; }
        }

        public void SetCourseTaughtData(String value, String display, DataTable dt)
        {
            cmbCourseTaught.ValueMember = value;
            cmbCourseTaught.DisplayMember = display;
            cmbCourseTaught.DataSource = dt;
        }

        public bool DisplayConfirmationMessage(String msg, String title)
        {
            DialogResult result = MessageBox.Show(msg, title, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        public void DisplayErrorMessage(String msg, String title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Register(AddNewStaffPresenter _presenter)
        {
            presenter = _presenter;
        }

        public void CloseForm()
        {
            this.Close();
        }

        private void AddNewStaff_Load(object sender, EventArgs e)
        {
            presenter.AddNewStaff_Load();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            presenter.btnAddStaff_Click();
        }
    }
}
