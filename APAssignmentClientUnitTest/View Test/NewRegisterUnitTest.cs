using APAssignmentClient.View;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace APAssignmentClientUnitTest.ViewTest
{
    [TestClass]
    public class NewRegisterUnitTest
    {
        [TestMethod]
        public void TestMethod139()
        {
            INewRegister screen = new NewRegister();
            screen.Username = "Test";
            screen.Password = "Password";
            screen.FullName = "Fullname";
            screen.Address = "Address";
            screen.EmailAddress = "Email";
            screen.ContactNumber = "07000000000";
            Assert.AreEqual(screen.Username, "Test");
            Assert.AreEqual(screen.Password, "Password");
            Assert.AreEqual(screen.FullName, "Fullname");
            Assert.AreEqual(screen.Address, "Address");
            Assert.AreEqual(screen.EmailAddress, "Email");
            Assert.AreEqual(screen.ContactNumber, "07000000000");
        }
    }
}
