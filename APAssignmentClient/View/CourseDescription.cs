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
    public partial class CourseDescription : Form, ICourseDescription
    {
        CourseDescriptionPresenter presenter;

        public CourseDescription()
        {
            InitializeComponent();
        }

        public String CourseID
        {
            get { return txtbCourseID.Text; }
            set { txtbCourseID.Text = value; }
        }

        public String CourseTitle
        {
            get { return txtbCourseTitle.Text; }
            set { txtbCourseTitle.Text = value; }
        }

        public String Description
        {
            get { return rtxtbDescription.Text; }
            set { rtxtbDescription.Text = value; }
        }

        public void Register(CourseDescriptionPresenter _presenter)
        {
            presenter = _presenter;
        }

        private void CourseDescription_Load(object sender, EventArgs e)
        {
            presenter.CourseDescription_Load();
        }
    }
}
