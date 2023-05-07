using APAssignmentClient.Model;
using APAssignmentClient.DataService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace APAssignmentClientUnitTest.ModelTest
{
    [TestClass]
    public class CourseModelUnitTest
    {
        private ICourseModel courseModel;

        public CourseModelUnitTest()
        {
            courseModel = CourseModel.GetInstance();
        }

        [TestMethod]
        public void TestMethod78()
        {
            courseModel.CourseID = 1;
            Assert.AreEqual(1, courseModel.CourseID);
        }

        [TestMethod]
        public void TestMethod79()
        {
            try
            {
                DataTable dt = courseModel.RetrieveAllCourses();
                Assert.AreEqual(dt.Columns.Count, 3);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod80()
        {
            try
            {
                DataTable dt = courseModel.RetrieveEnrollableCourses(5);
                Assert.AreEqual(dt.Columns.Count, 5);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod81()
        {
            try
            {
                int originalLength = courseModel.RetrieveAllCourses().Rows.Count;
                courseModel.AddNewCourse("New Unit Test Course", "Unit Test Description", 0.00, "Practical Course", 0);
                int updatedLength = courseModel.RetrieveAllCourses().Rows.Count;
                Assert.AreNotEqual(originalLength, updatedLength);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod82()
        {
            try
            {
                courseModel.AddNewCourse(null, null, 0.00, null, 0);
            }
            catch (Exception e) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod83()
        {
            try
            {
                courseModel.CourseID = 11;
                String[] oldData = courseModel.RetrieveCourseInformation();
                courseModel.EditCourse(11, "Edit Unit Test", "Edit Description", 1000.00, "Video Course", 10);
                String[] newData = courseModel.RetrieveCourseInformation();
                Assert.AreNotEqual(oldData[1], newData[1]);
                Assert.AreNotEqual(oldData[2], newData[2]);
                Assert.AreNotEqual(oldData[3], newData[3]);
                Assert.AreNotEqual(oldData[4], newData[4]);
                Assert.AreNotEqual(oldData[5], newData[5]);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod84()
        {
            try
            {
                courseModel.EditCourse(11, null, null, 0.00, null, 0);
            }
            catch (Exception e) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod85()
        {
            try
            {
                int originalLength = courseModel.RetrieveAllCourses().Rows.Count;
                courseModel.CourseID = 11;
                courseModel.DeleteCourse();
                int updatedLength = courseModel.RetrieveAllCourses().Rows.Count;
                Assert.AreNotEqual(originalLength, updatedLength);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod86()
        {
            try
            {
                courseModel.CourseID = 99;
                courseModel.DeleteCourse();
            }
            catch (Exception e) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod87()
        {
            try
            {
                courseModel.CourseID = 1;
                int length = courseModel.RetrieveCourseInformation().Length;
                Assert.AreEqual(length, 6);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod88()
        {
            try
            {
                courseModel.CourseID = 99;
                courseModel.RetrieveCourseInformation();
            }
            catch (Exception e) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod89()
        {
            try
            {
                int originalLength = courseModel.RetrieveEnrolledCourses(5).Rows.Count;
                courseModel.EnrolSelectedCourse(5, 2);
                int updatedLength = courseModel.RetrieveEnrolledCourses(5).Rows.Count;
                Assert.AreNotEqual(originalLength, updatedLength);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod90()
        {
            try
            {
                courseModel.EnrolSelectedCourse(99, 99);
            }
            catch (Exception e) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod91()
        {
            try
            {
                int originalLength = courseModel.RetrieveEnrolledCourses(5).Rows.Count;
                courseModel.DropSelectedCourse(5, 2);
                int updatedLength = courseModel.RetrieveEnrolledCourses(5).Rows.Count;
                Assert.AreNotEqual(originalLength, updatedLength);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod92()
        {
            try
            {
                courseModel.DropSelectedCourse(99, 99);
            }
            catch (Exception e) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod93()
        {
            try
            {
                DataTable dt = courseModel.RetrieveEnrolledCourses(5);
                Assert.AreEqual(dt.Columns.Count, 4);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod94()
        {
            try
            {
                String courseStatus = courseModel.RetrieveCourseStatus(5, 1);
                Assert.AreEqual(courseStatus, "Course Ready");
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod95()
        {
            try
            {
                courseModel.RetrieveCourseStatus(99, 99);
            }
            catch (Exception e) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod96()
        {
            try
            {
                String startDate = courseModel.RetrieveCourseStartDate(5, 1);
                Assert.AreEqual(startDate, "-");
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod97()
        {
            try
            {
                courseModel.RetrieveCourseStartDate(99, 99);
            }
            catch (Exception e) {/* Test Pass*/}
        }
    }
}
