using APAssignmentClient.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.Design;
using System.Data;

namespace APAssignmentClientUnitTest.ModelTest
{
    [TestClass]
    public class BookingModelUnitTest
    {
        private IBookingModel bookingModel;

        public BookingModelUnitTest()
        {
            bookingModel = BookingModel.GetInstance();    
        }

        [TestMethod]
        public void TestMethod60()
        {
            bookingModel.ManagementID = 1;
            bookingModel.BookingID = 1;
            Assert.AreEqual(1, bookingModel.ManagementID);
            Assert.AreEqual(1, bookingModel.BookingID);
        }

        [TestMethod]
        public void TestMethod61()
        {
            try
            {
                DataTable dt = bookingModel.RetrieveAllManagement();
                Assert.AreEqual(dt.Columns.Count, 2);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod62()
        {
            try
            {
                bookingModel.ManagementID = 1;
                String supportSession = bookingModel.RetrieveSupportSession();
                Assert.AreEqual(supportSession, "Project Management");
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod63()
        {
            try
            {
                bookingModel.ManagementID = 99;
                bookingModel.RetrieveSupportSession();
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod64()
        {
            try
            {
                int dbOriginalSize = bookingModel.RetrieveAllBooking(5).Rows.Count;

                bookingModel.ManagementID = 1;
                bookingModel.AddNewBooking(5, 10, DateTime.Now);
                int dbNewSize = bookingModel.RetrieveAllBooking(5).Rows.Count;
                Assert.AreEqual(dbOriginalSize+1, dbNewSize);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod65()
        {
            try
            {
                bookingModel.ManagementID = 99;
                bookingModel.AddNewBooking(99, 10, DateTime.Now);
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod66()
        {
            try
            {
                int dbOriginalSize = bookingModel.RetrieveAllBooking(5).Rows.Count;

                bookingModel.BookingID = 6;
                bookingModel.DropBooking(5);
                int dbNewSize = bookingModel.RetrieveAllBooking(5).Rows.Count;
                Assert.AreEqual(dbOriginalSize - 1, dbNewSize);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod67()
        {
            try
            {
                bookingModel.BookingID = 99;
                bookingModel.DropBooking(99);
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod68()
        {
            try
            {
                DataTable dt = bookingModel.RetrieveAllBooking(5);
                Assert.AreEqual(dt.Columns.Count, 4);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
    }
}
