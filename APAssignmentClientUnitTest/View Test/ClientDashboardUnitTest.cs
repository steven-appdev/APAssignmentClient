using APAssignmentClient.View;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace APAssignmentClientUnitTest.ViewTest
{
    [TestClass]
    public class ClientDashboardUnitTest
    {
        [TestMethod]
        public void TestMethod135()
        {
            IClientDashboard screen = new ClientDashboard();
            screen.Username = "Test";
            Assert.AreEqual("Test", screen.Username);
        }
    }
}
