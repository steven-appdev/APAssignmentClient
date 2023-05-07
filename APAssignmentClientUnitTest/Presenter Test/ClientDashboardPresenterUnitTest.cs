using APAssignmentClient.Presenter;
using APAssignmentClientUnitTest.Mocs.ModelMocs;
using APAssignmentClientUnitTest.Mocs.ScreenMocs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace APAssignmentClientUnitTest.PresenterTest
{
    [TestClass]
    public class ClientDashboardPresenterUnitTest
    {
        [TestMethod]
        public void TestMethod121()
        {
            ClientDashboardMoc screen = new ClientDashboardMoc();
            CourseMoc courseModel = new CourseMoc();
            ClientMoc clientModel = new ClientMoc();
            BookMoc bookingModel = new BookMoc();
            ClientDashboardPresenter presenter = new ClientDashboardPresenter(screen, clientModel, courseModel, bookingModel);
            clientModel.ClientName = "Test";
            presenter.ClientDashboard_Load();
            Assert.AreEqual(screen.Username, clientModel.ClientName);
            Assert.AreEqual(screen.CourseList.Columns.Count, 5);
            Assert.AreEqual(screen.BookingList.Columns.Count, 4);
        }

        [TestMethod]
        public void TestMethod122()
        {
            ClientDashboardMoc screen = new ClientDashboardMoc();
            CourseMoc courseModel = new CourseMoc();
            ClientMoc clientModel = new ClientMoc();
            BookMoc bookingModel = new BookMoc();
            ClientDashboardPresenter presenter = new ClientDashboardPresenter(screen, clientModel, courseModel, bookingModel);
            presenter.ClientDashboard_Activated();
            Assert.IsTrue(clientModel.Updated);
        }

        [TestMethod]
        public void TestMethod123()
        {
            ClientDashboardMoc screen = new ClientDashboardMoc();
            CourseMoc courseModel = new CourseMoc();
            ClientMoc clientModel = new ClientMoc();
            BookMoc bookingModel = new BookMoc();
            ClientDashboardPresenter presenter = new ClientDashboardPresenter(screen, clientModel, courseModel, bookingModel);
            presenter.btnDropCourse_Click();
            Assert.IsTrue(courseModel.Dropped);
            Assert.AreEqual(screen.ErrorMsg, "Do you want to drop this course?");
            Assert.AreEqual(screen.ErrorTitle, "Are you sure?");
        }

        [TestMethod]
        public void TestMethod124()
        {
            ClientDashboardMoc screen = new ClientDashboardMoc();
            CourseMoc courseModel = new CourseMoc();
            ClientMoc clientModel = new ClientMoc();
            BookMoc bookingModel = new BookMoc();
            ClientDashboardPresenter presenter = new ClientDashboardPresenter(screen, clientModel, courseModel, bookingModel);
            presenter.btnDropBooking_Click();
            Assert.IsTrue(bookingModel.Dropped);
            Assert.AreEqual(bookingModel.BookingID, 1);
            Assert.AreEqual(screen.ErrorMsg, "Do you want to drop this booking?");
            Assert.AreEqual(screen.ErrorTitle, "Are you sure?");
        }
    }
}
