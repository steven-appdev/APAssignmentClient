using APAssignmentClient.Presenter;
using APAssignmentClientUnitTest.Mocs.ModelMocs;
using APAssignmentClientUnitTest.Mocs.ScreenMocs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace APAssignmentClientUnitTest.PresenterTest
{
    [TestClass]
    public class EnrolNewCoursePresenterUnitTest
    {
        [TestMethod]
        public void TestMethod129()
        {
            EnrolNewCourseMoc screen = new EnrolNewCourseMoc();
            ClientMoc clientModel = new ClientMoc();
            CourseMoc courseModel = new CourseMoc();
            EnrolNewCoursePresenter presenter = new EnrolNewCoursePresenter(screen, clientModel, courseModel);
            clientModel.ClientID = 1;
            presenter.EnrolNewCourse_Load();
            Assert.AreEqual(screen.AvailableCourses.Columns.Count, 5);
        }

        [TestMethod]
        public void TestMethod130()
        {

            EnrolNewCourseMoc screen = new EnrolNewCourseMoc();
            ClientMoc clientModel = new ClientMoc();
            CourseMoc courseModel = new CourseMoc();
            EnrolNewCoursePresenter presenter = new EnrolNewCoursePresenter(screen, clientModel, courseModel);
            clientModel.ClientID = 1;
            presenter.btnEnrol_Click();
            Assert.AreEqual(screen.Message, "Do you want to enrol the course?");
            Assert.AreEqual(screen.MessageTitle, "Enrolment Confirmation");
            Assert.IsTrue(courseModel.Enrolled);
        }
    }
}
