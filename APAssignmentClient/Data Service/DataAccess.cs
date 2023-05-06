using APAssignmentClient.Data_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace APAssignmentClient.DataService
{
    public class DataAccess : IDataAccess
    {
        public bool CheckAccountExist(String username)
        {
            using (var context = new Context())
            {
                try
                {
                    if (context.Users.FirstOrDefault(u => u.UserName == username) != null)
                    {
                        return true;
                    }
                    return false;
                }
                catch
                {
                    throw new Exception("Something went wrong! Please try again later or contact administrator!");
                }
            }
        }

        public User RetrieveUserInformation(String username)
        {
            using (var context = new Context())
            {
                try
                {
                    return context.Users.First(u => u.UserName == username);
                }
                catch
                {
                    throw new Exception("Something went wrong! Please try again later or contact administrator!");
                }
            }
        }

        public Client RetrieveClient(int userID)
        {
            using (var context = new Context())
            {
                try
                {
                    return context.Clients.First(cli => cli.UserId == userID);
                }
                catch
                {
                    throw new Exception("Something went wrong! Please try again later or contact administrator!");
                }
            }
        }

        public void RegisterAccount(User user, Client client)
        {
            using (var context = new Context())
            {
                try
                {
                    context.Users.Add(user);
                    context.SaveChanges();

                    User addedUser = context.Users.First(u => u.UserID == user.UserID);
                    context.Clients.Add(new Client
                    {
                        User = addedUser,
                        ClientName = client.ClientName,
                        ClientAddress = client.ClientAddress,
                        ClientEmail = client.ClientEmail,
                        ClientContact = client.ClientContact,
                        ClientBill = 0
                    });
                    context.SaveChanges();
                }
                catch
                {
                    throw new Exception("Something went wrong! Please try again later or contact administrator!");
                }
            }
        }

        public bool IsCourseEmpty()
        {
            using (var context = new Context())
            {
                var courses = context.Courses.ToList();

                if (courses == null || courses.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public List<Client> RetrieveAllClients()
        {
            using (var context = new Context())
            {
                try
                {
                    return context.Clients.ToList();
                }
                catch
                {
                    throw new Exception("Client list could not be retrieved. Please try again later or contact administrator!");
                }
            }
        }

        public void DeleteClient(int clientID)
        {
            using (var context = new Context())
            {
                try
                {
                    Client client = context.Clients.First(c => c.ClientId == clientID);
                    User user = context.Users.First(u => u.UserID == client.UserId);
                    context.Clients.Remove(client);
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
                catch
                {
                    throw new Exception("Something went wrong! Please contact administrator!");
                }
            }
        }

        public List<Course> RetrieveAllCourses()
        {
            using (var context = new Context())
            {
                try
                {
                    return context.Courses.ToList();
                }
                catch
                {
                    throw new Exception("Course list could not be retrieved. Please try again later or contact administrator!");
                }
            }
        }

        public Course RetrieveOneCourse(int courseID)
        {
            using (var context = new Context())
            {
                try
                {
                    return context.Courses.First(crs => crs.CourseId == courseID);
                }
                catch
                {
                    throw new Exception("Course does not exist! Please contact administrator!");
                }
            }
        }

        public void AddNewCourse(Course course)
        {
            using (var context = new Context())
            {
                try
                {
                    context.Courses.Add(course);
                    context.SaveChanges();
                }
                catch
                {
                    throw new Exception("Something went wrong! Please contact administrator!");
                }
            }
        }

        public void EditCourse(Course course)
        {
            using (var context = new Context())
            {
                try
                {
                    Course _course = context.Courses.First(c => c.CourseId == course.CourseId);

                    _course.CourseName = course.CourseName;
                    _course.CourseDescription = course.CourseDescription;
                    _course.CourseType = course.CourseType;
                    _course.CourseDuration = course.CourseDuration;
                    _course.CoursePrice = course.CoursePrice;

                    context.SaveChanges();
                }
                catch
                {
                    throw new Exception("Something went wrong! Please contact administrator!");
                }
            }
        }

        public void DeleteCourse(int courseID)
        {
            using (var context = new Context())
            {
                try
                {  
                    Course course = context.Courses.First(c => c.CourseId == courseID);
                    List<CourseClients> courseClient = context.CourseClients.Where(cc => cc.CourseId == courseID).ToList();

                    if (courseClient.Any())
                    {
                        foreach(CourseClients cc in courseClient)
                        {
                            //Refund client
                            Client client = context.Clients.First(c => c.ClientId == cc.ClientId);
                            client.ClientBill -= course.CoursePrice;
                        }
                    }
                    context.Courses.Remove(context.Courses.First(c => c.CourseId == courseID));
                    context.SaveChanges();
                }
                catch
                {
                    throw new Exception("Something went wrong! Please contact administrator!");
                }
            }
        }

        public void EnrolCourse(int clientID, int courseID)
        {
            using (var context = new Context())
            {
                try
                {
                    Client client = context.Clients.First(cli => cli.ClientId == clientID);
                    Course course = context.Courses.First(crs => crs.CourseId == courseID);

                    CourseClients newEnrolment = new CourseClients
                    {
                        Client = client,
                        Course = course,
                        Status = SetEnrolmentStatus(course)
                    };

                    context.CourseClients.Add(newEnrolment);
                    client.ClientBill += course.CoursePrice;
                    context.SaveChanges();

                    if (course.CourseType == "Practical Course")
                    {
                        if (CheckExistPendingList(courseID))
                        {
                            int latestPendingID = RetrieveLastPendingListID(courseID);
                            Console.WriteLine(latestPendingID);
                            if (!IsExistPendingListFull(latestPendingID))
                            {
                                PendingList retrievedPendingInformation = RetrieveLastPendingListInformation(latestPendingID);
                                AddToPendingList(clientID, courseID, retrievedPendingInformation.ManagementId, latestPendingID, retrievedPendingInformation.StartDate);
                            }
                            else
                            {
                                AddToWaitingList(clientID, courseID);
                            }
                        }
                        else
                        {
                            AddToWaitingList(clientID, courseID);
                        }
                    }
                }
                catch
                {
                    throw new Exception("Something went wrong! Please contact administrator!");
                }
                
            }
        }

        public void AddToWaitingList(int clientID, int courseID)
        {
            using (var context = new Context())
            {
                try
                {
                    Client client = context.Clients.First(cli => cli.ClientId == clientID);
                    Course course = context.Courses.First(crs => crs.CourseId == courseID);

                    WaitingList waitList = new WaitingList
                    {
                        Client = client,
                        Course = course,
                    };

                    context.WaitingLists.Add(waitList);
                    UpdateCourseStatus(clientID, courseID, "Placed into waiting list");
                    context.SaveChanges();

                    StartPendingListAutomation(courseID);
                }
                catch
                {
                    throw new Exception("Something went wrong! Please contact administrator!");
                }
            }
        }

        private void AddToPendingList(int clientID, int courseID, int managementID, int pendingListID, DateTime startDate)
        {
            using (var context = new Context())
            {
                try
                {
                    Client client = context.Clients.First(cli => cli.ClientId == clientID);
                    Course course = context.Courses.First(crs => crs.CourseId == courseID);
                    Management management = context.Managements.Where(m => m.ManagementId == managementID).First();

                    context.PendingLists.Add(new PendingList
                    {
                        Client = client,
                        Course = course,
                        Management = management,
                        PendingListID = pendingListID,
                        StartDate = startDate
                    });
                    UpdateCourseStatus(clientID, courseID, "Course will started on " + startDate.ToString());
                    context.SaveChanges();
                }
                catch
                {
                    throw new Exception("Something went wrong! Please contact administrator!");
                }
            }
        }

        public void DropWaitingList(int clientID, int courseID)
        {
            using (var context = new Context())
            {
                try
                {
                    WaitingList waiting = context.WaitingLists.FirstOrDefault(wl => wl.ClientId == clientID && wl.CourseId == courseID);
                    if (waiting != null)
                    {
                        context.WaitingLists.Remove(waiting);
                        context.SaveChanges();
                    }
                }
                catch
                {
                    throw new Exception("Something went wrong! Please contact administrator!");
                }
            }
        }

        public void DropPendingList(int clientID, int courseID)
        {
            using (var context = new Context())
            {
                try
                {
                    PendingList pending = context.PendingLists.FirstOrDefault(pl => pl.ClientId == clientID && pl.CourseId == courseID);
                    if (pending != null)
                    {
                        context.PendingLists.Remove(pending);
                        context.SaveChanges();
                    }
                }
                catch
                {
                    throw new Exception("Something went wrong! Please contact administrator!");
                }
            }
        }

        private bool IsExistPendingListFull(int pendingListID)
        {
            using (var context = new Context())
            {
                try
                {
                    List<PendingList> pendingList = context.PendingLists.Where(pl => pl.PendingListID == pendingListID).ToList();
                    int pendingListCount = pendingList.Count();
                    if (pendingListCount < 2)
                    {
                        return false;
                    }
                    return true;
                }
                catch
                {
                    throw new Exception("Something went wrong. Please contact administrator!");
                }
            }
        }

        private bool CheckExistPendingList(int courseID)
        {
            using (var context = new Context())
            {
                try
                {
                    return context.PendingLists.Where(pl => pl.CourseId == courseID).Any();
                }
                catch
                {
                    throw new Exception("Something went wrong. Please contact administrator!");
                }
            }
        }

        private int RetrieveLastPendingListID()
        {
            using (var context = new Context())
            {
                try
                {
                    List<PendingList> pendingList = context.PendingLists.ToList();
                    if (pendingList.Any())
                    {
                        return pendingList.Last().PendingListID;
                    }
                    throw new Exception("Pending List ID could not be retrieved. Please try again later or contact administrator!");
                }
                catch
                {
                    throw new Exception("Something went wrong. Please contact administrator!");
                }
            }
        }

        private int RetrieveLastPendingListID(int courseID)
        {
            using (var context = new Context())
            {
                try
                {
                    List<PendingList> pendingList = context.PendingLists.Where(pl => pl.CourseId == courseID).ToList();
                    if (pendingList.Any())
                    {
                        return pendingList.Last().PendingListID;
                    }
                    throw new Exception("Pending List ID could not be retrieved. Please try again later or contact administrator!");
                }
                catch
                {
                    throw new Exception("Something went wrong. Please contact administrator!");
                }
            }
        }

        private PendingList RetrieveLastPendingListInformation(int pendingListID)
        {
            using (var context = new Context())
            {
                try
                {
                    return context.PendingLists.First(pl => pl.PendingListID == pendingListID);
                }
                catch
                {
                    throw new Exception("Pending List could not be retrieved. Please try again later or contact administrator!");
                }
            }
        }

        private void StartPendingListAutomation(int courseID)
        {
            using (var context = new Context())
            {
                try
                {
                    List<WaitingList> waitingList = context.WaitingLists.Where(wl => wl.CourseId == courseID).ToList();

                    if (waitingList.Count() >= 2)
                    {
                        int managementID = FindAvailableManagement(courseID);
                        int pendingID = 0;
                        if (CheckExistPendingList(courseID))
                        {
                            pendingID = RetrieveLastPendingListID() + 1;
                        }
                        else
                        {
                            pendingID = 1;
                        }


                        foreach (WaitingList wl in waitingList)
                        {
                            AddToPendingList(wl.ClientId, wl.CourseId, managementID, pendingID, GetNextMondayDate());
                            context.WaitingLists.Remove(wl);
                            UpdateCourseStatus(wl.ClientId, wl.CourseId, "Course will started on " + GetNextMondayDate().ToString());
                            context.SaveChanges();
                        }
                    }
                }
                catch
                {
                    throw new Exception("Something went wrong. Please contact administrator!");
                }
            }
        }

        public String RetrieveCourseStartDate(int clientID, int courseID)
        {
            using (var context = new Context())
            {
                try
                {
                    if (context.PendingLists.Where(pl => pl.ClientId == clientID && pl.CourseId == courseID).Any())
                    {
                        return context.PendingLists.First(pl => pl.ClientId == clientID && pl.CourseId == courseID).StartDate.ToString();
                    }
                    return "-";
                }
                catch
                {
                    throw new Exception("Something went wrong. Please contact administrator!");
                }
            }
        }

        private void UpdateCourseStatus(int clientID, int courseID, String message)
        {
            using (var context = new Context())
            {
                try
                {
                    CourseClients courseClient = context.CourseClients.First(cc => cc.ClientId == clientID && cc.CourseId == courseID);
                    courseClient.Status = message;
                    context.SaveChanges();
                }
                catch
                {
                    throw new Exception("Something went wrong. Please contact administrator!");
                }
            }
        }

        private int FindAvailableManagement(int courseID)
        {
            using (var context = new Context())
            {
                try
                {
                    Random rnd = new Random();
                    List<int> managements = context.MangementCourses.Where(mc => mc.CourseID == courseID).Select(mc => mc.ManagementID).ToList();
                    if (managements.Any())
                    {
                        int random = rnd.Next(1, managements.Count);
                        return managements[random - 1];
                    }
                    throw new Exception("Management not available. Please try again later or contact administrator!");
                }
                catch
                {
                    throw new Exception("Something went wrong. Please contact administrator!");
                }
            }
        }

        public void DropCourse(int clientID, int courseID)
        {
            using (var context = new Context())
            {
                try
                {
                    Client client = context.Clients.First(cli => cli.ClientId == clientID);
                    Course course = context.Courses.First(crs => crs.CourseId == courseID);
                    context.CourseClients.Remove(context.CourseClients.First(cc => cc.ClientId == clientID && cc.CourseId == courseID));
                    client.ClientBill -= course.CoursePrice;
                    context.SaveChanges();
                }
                catch
                {
                    throw new Exception("Something went wrong. Please contact administrator!");
                }
            }
        }

        public List<Course> RetrieveEnrolledCourses(int clientID)
        {
            using (var context = new Context())
            {
                try
                {
                    //Return could be null
                    return context.Clients.Where(cli => cli.ClientId == clientID).SelectMany(cli => cli.CourseClients.Select(cc => cc.Course)).ToList();
                }
                catch
                {
                    throw new Exception("Something went wrong! Please contact administrator!");
                }
            }
        }

        public CourseClients RetrieveCourseStatus(int clientID, int courseID)
        {
            using (var context = new Context())
            {
                try
                {
                    return context.CourseClients.First(cc => cc.ClientId == clientID && cc.CourseId == courseID);
                }
                catch
                {
                    throw new Exception("Course status does not exist! Please try again or contact administrator!");
                }
            }
        }

        public Client RetrieveClientInformation(int clientID)
        {
            using (var context = new Context())
            {
                try
                {
                    return context.Clients.First(cli => cli.ClientId == clientID);
                }
                catch
                {
                    throw new Exception("Client does not exist! Please try again or contact administrator!");
                }
            }
        }

        public List<Management> RetrieveAllManagement()
        {
            using (var context = new Context())
            {
                try
                {
                    return context.Managements.ToList();
                }
                catch
                {
                    throw new Exception("Management could not be retrieved. Please try again or contact administrator!");
                }
            }
        }

        public Management RetrieveOneManagement(int managementID)
        {
            using (var context = new Context())
            {
                try
                {
                    return context.Managements.First(m => m.ManagementId == managementID);
                }
                catch
                {
                    throw new Exception("Management could not be retrieved. Please try again or contact administrator!");
                }
            }
        }

        public void AddNewManagement(Management management, int courseID)
        {
            using (var context = new Context())
            {
                try
                {
                    context.Managements.Add(management);
                    context.SaveChanges();

                    Management mngmt = context.Managements.First(m => m.ManagementName == management.ManagementName && m.ManagementSupportSession == management.ManagementSupportSession);
                    Course course = context.Courses.First(c => c.CourseId == courseID);
                    context.MangementCourses.Add(new ManagementCourses
                    {
                        Management = mngmt,
                        Course = course
                    });
                    context.SaveChanges();
                }
                catch
                {
                    throw new Exception("Something went wrong! Please contact administrator!");
                }
            }
        }

        public void EditManagement(Management management, int courseID)
        {
            using (var context = new Context())
            {
                try
                {
                    Management mngmt = context.Managements.First(m => m.ManagementId == management.ManagementId);
                    mngmt.ManagementName = management.ManagementName;
                    mngmt.ManagementSupportSession = management.ManagementSupportSession;

                    ManagementCourses managementCourses = context.MangementCourses.FirstOrDefault(mc => mc.ManagementID == management.ManagementId);
                    if(managementCourses != null)
                    {
                        context.MangementCourses.Remove(managementCourses);
                    }

                    ManagementCourses newManagementCourses = new ManagementCourses
                    {
                        Management = context.Managements.First(m => m.ManagementId == management.ManagementId),
                        Course = context.Courses.First(c => c.CourseId == courseID)
                    };
                    context.MangementCourses.Add(newManagementCourses);
                    context.SaveChanges();
                }
                catch
                {
                    throw new Exception("Something went wrong! Please contact administrator!");
                }
        }
        }

        public void DeleteManagement(int managementID)
        {
            using(var context = new Context())
            {
                try
                {
                    Management management = context.Managements.First(m => m.ManagementId == managementID);
                    context.Managements.Remove(management);
                    context.SaveChanges();
                }
                catch
                {
                    throw new Exception("Something went wrong! Please contact administrator!");
                }
            }
        }

        public void AddNewBooking(int clientID, int managementID, int duration, DateTime date)
        {
            using (var context = new Context())
            {
                try
                {
                    Client client = context.Clients.First(cli => cli.ClientId == clientID);
                    Management management = context.Managements.First(m => m.ManagementId == managementID);

                    Booking newBooking = new Booking
                    {
                        Client = client,
                        Management = management,
                        BookingDuration = duration,
                        BookingDate = date
                    };

                    context.Bookings.Add(newBooking);

                    client.ClientBill += (duration / 15) * 40;

                    context.SaveChanges();
                }
                catch
                {
                    throw new Exception("Something went wrong. Please contact administrator!");
                }
                
            }
        }

        public void DropBooking(int clientID, int bookingID)
        {
            using (var context = new Context())
            {
                try
                {
                    Client client = context.Clients.First(cli => cli.ClientId == clientID);
                    int duration = context.Bookings.First(bk => bk.BookingID == bookingID).BookingDuration;

                    context.Bookings.Remove(context.Bookings.First(bk => bk.BookingID == bookingID));
                    client.ClientBill -= (duration / 15) * 40;
                    context.SaveChanges();
                }
                catch
                {
                    throw new Exception("Something went wrong. Please contact administrator!");
                }
            }
        }

        public List<Booking> RetrieveAllBooking(int clientID)
        {
            using (var context = new Context())
            {
                try
                {
                    return context.Bookings.Where(bk => bk.ClientId == clientID).ToList();
                }
                catch
                {
                    throw new Exception("Something went wrong. Please try again or contact administrator!");
                }
            }
        }

        public String RetrieveManagementName(int managementID)
        {
            using (var context = new Context())
            {
                try
                {
                    return context.Managements.First(m => m.ManagementId == managementID).ManagementName.ToString();
                }
                catch
                {
                    throw new Exception("Management name could not be retrieved. Please try again or contact administrator!");
                }
            }
        }

        public String RetrieveManagementCourse(int managementID)
        {
            using (var context = new Context())
            {
                try
                {
                    ManagementCourses managementCourse = context.MangementCourses.FirstOrDefault(mc => mc.ManagementID == managementID);
                    if (managementCourse != null)
                    {
                        return managementCourse.Course.CourseName.ToString();
                    }
                    return "-";
                }
                catch
                {
                    throw new Exception("Management course could not be retrieved. Please try again or contact administrator!");
                }
            }
        }

        public int RetrieveManagementCourseID(int managementID)
        {
            using (var context = new Context())
            {
                try
                {
                    ManagementCourses managementCourse = context.MangementCourses.First(mc => mc.ManagementID == managementID);
                    if (managementCourse != null)
                    {
                        return managementCourse.Course.CourseId;
                    }
                    throw new Exception("Something went wrong. Please try again or contact administrator!");
                }
                catch
                {
                    throw new Exception("Management course could not be retrieved. Please try again or contact administrator!");
                }
            }
        }

        private String SetEnrolmentStatus(Course course)
        {
            if (course.CourseType == "Practical Course")
            {
                return "Placed in waiting list";
            }
            return "Course Ready";
        }

        private DateTime GetNextMondayDate()
        {
            DateTime time = DateTime.Now.AddDays(42);

            int daysToAdd = ((int)DayOfWeek.Monday - (int)time.DayOfWeek + 7) % 7;
            return time.AddDays(daysToAdd);
        }
    }
}
