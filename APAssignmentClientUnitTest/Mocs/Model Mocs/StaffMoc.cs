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
        int IStaffModel.StaffID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IStaffModel.AddNewStaff(string name, string supportSession, int courseID)
        {
            throw new NotImplementedException();
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

        int IStaffModel.RetrieveStaffCourseTaughtID()
        {
            throw new NotImplementedException();
        }

        string[] IStaffModel.RetrieveStaffInformation()
        {
            throw new NotImplementedException();
        }
    }
}
