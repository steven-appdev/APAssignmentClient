using System;
using System.Windows.Forms;
using APAssignmentClient.Presenter;

namespace APAssignmentClient.View
{
    public partial class AddNewCourse : Form, IAddNewCourse
    {
        private AddNewCoursePresenter presenter;

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
        public String CourseType
        {
            get { return cmbCourseType.SelectedItem.ToString(); }
            set { cmbCourseType.SelectedItem = value; }
        }

        public String CoursePrice
        {
            get { return txtbCoursePrice.Text; }
            set { txtbCoursePrice.Text = value; }
        }

        public String CourseDuration
        {
            get { return txtbCourseDuration.Text; }
            set { txtbCourseDuration.Text = value; }
        }

        public AddNewCourse()
        {
            InitializeComponent();
        }

        public void Register(AddNewCoursePresenter _presenter)
        {
            presenter = _presenter;
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            presenter.AddButton_Click();
        }

        public void CloseForm()
        {
            this.Close();
        }

        private void AddNewCourse_Load(object sender, EventArgs e)
        {
            cmbCourseType.SelectedIndex = 0;
            presenter.AddNewCourse_Load();
        }

        public void DisplayErrorMessage(String msg, String title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
