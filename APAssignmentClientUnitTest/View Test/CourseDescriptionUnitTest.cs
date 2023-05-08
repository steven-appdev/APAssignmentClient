using APAssignmentClient.View;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace APAssignmentClientUnitTest.ViewTest
{
    [TestClass]
    public class CourseDescriptionUnitTest
    {
        [TestMethod]
        public void TestMethod137()
        {
            ICourseDescription screen = new CourseDescription();
            screen.CourseID = "1";
            screen.CourseTitle = "Title";
            screen.CourseType = "Type";
            screen.Description = "Description";
            screen.CoursePrice  = "100";
            screen.CourseDuration = "0";
            screen.Status = "Status";
            screen.Date = "Date";

            Assert.AreEqual(screen.CourseID, "1");
            Assert.AreEqual(screen.CourseTitle, "Title");
            Assert.AreEqual(screen.CourseType, "Type");
            Assert.AreEqual(screen.Description, "Description");
            Assert.AreEqual(screen.CoursePrice, "100");
            Assert.AreEqual(screen.CourseDuration, "0");
            Assert.AreEqual(screen.Status, "Status");
            Assert.AreEqual(screen.Date, "Date");
        }
    }
}
