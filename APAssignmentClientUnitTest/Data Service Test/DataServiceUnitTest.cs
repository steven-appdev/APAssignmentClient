using Microsoft.VisualStudio.TestTools.UnitTesting;
using APAssignmentClient.DataService;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.IO;
using System.Collections.Generic;

namespace APAssignmentClientUnitTest.DataServiceTest
{
    [TestClass]
    public class DataServiceUnitTest
    {
        private IDataAccess access;

        public DataServiceUnitTest()
        {
            access = new DataAccess();
        }

        [TestMethod]
        public void TestMethod1()
        {
            bool result = access.CheckAccountExist("steven");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool result = access.CheckAccountExist("test");
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            try
            {
                User user = access.RetrieveUserInformation("steven");
                Assert.AreEqual("steven", user.UserName);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            try
            {
                access.RetrieveUserInformation("test");
            }
            catch (Exception){/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod5()
        {
            try
            {
                Client client = access.RetrieveClient(5);
                Assert.AreEqual(5, client.UserId);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMethod6()
        {
            try
            {
                access.RetrieveClient(99);
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod7()
        {
            try
            {
                User user = new User
                {
                    UserName = "testacc",
                    UserPassword = HashPassword("testpass"),
                    UserType = 1
                };

                Client client = new Client
                {
                    ClientName = "Test Account",
                    ClientAddress = "Test Address",
                    ClientEmail = "test@example.com",
                    ClientContact = "07000000000"
                };

                access.RegisterAccount(user, client);

                using (var context = new Context())
                {
                    User addedUser = context.Users.FirstOrDefault(u => u.UserName == "testacc");
                    Client addedClient = context.Clients.FirstOrDefault(cli => cli.ClientName == "Test Account");

                    Assert.IsNotNull(addedUser);
                    Assert.IsNotNull(addedClient);
                }
            }
            catch (Exception) 
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMethod8()
        {
            try
            {
                User user = null;
                Client client = null;

                access.RegisterAccount(user, client);
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod9()
        {
            try
            {
                int totalRow;

                using (var context = new Context())
                {
                    totalRow = context.Clients.ToList().Count();
                }
                List<Client> clients = access.RetrieveAllClients();
                Assert.AreEqual(totalRow, clients.Count());
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMethod10()
        {
            try
            {
                access.DeleteClient(7);

                using (var context = new Context())
                {
                    Assert.IsNull(context.Clients.FirstOrDefault(cli => cli.UserId == 7));
                }
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMethod11()
        {
            try
            {
                access.DeleteClient(99);
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod12()
        {
            try
            {
                int totalRow;

                using (var context = new Context())
                {
                    totalRow = context.Courses.ToList().Count();
                }
                List<Course> courses = access.RetrieveAllCourses();
                Assert.AreEqual(totalRow, courses.Count());
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMethod13()
        {
            try
            {
                using (var context = new Context())
                {
                    Course dbCourse = context.Courses.First(crs => crs.CourseId == 1);
                    Course funcCourse = access.RetrieveOneCourse(1);
                    Assert.AreEqual(dbCourse.CourseName, funcCourse.CourseName);
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod14()
        {
            try
            {
                access.RetrieveOneCourse(99);
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod15()
        {
            try
            {
                access.AddNewCourse(new Course
                {
                    CourseName = "Unit Test Course",
                    CourseDescription = "Test Description",
                    CourseType = "Video Course",
                    CourseDuration = 0,
                    CoursePrice = 0.00
                });

                using (var context = new Context())
                {
                    Course course = context.Courses.FirstOrDefault(crs => crs.CourseName == "Unit Test Course");
                    Assert.IsNotNull(course);
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod16()
        {
            try
            {
                access.AddNewCourse(null);
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod17()
        {
            try
            {
                access.EditCourse(new Course
                {
                    CourseId = 10,
                    CourseName = "Unit Test Edit",
                    CourseDescription = "Test Edit Description",
                    CourseType = "Practical Course",
                    CourseDuration = 10,
                    CoursePrice = 1000.00
                });

                using (var context = new Context())
                {
                    Course course = context.Courses.FirstOrDefault(crs => crs.CourseId == 10);
                    Assert.AreEqual(course.CourseName, "Unit Test Edit");
                    Assert.AreEqual(course.CourseDescription, "Test Edit Description");
                    Assert.AreEqual(course.CourseType, "Practical Course");
                    Assert.AreEqual(course.CourseDuration, 10);
                    Assert.AreEqual(course.CoursePrice, 1000.00);
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod18()
        {
            try
            {
                access.EditCourse(null);
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod19()
        {
            try
            {
                access.DeleteCourse(10);

                using (var context = new Context())
                {
                    Assert.IsNull(context.Courses.FirstOrDefault(crs => crs.CourseId == 10));
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod20()
        {
            try
            {
                access.DeleteCourse(99);
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod21()
        {
            try
            {
                access.EnrolCourse(5, 1);

                using (var context = new Context())
                {
                    Assert.IsNotNull(context.CourseClients.FirstOrDefault(cc => cc.ClientId == 5 && cc.CourseId == 1));
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod22()
        {
            try
            {
                access.EnrolCourse(99, 99);
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod23()
        {
            try
            {
                access.DropCourse(5, 1);

                using (var context = new Context())
                {
                    Assert.IsNull(context.CourseClients.FirstOrDefault(cc => cc.ClientId == 5 && cc.CourseId == 1));
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod24()
        {
            try
            {
                access.DropCourse(99, 99);
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod25()
        {
            try
            {
                access.EnrolCourse(5, 1);
                access.EnrolCourse(5, 2);

                int funcEnrolled = access.RetrieveEnrolledCourses(5).Count();

                using (var context = new Context())
                {
                    int dbEnrolled = context.CourseClients.Where(cc => cc.ClientId == 5).ToList().Count();
                    Assert.AreEqual(funcEnrolled, dbEnrolled);
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod26()
        {
            try
            {
                List<Course> cc = access.RetrieveEnrolledCourses(99);
                Assert.IsFalse(cc.Any());
            }
            catch (Exception e) 
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod27()
        {
            try
            {
                CourseClients cc = access.RetrieveCourseStatus(5, 1);
                Assert.AreEqual(cc.Status, "Course Ready");
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod28()
        {
            try
            {
                access.RetrieveCourseStatus(99, 99);
            }
            catch (Exception){/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod29()
        {
            try
            {
                Client client = access.RetrieveClientInformation(5);
                using (var context = new Context())
                {
                    Client dbClient = context.Clients.First(cli => cli.ClientId == 5);
                    Assert.AreEqual(client.ClientName, dbClient.ClientName);
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod30()
        {
            try
            {
                access.RetrieveClientInformation(99);
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod31()
        {
            try
            {
                int funcManagements = access.RetrieveAllManagement().Count();
                using (var context = new Context())
                {
                    int dbManagements = context.Managements.ToList().Count();
                    Assert.AreEqual(funcManagements, dbManagements);
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod32()
        {
            try
            {
                Management funcManagement = access.RetrieveOneManagement(1);

                using (var context = new Context())
                {
                    Management dbManagement = context.Managements.First(m => m.ManagementId == 1);
                    Assert.AreEqual(funcManagement.ManagementName, dbManagement.ManagementName);
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod33()
        {
            try
            {
                access.RetrieveOneManagement(99);
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod34()
        {
            try
            {
                Management mngmt = new Management
                {
                    ManagementName = "Test Management Name",
                    ManagementSupportSession = "Test Support Session"
                };

                access.AddNewManagement(mngmt, 1);

                using (var context = new Context())
                {
                    Management dbManagement = context.Managements.FirstOrDefault(m => m.ManagementName == "Test Management Name");
                    Assert.IsNotNull(dbManagement);
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod35()
        {
            try
            {
                access.AddNewManagement(null, 99);
            }
            catch (Exception) {/* Test Pass*/}
        }

        [TestMethod]
        public void TestMethod36()
        {
            try
            {
                Management editManagement = new Management
                {
                    ManagementId = 9,
                    ManagementName = "Test Edited Management",
                    ManagementSupportSession = "Edited Support Session"
                };

                access.EditManagement(editManagement, 2);

                using (var context = new Context())
                {
                    Management dbManagement = context.Managements.FirstOrDefault(m => m.ManagementId == 9);
                    ManagementCourses dbMCourses = context.MangementCourses.FirstOrDefault(mc => mc.ManagementID == 9);
                    Assert.AreEqual(dbManagement.ManagementName, "Test Edited Management");
                    Assert.AreEqual(dbManagement.ManagementSupportSession, "Edited Support Session");
                    Assert.AreEqual(dbMCourses.CourseID, 2);
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void TestMethod37()
        {
            try
            {
                access.EditManagement(null, 99);
            }
            catch (Exception) {/* Test Pass*/}
        }

        private byte[] HashPassword(String password)
        {
            String salt = "kf7014ap";
            String newPassword = password + salt;

            SHA256 sha256 = SHA256Managed.Create();
            UTF8Encoding utf8 = new UTF8Encoding();
            return sha256.ComputeHash(utf8.GetBytes(newPassword));
        }
    }
}
