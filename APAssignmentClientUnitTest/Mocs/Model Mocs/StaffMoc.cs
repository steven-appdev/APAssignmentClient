using APAssignmentClient.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClientUnitTest.Mocs.ModelMocs
{
    public class StaffMoc : IStaffModel
    {
        public int StaffID { get; set; }
        public String StaffName { get; set; }
        public String StaffSupportSession { get; set; }
        public int StaffCourseTaughtID { get; set; }

        public void AddNewStaff(string name, string supportSession, int courseID)
        {
            StaffName = name;
            StaffSupportSession = supportSession;
            StaffCourseTaughtID = courseID;
        }

        void IStaffModel.DeleteStaff()
        {
            throw new NotImplementedException();
        }

        void IStaffModel.EditNewStaff(string name, string supportSession, int courseID)
        {
            throw new NotImplementedException();
        }

        DataTable IStaffModel.RetrieveAllStaffs()
        {
            throw new NotImplementedException();
        }

        public int RetrieveStaffCourseTaughtID()
        {
            return 1;
        }

        public String[] RetrieveStaffInformation()
        {
            return new string[] { "1", "Staff Name", "Support Session" };
        }
    }
}
