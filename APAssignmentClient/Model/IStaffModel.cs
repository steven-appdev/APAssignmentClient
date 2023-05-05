using APAssignmentClient.DataService;
using System;
using System.Data;

namespace APAssignmentClient.Model
{
    public interface IStaffModel
    {
        int StaffID { get; set; }
        DataTable RetrieveAllStaffs();
        String[] RetrieveStaffInformation();
        String RetrieveStaffCourseTaught();
        int RetrieveStaffCourseTaughtID();
        void AddNewStaff(String name, String supportSession, int courseID);
        void EditNewStaff(String name, String supportSession, int courseID);
        void DeleteStaff();
    }
}
