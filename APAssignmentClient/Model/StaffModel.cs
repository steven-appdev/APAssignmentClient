using System;
using System.Collections.Generic;
using APAssignmentClient.DataService;
using System.Data;

namespace APAssignmentClient.Model
{
    public class StaffModel : IStaffModel
    {
        private static StaffModel _instance = null;
        IDataAccess access;
        private StaffModel staff;

        private StaffModel()
        {
            access = new DataAccess();
        }

        public static StaffModel GetInstance()
        {
            if (_instance == null)
            {
                _instance = new StaffModel();
            }
            return _instance;
        }

        public DataTable RetrieveAllStaffs()
        {
            try
            {            
                List<Management> retrievedStaffs = access.RetrieveAllManagement();
                

                DataTable dt = new DataTable();
                dt.Columns.Add("id");
                dt.Columns.Add("name");
                dt.Columns.Add("course");
                dt.Columns.Add("support");
                foreach (Management m in retrievedStaffs)
                {
                    dt.Rows.Add(m.ManagementId.ToString(), m.ManagementName, access.RetrieveManagementCourse(m.ManagementId), m.ManagementSupportSession);
                }
                return dt;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }

}
