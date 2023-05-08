using APAssignmentClient.Presenter;
using APAssignmentClientUnitTest.Mocs.ModelMocs;
using APAssignmentClientUnitTest.Mocs.Screen_Mocs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace APAssignmentClientUnitTest.PresenterTest
{
    [TestClass]
    public class NewRegisterPresenterUnitTest
    {
        [TestMethod]
        public void TestMethod132()
        {
            NewRegisterMoc screen = new NewRegisterMoc();
            AccountMoc accountModel = new AccountMoc();
            NewRegisterPresenter presenter = new NewRegisterPresenter(screen, accountModel);
            screen.Username = "Test";
            screen.Password = "Password";
            screen.FullName = "Name";
            screen.Address = "Address";
            screen.EmailAddress = "Email";
            screen.ContactNumber = "0";
            presenter.btnRegister_Click();
            Assert.IsFalse(screen.RegisterButtonEnabled);
            Assert.AreEqual(screen.Username, accountModel.Username);
            Assert.AreEqual(screen.Password, accountModel.Password);
            Assert.AreEqual(screen.FullName, accountModel.Fullname);
            Assert.AreEqual(screen.Address, accountModel.Address);
            Assert.AreEqual(screen.EmailAddress, accountModel.Email);
            Assert.AreEqual(screen.ContactNumber, accountModel.Contact);
            Assert.IsTrue(screen.FormClosed);
        }
    }
}
