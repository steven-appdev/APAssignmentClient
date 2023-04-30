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
    public partial class EnrolNewCourse : Form, IEnrolNewCourse
    {
        EnrolNewCoursePresenter presenter;

        public EnrolNewCourse()
        {
            InitializeComponent();
        }

        public DataGridView availableCourses
        {
            get { return dgvAvailableCourses; }
        }

        public Object GetSelectedNewCourse
        {
            get { return dgvAvailableCourses.SelectedRows[0].Cells[0].Value; }
        }

        public void Register(EnrolNewCoursePresenter _presenter)
        {
            presenter = _presenter;
        }

        private void btnEnrol_Click(object sender, EventArgs e)
        {
            if(presenter.btnEnrol_Click() == true)
            {
                this.Close();
            }
        }

        private void EnrolNewCourse_Load(object sender, EventArgs e)
        {
            dgvAvailableCourses.AutoGenerateColumns = false;
            presenter.EnrolNewCourse_Load();
        }

        private void btnViewCourseDescription_Click(object sender, EventArgs e)
        {
            presenter.btnViewCourseDescription_Click();
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
    }
}
