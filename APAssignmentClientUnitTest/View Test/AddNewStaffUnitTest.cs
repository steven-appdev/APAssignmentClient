using APAssignmentClient.View;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace APAssignmentClientUnitTest.ViewTest
{
    [TestClass]
    public class AddNewStaffUnitTest
    {
        [TestMethod]
        public void TestMethod134()
        {
            IAddNewStaff screen = new AddNewStaff();
            screen.StaffID = "1";
            screen.StaffName = "Staff Name";
            screen.StaffSupportSession = "Support Session";
            Assert.AreEqual(screen.StaffID, "1");
            Assert.AreEqual(screen.StaffName, "Staff Name");
            Assert.AreEqual(screen.StaffSupportSession, "Support Session");
        }
    }
}
