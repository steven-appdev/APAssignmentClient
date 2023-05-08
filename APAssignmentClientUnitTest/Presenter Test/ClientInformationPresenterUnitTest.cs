using APAssignmentClient.Presenter;
using APAssignmentClientUnitTest.Mocs.ModelMocs;
using APAssignmentClientUnitTest.Mocs.ScreenMocs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace APAssignmentClientUnitTest.PresenterTest
{
    [TestClass]
    public class ClientInformationPresenterUnitTest
    {
        [TestMethod]
        public void TestMethod125()
        {
            ClientInformationMoc screen = new ClientInformationMoc();
            ClientMoc clientModel = new ClientMoc();
            ClientInformationPresenter presenter = new ClientInformationPresenter(screen, clientModel);
            Assert.AreEqual(screen.ClientID, "1");
            Assert.AreEqual(screen.ClientName, "Test");
            Assert.AreEqual(screen.ClientAddress, "Test");
            Assert.AreEqual(screen.ClientEmailAddress, "Test");
            Assert.AreEqual(screen.ClientContactNumber, "07000000000");
            Assert.AreEqual(screen.ClientBill, "0.00");
        }
    }
}
