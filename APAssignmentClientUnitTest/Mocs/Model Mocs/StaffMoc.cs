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
        public bool Deleted { get; set; }

        public void AddNewStaff(string name, string supportSession, int courseID)
        {
            StaffName = name;
            StaffSupportSession = supportSession;
            StaffCourseTaughtID = courseID;
        }

        public void DeleteStaff()
        {
            Deleted = true;
        }

        void IStaffModel.EditNewStaff(string name, string supportSession, int courseID)
        {
            throw new NotImplementedException();
        }

        public DataTable RetrieveAllStaffs()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("course");
            dt.Columns.Add("support");
            return dt;
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
