using APAssignmentClient.Model;
using APAssignmentClient.DataService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace APAssignmentClientUnitTest.ModelTest
{
    [TestClass]
    public class ClientModelUnitTest
    {
        private IClientModel clientModel;

        public ClientModelUnitTest()
        {
            clientModel = ClientModel.GetInstance();
        }

        [TestMethod]
        public void TestMethod69()
        {
            clientModel.SetClient(new Client
            {
                ClientId = 1,
                ClientName = "Test",
                ClientAddress = "Test Address",
                ClientEmail = "test@example.com",
                ClientContact = "07000000000",
                ClientBill = 0.00
            });

            Assert.AreEqual(clientModel.ClientID, 1);
            Assert.AreEqual(clientModel.ClientName, "Test");
            Assert.AreEqual(clientModel.ClientAddress, "Test Address");
            Assert.AreEqual(clientModel.ClientEmailAddress, "test@example.com");
            Assert.AreEqual(clientModel.ClientContactNumber, "07000000000");
            Assert.AreEqual(clientModel.ClientBill, 0.00);
        }

        [TestMethod]
        public void TestMethod70()
        {
            try
            {
                clientModel.SetClient(new Client
                {
                    ClientId = 5,
                    ClientBill = 999.99
                });

                double originalBill = clientModel.ClientBill;

                clientModel.UpdateClientBill();
                double updatedBill = clientModel.ClientBill;

                Assert.AreNotEqual(originalBill, updatedBill);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod71()
        {
            try
            {
                clientModel.SetClient(new Client
                {
                    ClientId = 99
                });
                clientModel.UpdateClientBill();
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod72()
        {
            try
            {
                clientModel.SetClient(new Client
                {
                    ClientId = 99
                });
                int originalClient = clientModel.ClientID;

                clientModel.SetClient(clientModel.RetrieveOneClient(5));
                int updatedClient = clientModel.ClientID;

                Assert.AreNotEqual(originalClient, updatedClient); 
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod73()
        {
            try
            {
                clientModel.RetrieveOneClient(99);
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod74()
        {
            try
            {
                clientModel.SetClient(new Client
                {
                    ClientId = 12
                });
                clientModel.DeleteClient();
                clientModel.RetrieveOneClient(12);
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod75()
        {
            try
            {
                clientModel.SetClient(new Client
                {
                    ClientId = 99
                });
                clientModel.DeleteClient();
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod76()
        {
            clientModel.SetClient(new Client
            {
                ClientId = 1,
                ClientName = "Test",
                ClientAddress = "Test Address",
                ClientEmail = "test@example.com",
                ClientContact = "07000000000",
                ClientBill = 0.00
            });

            int client = clientModel.GetClient().Length;
            Assert.AreEqual(client, 6);
        }
    }
}
