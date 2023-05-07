using APAssignmentClient.Presenter;
using APAssignmentClientUnitTest.Mocs.ModelMocs;
using APAssignmentClientUnitTest.Mocs.ScreenMocs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace APAssignmentClientUnitTest.PresenterTest
{
    [TestClass]
    public class AdminDashboardPresenterUnitTest
    {
        [TestMethod]
        public void TestMethod117()
        {
            AdminDashboardMoc screen = new AdminDashboardMoc();
            CourseMoc courseModel = new CourseMoc();
            ClientMoc clientModel = new ClientMoc();
            StaffMoc staffModel = new StaffMoc();
            AdminDashboardPresenter presenter = new AdminDashboardPresenter(screen, courseModel, clientModel, staffModel);
            presenter.Admin_Dashboard_Load();
            Assert.AreEqual(screen.Courses.Columns.Count, 3);
            Assert.AreEqual(screen.Clients.Columns.Count, 5);
            Assert.AreEqual(screen.Staffs.Columns.Count, 4);
        }

        [TestMethod]
        public void TestMethod118()
        {
            AdminDashboardMoc screen = new AdminDashboardMoc();
            CourseMoc courseModel = new CourseMoc();
            ClientMoc clientModel = new ClientMoc();
            StaffMoc staffModel = new StaffMoc();
            AdminDashboardPresenter presenter = new AdminDashboardPresenter(screen, courseModel, clientModel, staffModel);
            presenter.btnDeleteCourse_Click();
            Assert.AreEqual(courseModel.CourseID, 1);
            Assert.IsTrue(courseModel.Deleted);
            Assert.AreEqual(screen.message, "Do you want to delete this course?");
            Assert.AreEqual(screen.msgTitle, "Warning! Are you sure?");
        }

        [TestMethod]
        public void TestMethod119()
        {
            AdminDashboardMoc screen = new AdminDashboardMoc();
            CourseMoc courseModel = new CourseMoc();
            ClientMoc clientModel = new ClientMoc();
            StaffMoc staffModel = new StaffMoc();
            AdminDashboardPresenter presenter = new AdminDashboardPresenter(screen, courseModel, clientModel, staffModel);
            presenter.btnDeleteClient_Click();
            Assert.AreEqual(clientModel.Client.ClientId, 1);
            Assert.IsTrue(clientModel.Deleted);
            Assert.AreEqual(screen.message, "Do you want to delete this client?");
            Assert.AreEqual(screen.msgTitle, "Warning! Are you sure?");
        }

        [TestMethod]
        public void TestMethod120()
        {
            AdminDashboardMoc screen = new AdminDashboardMoc();
            CourseMoc courseModel = new CourseMoc();
            ClientMoc clientModel = new ClientMoc();
            StaffMoc staffModel = new StaffMoc();
            AdminDashboardPresenter presenter = new AdminDashboardPresenter(screen, courseModel, clientModel, staffModel);
            presenter.btnDeleteStaff_Click();
            Assert.AreEqual(staffModel.StaffID, 1);
            Assert.IsTrue(staffModel.Deleted);
            Assert.AreEqual(screen.message, "Do you want to delete this staff?");
            Assert.AreEqual(screen.msgTitle, "Warning! Are you sure?");
        }
    }
}
