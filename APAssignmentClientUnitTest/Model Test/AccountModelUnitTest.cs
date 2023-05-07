using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using APAssignmentClient.Model;
using APAssignmentClient.DataService;

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

        [TestMethod]
        public void TestMethod55()
        {
            bool result = accountModel.Login("incorrect", "incorrect");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod56()
        {
            try
            {
                accountModel.Register("unittester", "unittester", "Unit", "Test Address", "test@example.com", "0700000000");
            }
            catch(Exception e) 
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod57()
        {
            try
            {
                accountModel.Register("steven", "abc123", "Unit", "Test Address", "test@example.com", "0700000000");
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod58()
        {
            try
            {
                accountModel.UserID = 5;
                Client client = accountModel.RetrieveClient();
                Assert.AreEqual(client.UserId, 5);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod59()
        {
            try
            {
                accountModel.UserID = 99;
                Client client = accountModel.RetrieveClient();
            }
            catch (Exception) {/* Test Pass*/}
        }
    }
}
