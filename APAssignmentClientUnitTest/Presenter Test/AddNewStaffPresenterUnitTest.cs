using APAssignmentClient.Presenter;
using APAssignmentClientUnitTest.Mocs.ModelMocs;
using APAssignmentClientUnitTest.Mocs.ScreenMocs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace APAssignmentClientUnitTest.PresenterTest
{
    [TestClass]
    public class AddNewStaffPresenterUnitTest
    {
        [TestMethod]
        public void TestMethod114()
        {
            AddNewStaffMoc screen = new AddNewStaffMoc();
            CourseMoc courseModel = new CourseMoc();
            StaffMoc staffModel = new StaffMoc();
            AddNewStaffPresenter presenter = new AddNewStaffPresenter(screen, courseModel, staffModel, false);
            presenter.AddNewStaff_Load();
            Assert.AreEqual(screen.StaffID, "New");
            Assert.AreEqual(screen.dt.Columns.Count, 3);
        }

        [TestMethod]
        public void TestMethod115()
        {
            AddNewStaffMoc screen = new AddNewStaffMoc();
            CourseMoc courseModel = new CourseMoc();
            StaffMoc staffModel = new StaffMoc();
            AddNewStaffPresenter presenter = new AddNewStaffPresenter(screen, courseModel, staffModel, true);
            presenter.AddNewStaff_Load();
            Assert.AreEqual(screen.StaffID, "1");
            Assert.AreEqual(screen.StaffName, "Staff Name");
            Assert.AreEqual(screen.StaffSupportSession, "Support Session");
            Assert.AreEqual(screen.StaffCourseTaughtID, 1);
        }

        [TestMethod]
        public void TestMethod116()
        {
            AddNewStaffMoc screen = new AddNewStaffMoc();
            CourseMoc courseModel = new CourseMoc();
            StaffMoc staffModel = new StaffMoc();
            AddNewStaffPresenter presenter = new AddNewStaffPresenter(screen, courseModel, staffModel, false);
            screen.StaffName = "Test";
            screen.StaffSupportSession = "Test Desc";
            screen.StaffCourseTaughtID = 1;
            presenter.btnAddStaff_Click();
            Assert.AreEqual(screen.StaffName, staffModel.StaffName);
            Assert.AreEqual(screen.StaffSupportSession, staffModel.StaffSupportSession);
            Assert.AreEqual(screen.StaffCourseTaughtID, staffModel.StaffCourseTaughtID);
            Assert.IsTrue(screen.FormClosed);
        }
    }
}
