using System;
using System.Data;
using System.Windows.Forms;
using APAssignmentClient.Presenter;

namespace APAssignmentClient.View
{
    public partial class AdminDashboard : Form, IAdminDashboard
    {
        AdminDashboardPresenter presenter;
        
        public AdminDashboard()
        {
            InitializeComponent();
        }


        public DataGridView AllCourses
        {
            get { return dgvAllCourses; }
        }

        public DataGridView AllClients 
        {
            get { return dgvAllClients; } 
        }

        public DataGridView AllStaffs 
        { 
            get { return dgvAllStaffs;}
        }

        public Object GetSelectedCourse
        {
            get { return dgvAllCourses.SelectedRows[0].Cells[0].Value; }
        }

        public Object GetSelectedClient
        {
            get { return dgvAllClients.SelectedRows[0].Cells[0].Value; }
        }

        public Object GetSelectedStaff
        {
            get { return dgvAllStaffs.SelectedRows[0].Cells[0].Value; }
        }

        public int GetCourseListCount
        {
            get { return dgvAllCourses.Rows.Count; }
        }

        public int GetClientListCount
        {
            get { return dgvAllCourses.Rows.Count; }
        }

        public int GetStaffListCount
        {
            get { return dgvAllCourses.Rows.Count; }
        }

        public void Register(AdminDashboardPresenter _presenter)
        {
            presenter = _presenter;
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

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            presenter.btnAddCourse_Click();
        }

        public void SetCourseListDataSource(DataTable dt)
        {
            dgvAllCourses.DataSource = dt;
        }

        public void SetClientListDataSource(DataTable dt)
        {
            dgvAllClients.DataSource = dt;
        }

        public void SetStaffListDataSource(DataTable dt)
        {
            dgvAllStaffs.DataSource = dt;
        }

        public void SetCourseButtonsEnabled(bool enabled)
        {
            btnEditCourse.Enabled = enabled;
            btnDeleteCourse.Enabled = enabled;
            btnViewCourse.Enabled = enabled;
        }

        public void SetClientButtonsEnabled(bool enabled)
        {
            btnViewClient.Enabled = enabled;
            btnDeleteClient.Enabled = enabled;
        }

        public void SetStaffButtonsEnabled(bool enabled)
        {
            btnViewStaff.Enabled = enabled;
            btnDeleteStaff.Enabled = enabled;
        }

        public void CloseForm()
        {
            this.Close();
        }

        private void Admin_Dashboard_Activated(object sender, EventArgs e)
        {
            presenter.Admin_Dashboard_Activated();
        }

        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            presenter.Admin_Dashboard_Load();
        }

        private void dgvAllCourses_DataSourceChanged(object sender, EventArgs e)
        {
            presenter.dgvAllCourses_DataSourceChanged();
        }

        private void dgvAllClients_DataSourceChanged(object sender, EventArgs e)
        {
            presenter.dgvAllClients_DataSourceChanged();
        }

        private void dgvAllStaffs_DataSourceChanged(object sender, EventArgs e)
        {
            presenter.dgvAllStaffs_DataSourceChanged();
        }

        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            presenter.btnEditCourse_Click();
        }

        private void btnViewCourse_Click(object sender, EventArgs e)
        {
            presenter.btnViewCourse_Click();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            presenter.btnDeleteCourse_Click();
        }

        private void btnViewClient_Click(object sender, EventArgs e)
        {
            presenter.btnViewClient_Click();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            presenter.btnDeleteClient_Click();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            presenter.btnAddStaff_Click();
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            presenter.btnEditStaff_Click();
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            presenter.btnDeleteStaff_Click();
        }
    }
}

