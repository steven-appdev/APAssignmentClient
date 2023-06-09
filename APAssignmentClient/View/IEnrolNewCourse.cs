﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APAssignmentClient.Presenter;

namespace APAssignmentClient.View
{
    public interface IEnrolNewCourse
    {
        DataGridView availableCourses { get; }
        Object GetSelectedNewCourse { get; }
        void Register(EnrolNewCoursePresenter presenter);
        bool DisplayConfirmationMessage(String msg, String title);
        void DisplayErrorMessage(String msg, String title);
        void SetNewCourseListDataSource(DataTable dt);
        void CloseForm();
    }
}
