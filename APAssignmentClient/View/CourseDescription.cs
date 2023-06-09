﻿using System;
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

        public String CourseType
        {
            get { return txtbCourseType.Text; }
            set { txtbCourseType.Text = value; }
        }

        public String Description
        {
            get { return rtxtbDescription.Text; }
            set { rtxtbDescription.Text = value; }
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

        public String Status
        {
            get { return txtbCourseStatus.Text; }
            set { txtbCourseStatus.Text = value; }
        }

        public bool StatusVisible
        {
            get { return txtbCourseStatus.Visible; }
            set { txtbCourseStatus.Visible = value; }
        }

        public bool StatusLabelVisible
        {
            get { return lblCourseStatus.Visible; }
            set { lblCourseStatus.Visible = value; }
        }

        public String Date
        {
            get { return txtbCourseDate.Text; }
            set { txtbCourseDate.Text = value; }
        }

        public bool DateVisible
        {
            get { return txtbCourseDate.Visible; }
            set { txtbCourseDate.Visible = value; }
        }

        public bool DateLabelVisible
        {
            get { return lblCourseDate.Visible; }
            set { lblCourseDate.Visible = value; }
        }

        public bool WaitingListButton
        {
            get { return btnPlaceBackToWaiting.Visible; }
            set { btnPlaceBackToWaiting.Visible = value; }
        }

        public Size FormSize 
        { 
            get { return Size; }
            set { Size = value; }
        }

        public Point CloseButtonLocation
        {
            get { return btnClose.Location; }
            set { btnClose.Location = value; }
        }

        public void Register(CourseDescriptionPresenter _presenter)
        {
            presenter = _presenter;
        }

        private void CourseDescription_Load(object sender, EventArgs e)
        {
            presenter.CourseDescription_Load();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlaceBackToWaiting_Click(object sender, EventArgs e)
        {
            presenter.btnPlaceBackToWaiting_Click();
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

        public void CloseForm()
        {
            this.Close();
        }
    }
}
