using Microsoft.VisualStudio.TestTools.UnitTesting;
using APAssignmentClient.Presenter;
using APAssignmentClientUnitTest.Mocs.ModelMocs;
using APAssignmentClientUnitTest.Mocs.ScreenMocs;
using System;
using System.Drawing;
using System.ComponentModel;

namespace APAssignmentClientUnitTest.PresenterTest
{
    [TestClass]
    public class CourseDescriptionPresenterUnitTest
    {
        [TestMethod]
        public void TestMethod126()
        {
            CourseDescriptionMoc screen = new CourseDescriptionMoc();
            CourseMoc courseModel = new CourseMoc();
            ClientMoc clientModel = new ClientMoc();
            CourseDescriptionPresenter presenter = new CourseDescriptionPresenter(screen, clientModel, courseModel, false);
            presenter.CourseDescription_Load();
            Assert.AreEqual(screen.CourseID, "1");
            Assert.AreEqual(screen.CourseTitle, "Test");
            Assert.AreEqual(screen.Description, "Test Desc");
            Assert.AreEqual(screen.CourseType, "Video Course");
            Assert.AreEqual(screen.CourseDuration, "0");
            Assert.AreEqual(screen.CoursePrice, "0.00");
            Assert.AreEqual(screen.CloseButtonLocation, new Point(347, 286));
            Assert.AreEqual(screen.FormSize, new Size(515, 374));
        }

        [TestMethod]
        public void TestMethod127()
        {
            CourseDescriptionMoc screen = new CourseDescriptionMoc();
            CourseMoc courseModel = new CourseMoc();
            ClientMoc clientModel = new ClientMoc();
            CourseDescriptionPresenter presenter = new CourseDescriptionPresenter(screen, clientModel, courseModel, true);
            presenter.CourseDescription_Load();
            Assert.AreEqual(screen.CourseID, "1");
            Assert.AreEqual(screen.CourseTitle, "Test");
            Assert.AreEqual(screen.Description, "Test Desc");
            Assert.AreEqual(screen.CourseType, "Video Course");
            Assert.AreEqual(screen.CourseDuration, "0");
            Assert.AreEqual(screen.CoursePrice, "0.00");
            Assert.AreEqual(screen.CloseButtonLocation, new Point(347, 339));
            Assert.AreEqual(screen.FormSize, new Size(515, 421));
            Assert.IsTrue(screen.DateLabelVisible);
            Assert.IsTrue(screen.DateVisible);
            Assert.IsTrue(screen.StatusLabelVisible);
            Assert.IsTrue(screen.StatusVisible);
            Assert.AreEqual(screen.Status, "Course will started on");
            Assert.AreEqual(screen.Date, "Returned date");
            Assert.IsTrue(screen.WaitingListButton);
        }

        [TestMethod]
        public void TestMethod128()
        {
            CourseDescriptionMoc screen = new CourseDescriptionMoc();
            CourseMoc courseModel = new CourseMoc();
            ClientMoc clientModel = new ClientMoc();
            CourseDescriptionPresenter presenter = new CourseDescriptionPresenter(screen, clientModel, courseModel, true);
            screen.CourseID = "1";
            presenter.btnPlaceBackToWaiting_Click();
            Assert.AreEqual(screen.Message, "Do you want to place back to the waiting list?");
            Assert.AreEqual(screen.MessageTitle, "Are you sure?");
            Assert.IsTrue(courseModel.Returned);
            Assert.IsFalse(screen.WaitingListButton);
        }
    }
}
