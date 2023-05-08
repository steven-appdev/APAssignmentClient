using APAssignmentClient.View;
using APAssignmentClientUnitTest.Mocs.ScreenMocs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace APAssignmentClientUnitTest.ViewTest
{
    [TestClass]
    public class AddNewCourseUnitTest
    {
        [TestMethod]
        public void TestMethod133()
        {
            IAddNewCourse screen = new AddNewCourse();
            screen.CourseID = "1";
            screen.CourseTitle = "Test";
            screen.Description = "Test Description";
            screen.CourseType = "Video Course";
            screen.CoursePrice = "0.00";
            screen.CourseDuration = "0";
            Assert.AreEqual(screen.CourseID, "1");
            Assert.AreEqual(screen.CourseTitle, "Test");
            Assert.AreEqual(screen.Description, "Test Description");
            Assert.AreEqual(screen.CourseType, "Video Course");
            Assert.AreEqual(screen.CoursePrice, "0.00");
            Assert.AreEqual(screen.CourseDuration, "0");
        }
    }
}
