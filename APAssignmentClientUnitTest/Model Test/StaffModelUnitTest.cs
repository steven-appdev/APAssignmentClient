using APAssignmentClient.Model;
using APAssignmentClient.DataService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace APAssignmentClientUnitTest.ModelTest
{
    [TestClass]
    public class StaffModelUnitTest
    {
        private IStaffModel staffModel;

        public StaffModelUnitTest()
        {
            staffModel = StaffModel.GetInstance();
        }

        [TestMethod]
        public void TestMethod98()
        {
            staffModel.StaffID = 1;
            Assert.AreEqual(1, staffModel.StaffID);
        }

        [TestMethod]
        public void TestMethod99()
        {
            try
            {
                DataTable dt = staffModel.RetrieveAllStaffs();
                Assert.AreEqual(dt.Columns.Count, 4);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod100()
        {
            try
            {
                staffModel.StaffID = 1;
                int length = staffModel.RetrieveStaffInformation().Length;
                Assert.AreEqual(length, 3);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod101()
        {
            try
            {
                staffModel.StaffID = 99;
                staffModel.RetrieveStaffInformation();
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod102()
        {
            try
            {
                int originalCourseTaught = 99;
                staffModel.StaffID = 1;
                int updatedCourseTaught = staffModel.RetrieveStaffCourseTaughtID();
                Assert.AreNotEqual(originalCourseTaught, updatedCourseTaught);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod103()
        {
            try
            {
                staffModel.StaffID = 99;
                staffModel.RetrieveStaffCourseTaughtID();
            }
            catch (Exception e) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod104()
        {
            try
            {
                int originalLength = staffModel.RetrieveAllStaffs().Rows.Count;
                staffModel.AddNewStaff("Test Management", "Test Support Session", 1);
                int updatedLength = staffModel.RetrieveAllStaffs().Rows.Count;
                Assert.AreNotEqual(originalLength, updatedLength);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod105()
        {
            try
            {
                staffModel.AddNewStaff(null, null, 0);
            }
            catch (Exception e) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod106()
        {
            try
            {
                staffModel.StaffID = 10;
                String[] oldData = staffModel.RetrieveStaffInformation();
                int oldCourseID = staffModel.RetrieveStaffCourseTaughtID();
                staffModel.EditNewStaff("Edit Management", "Edit Support Session", 2);
                String[] newData = staffModel.RetrieveStaffInformation();
                int newCourseID = staffModel.RetrieveStaffCourseTaughtID();
                Assert.AreNotEqual(oldData[1], newData[1]);
                Assert.AreNotEqual(oldData[2], newData[2]);
                Assert.AreNotEqual(oldCourseID, newCourseID);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod107()
        {
            try
            {
                staffModel.StaffID = 10;
                staffModel.EditNewStaff(null, null, 1);
            }
            catch (Exception e) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod108()
        {
            try
            {
                int originalLength = staffModel.RetrieveAllStaffs().Rows.Count;
                staffModel.StaffID = 10;
                staffModel.DeleteStaff();
                int updatedLength = staffModel.RetrieveAllStaffs().Rows.Count;
                Assert.AreNotEqual(originalLength, updatedLength);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod109()
        {
            try
            {
                staffModel.StaffID = 99;
                staffModel.DeleteStaff();
            }
            catch (Exception e) {/* Test Pass*/}
        }
    }
}
