using APAssignmentClientUnitTest.Mocs.ScreenMocs;
using APAssignmentClientUnitTest.Mocs.ModelMocs;
using APAssignmentClient.Presenter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace APAssignmentClientUnitTest.PresenterTest
{
    [TestClass]
    public class LoginPresenterUnitTest
    {
        [TestMethod]
        public void TestMethod110()
        {
            LoginMoc screen = new LoginMoc();
            ClientMoc clientModel = new ClientMoc();
            AccountMoc accountModel = new AccountMoc();
            LoginPresenter presenter = new LoginPresenter(screen, clientModel, accountModel);
            screen.Username = "username";
            screen.Password = "password";

            String err = screen.errMsg;
            String errTitle = screen.title;

            presenter.btnLogin_Click();
            Assert.AreEqual(screen.Username, accountModel.Username);
            Assert.AreEqual(screen.Password, accountModel.Password);
            Assert.AreNotEqual(err, screen.errMsg);
            Assert.AreNotEqual(errTitle, screen.title);
            Assert.IsTrue(screen.btnActivated);
        }
    }
}
