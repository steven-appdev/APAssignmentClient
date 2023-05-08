using APAssignmentClient.View;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace APAssignmentClientUnitTest.ViewTest
{
    [TestClass]
    public class ClientInformationUnitTest
    {
        [TestMethod]
        public void TestMethod136()
        {
            IClientInformation screen = new ClientInformation();
            screen.ClientID = "1";
            screen.ClientName = "Test";
            screen.ClientAddress = "Test";
            screen.ClientEmailAddress = "test@example.com";
            screen.ClientContactNumber = "07000000000";
            screen.ClientBill = "0.00";
            Assert.AreEqual(screen.ClientID, "1");
            Assert.AreEqual(screen.ClientName, "Test");
            Assert.AreEqual(screen.ClientAddress, "Test");
            Assert.AreEqual(screen.ClientEmailAddress, "test@example.com");
            Assert.AreEqual(screen.ClientContactNumber, "07000000000");
            Assert.AreEqual(screen.ClientBill, "0.00");
        }
    }
}
