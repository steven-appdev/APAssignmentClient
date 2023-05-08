using APAssignmentClient.Presenter;
using APAssignmentClientUnitTest.Mocs.ModelMocs;
using APAssignmentClientUnitTest.Mocs.Screen_Mocs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace APAssignmentClientUnitTest.PresenterTest
{
    [TestClass]
    public class NewBookingPresenterUnitTest
    {
        [TestMethod]
        public void TestMethod131()
        {
            NewBookingMoc screen = new NewBookingMoc();
            ClientMoc clientModel = new ClientMoc();
            BookMoc bookingModel = new BookMoc();
            NewBookingPresenter presenter = new NewBookingPresenter(screen, clientModel, bookingModel);
            presenter.NewBooking_Load();
            Assert.AreEqual(screen.ManagementNameData.Columns.Count, 2);
        }
    }
}
