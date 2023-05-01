using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APAssignmentClient.Presenter;

namespace APAssignmentClient.View
{
    //Client Dashboard (View)

    public partial class ClientDashboard : Form, IClientDashboard
    {
        ClientDashboardPresenter presenter;

        public ClientDashboard()
        {
            InitializeComponent();
        }

        public String Username
        {
            set { lblUsername.Text = value; }
            get { return lblUsername.Text; }
        }

        public DataGridView EnrolledCourses
        {
            get { return dgvEnrolledCourses; }
        }

        public DataGridView BookedSession
        {
            get { return dgvBooking; }
        }

        public Object GetSelectedValue
        {
            get { return dgvEnrolledCourses.SelectedRows[0].Cells[0].Value; }
        }

        public Object GetSelectedBookingID
        {
            get { return dgvBooking.SelectedRows[0].Cells[0].Value; }
        }

        public int GetCourseListCount
        {
            get { return dgvEnrolledCourses.Rows.Count; }
        }

        public int GetBookingListCount
        {
            get { return dgvBooking.Rows.Count; }
        }

        public void Register(ClientDashboardPresenter _presenter)
        {
            presenter = _presenter;
        }

        private void ClientDashboard_Load(object sender, EventArgs e)
        {
            dgvEnrolledCourses.AutoGenerateColumns = false;
            dgvBooking.AutoGenerateColumns = false;
            presenter.ClientDashboard_Load();
        }

        private void btnEnrolNew_Click(object sender, EventArgs e)
        {
            presenter.btnEnrolNew_Click();
        }

        private void ClientDashboard_Activated(object sender, EventArgs e)
        {
            presenter.ClientDashboard_Activated();
        }

        private void btnDropCourse_Click(object sender, EventArgs e)
        {
            presenter.btnDropCourse_Click();
        }

        private void btnClientInformation_Click(object sender, EventArgs e)
        {
            presenter.btnClientInformation_Click();
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            presenter.btnNewBooking_Click();
        }

        private void btnDropBooking_Click(object sender, EventArgs e)
        {
            presenter.btnDropBooking_Click();
        }

        private void btnViewCourse_Click(object sender, EventArgs e)
        {
            presenter.btnViewCourse_Click();
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

        public void SetCourseListDataSource(DataTable dt)
        {
            dgvEnrolledCourses.DataSource = dt;
        }
        public void SetBookingListDataSource(DataTable dt)
        {
            dgvBooking.DataSource = dt;
        }

        public void SetCourseButtonsEnabled(bool enabled)
        {
            btnDropCourse.Enabled = enabled;
            btnViewCourse.Enabled = enabled;
        }

        public void SetBookingButtonsEnabled(bool enabled)
        {
            btnDropBooking.Enabled = enabled;
        }

        private void dgvBooking_DataSourceChanged(object sender, EventArgs e)
        {
            presenter.dgvBooking_DataSourceChanged();
        }

        private void dgvEnrolledCourses_DataSourceChanged(object sender, EventArgs e)
        {
            presenter.dgvEnrolledCourses_DataSourceChanged();
        }
    }
}
