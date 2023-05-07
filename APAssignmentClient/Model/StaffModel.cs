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
        private Management management;

        private StaffModel()
        {
            management = new Management();
            access = new DataAccess();
        }

        public int StaffID
        {
            set { management.ManagementId = value; }
            get { return management.ManagementId; }
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

        public String[] RetrieveStaffInformation()
        {
            try
            {
                return access.RetrieveOneManagement(management.ManagementId).ToStringArray();
            }
            catch (Exception e)
            {
                throw new Exception (e.Message);
            }
        }

        public int RetrieveStaffCourseTaughtID()
        {
            try
            {
                return access.RetrieveManagementCourseID(management.ManagementId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void AddNewStaff(String name, String supportSession, int courseID)
        {
            try
            {
                if(name != null && supportSession != null)
                {
                    Management management = new Management
                    {
                        ManagementName = name,
                        ManagementSupportSession = supportSession
                    };
                    access.AddNewManagement(management, courseID);
                }
                else
                {
                    throw new Exception("Text box cannot be empty!");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void EditNewStaff(String name, String supportSession, int courseID)
        {
            try
            {
                if (name != null && supportSession != null)
                {
                    Management management = new Management
                    {
                        ManagementId = StaffID,
                        ManagementName = name,
                        ManagementSupportSession = supportSession
                    };
                    access.EditManagement(management, courseID);
                }
                else
                {
                    throw new Exception("Text box cannot be empty!");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteStaff()
        {
            try
            {
                access.DeleteManagement(StaffID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }

}
