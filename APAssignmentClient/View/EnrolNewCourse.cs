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
            presenter.EnrolNewCourse_Load();
        }

        private void btnViewCourseDescription_Click(object sender, EventArgs e)
        {
            presenter.btnViewCourseDescription_Click();
        }
    }
}
