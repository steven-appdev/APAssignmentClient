using APAssignmentClientUnitTest.Mocs.ScreenMocs;
using APAssignmentClientUnitTest.Mocs.ModelMocs;
using APAssignmentClient.Presenter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace APAssignmentClientUnitTest.PresenterTest
{
    [TestClass]
    public class AddNewCoursePresenterUnitTest
    {
        [TestMethod]
        public void TestMethod111()
        {
            AddNewCourseMoc screen = new AddNewCourseMoc();
            CourseMoc courseModel = new CourseMoc();
            AddNewCoursePresenter presenter = new AddNewCoursePresenter(screen, courseModel, false);
            presenter.AddNewCourse_Load();
            Assert.AreEqual(screen.CourseID, "New");
        }

        [TestMethod]
        public void TestMethod112()
        {
            AddNewCourseMoc screen = new AddNewCourseMoc();
            CourseMoc courseModel = new CourseMoc();
            AddNewCoursePresenter presenter = new AddNewCoursePresenter(screen, courseModel, true);
            presenter.AddNewCourse_Load();
            Assert.AreEqual(screen.CourseID, "1");
            Assert.AreEqual(screen.CourseTitle, "Test");
            Assert.AreEqual(screen.Description, "Test Desc");
            Assert.AreEqual(screen.CourseType, "Video Course");
            Assert.AreEqual(screen.CourseDuration, "0");
            Assert.AreEqual(screen.CoursePrice, "0");
        }

        [TestMethod]
        public void TestMethod113()
        {
            AddNewCourseMoc screen = new AddNewCourseMoc();
            CourseMoc courseModel = new CourseMoc();
            AddNewCoursePresenter presenter = new AddNewCoursePresenter(screen, courseModel, false);
            screen.CourseTitle = "Test";
            screen.Description = "Test Desc";
            screen.CoursePrice = "0.00";
            screen.CourseType = "Practical Course";
            screen.CourseDuration = "0";
            presenter.AddButton_Click();
            Assert.AreEqual(screen.CourseTitle, courseModel.CourseName);
            Assert.AreEqual(double.Parse(screen.CoursePrice), courseModel.CoursePrice);
            Assert.AreEqual(screen.CourseType, courseModel.CourseType);
            Assert.AreEqual(Int32.Parse(screen.CourseDuration), courseModel.CourseDuration);
            Assert.AreEqual(screen.Description, courseModel.CourseDescription);
            Assert.IsTrue(screen.FormClosed);
        }
    }
}
