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

        public ListBox availableCourses
        {
            get { return lsbAvailableCourses; }
        }

        public void Register(EnrolNewCoursePresenter _presenter)
        {
            presenter = _presenter;
        }

        private void btnEnrol_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnrolNewCourse_Load(object sender, EventArgs e)
        {
            presenter.EnrolNewCourse_Load();
        }
    }
}
