using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using APAssignmentClient.Model;

namespace APAssignmentClientUnitTest.ModelTest
{
    [TestClass]
    public class AccountModelUnitTest
    {
        private IAccountModel accountModel;

        public AccountModelUnitTest()
        {
            accountModel = AccountModel.GetInstance();
        }

        [TestMethod]
        public void TestMethod53()
        {
            accountModel.UserID = 1;
            accountModel.UserType = 1;
            Assert.AreEqual(1, accountModel.UserID);
            Assert.AreEqual(1, accountModel.UserType);
        }

        [TestMethod]
        public void TestMethod54()
        {
            bool result = accountModel.Login("steven", "abc123");
            Assert.IsTrue(result);
        }

    }
}
