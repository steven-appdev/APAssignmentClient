using APAssignmentClient.View;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace APAssignmentClientUnitTest.ViewTest
{
    [TestClass]
    public class NewBookingUnitTest
    {
        [TestMethod]
        public void TestMethod138()
        {
            INewBooking screen = new NewBooking();
            screen.SupportSession = "Support Session";
            Assert.AreEqual(screen.SupportSession, "Support Session");
        }
    }
}
