using APAssignmentClient.Model;
using APAssignmentClient.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient.Presenter
{
    public class AddNewStaffPresenter
    {
        private IAddNewStaff screen;
        private ICourseModel courseModel;
        private IStaffModel staffModel;
        private bool editMode;

        public AddNewStaffPresenter(IAddNewStaff _screen, ICourseModel _courseModel, IStaffModel _staffModel, bool _editMode)
        {
            screen = _screen;
            courseModel = _courseModel;
            staffModel = _staffModel;
            editMode = _editMode;
            screen.Register(this);
            
        }

        public void AddNewStaff_Load()
        {
            PopulateCourseComboBox();
            if (editMode)
            {
                String[] staff = staffModel.RetrieveStaffInformation();
                screen.StaffID = staff[0];
                screen.StaffName = staff[1];
                screen.StaffSupportSession = staff[2];
                screen.StaffCourseTaughtID = staffModel.RetrieveStaffCourseTaughtID();
            }
            else
            {
                screen.StaffID = "New";
            }
        }

        public void btnAddStaff_Click()
        {
            try
            {
                if (!editMode)
                {
                    staffModel.AddNewStaff(screen.StaffName, screen.StaffSupportSession, screen.StaffCourseTaughtID);
                    screen.CloseForm();
                }
                else
                {
                    staffModel.EditNewStaff(screen.StaffName, screen.StaffSupportSession, screen.StaffCourseTaughtID);
                    screen.CloseForm();
                }
            }
            catch (Exception e)
            {
                screen.DisplayErrorMessage(e.Message, "Opps!");
            }
        }

        private void PopulateCourseComboBox()
        {
            DataTable dt = courseModel.RetrieveAllCourses();
            screen.SetCourseTaughtData("id", "name", dt);
        }
    }
}
