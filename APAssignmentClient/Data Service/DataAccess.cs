﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public class DataAccess : IDataAccess
    {
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

        public List<Course> RetrieveAllCourses()
        {
            using (var context = new Context())
            {
                return context.Courses.ToList();
            }
        }

        public Course RetrieveOneCourse(int courseID)
        {
            using (var context = new Context())
            {
                return context.Courses.First(crs => crs.CourseId == courseID);
            }
        }

        public void AddNewCourse(Course course)
        {
            using (var context = new Context())
            {
                context.Courses.Add(course);
                context.SaveChanges();
            }
        }

        public void EnrolCourse(int clientID, int courseID)
        {
            using (var context = new Context())
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
        }

        private void AddToWaitingList(int clientID, int courseID)
        {
            using (var context = new Context())
            {
                Client client = context.Clients.First(cli => cli.ClientId == clientID);
                Course course = context.Courses.First(crs => crs.CourseId == courseID);

                WaitingList waitList = new WaitingList
                {
                    Client = client,
                    Course = course,
                };

                context.WaitingLists.Add(waitList);
                context.SaveChanges();

                StartPendingListAutomation(courseID);
            }
        }

        private void AddToPendingList(int clientID, int courseID, int managementID, int pendingListID, DateTime startDate)
        {
            using (var context = new Context())
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
                UpdateCourseStatus(clientID, courseID, "Added into pending list");
                context.SaveChanges();
            }
        }

        private bool IsExistPendingListFull(int pendingListID)
        {
            using (var context = new Context())
            {
                List<PendingList> pendingList = context.PendingLists.Where(pl => pl.PendingListID == pendingListID).ToList();
                int pendingListCount = pendingList.Count();
                if (pendingListCount < 2)
                {
                    return false;
                }
                return true;
            }
        }

        private bool CheckExistPendingList(int courseID)
        {
            using (var context = new Context())
            {
                return context.PendingLists.Where(pl => pl.CourseId == courseID).Any();
            }
        }

        private int RetrieveLastPendingListID()
        {
            using (var context = new Context())
            {
                return context.PendingLists.ToList().Last().PendingListID;
            }
        }

        private int RetrieveLastPendingListID(int courseID)
        {
            using (var context = new Context())
            {
                return context.PendingLists.Where(pl => pl.CourseId == courseID).ToList().Last().PendingListID;
            }
        }

        private PendingList RetrieveLastPendingListInformation(int pendingListID)
        {
            using (var context = new Context())
            {
                return context.PendingLists.Where(pl => pl.PendingListID == pendingListID).First();
            }
        }

        private void StartPendingListAutomation(int courseID)
        {
            using (var context = new Context())
            {
                List<WaitingList> waitingList = context.WaitingLists.Where(wl => wl.CourseId == courseID).ToList();

                int managementID = FindAvailableManagement(courseID);
                int pendingID = RetrieveLastPendingListID() + 1;
                

                if (waitingList.Count() >= 2)
                {
                    foreach (WaitingList wl in waitingList)
                    {
                        AddToPendingList(wl.ClientId, wl.CourseId, managementID, pendingID, DateTime.Now);
                        context.WaitingLists.Remove(wl);
                        UpdateCourseStatus(wl.ClientId, wl.CourseId, "Added into pending list");
                        context.SaveChanges();
                    }
                }
            }
        }

        private void UpdateCourseStatus(int clientID, int courseID, String message)
        {
            using (var context = new Context())
            {
                CourseClients courseClient = context.CourseClients.Where(cc => cc.ClientId == clientID && cc.CourseId == courseID).First();
                courseClient.Status = message;
                context.SaveChanges();
            }
        }

        private int FindAvailableManagement(int courseID)
        {
            using (var context = new Context())
            {
                Random rnd = new Random();

                List<int> managements = context.MangementCourses.Where(mc => mc.CourseID == courseID).Select(mc => mc.ManagementID).ToList();
                int random = rnd.Next(1, managements.Count);
                return managements[random - 1];
            }
        }

        public void DropCourse(int clientID, int courseID)
        {
            using (var context = new Context())
            {
                Client client = context.Clients.First(cli => cli.ClientId == clientID);
                Course course = context.Courses.First(crs => crs.CourseId == courseID);
                context.CourseClients.Remove(context.CourseClients.First(cc => cc.ClientId == clientID && cc.CourseId == courseID));
                client.ClientBill -= course.CoursePrice;
                context.SaveChanges();
            }
        }

        public List<Course> RetrieveEnrolledCourses(int clientID)
        {
            using (var context = new Context())
            {
                return context.Clients.Where(cli => cli.ClientId == clientID).SelectMany(cli => cli.CourseClients.Select(cc => cc.Course)).ToList();
            }
        }

        public CourseClients RetrieveCourseStatus(int clientID, int courseID)
        {
            using (var context = new Context())
            {
                return context.CourseClients.First(cc => cc.ClientId == clientID && cc.CourseId == courseID);
            }
        }

        private String SetEnrolmentStatus(Course course)
        {
            if(course.CourseType == "Practical Course")
            {
                return "Placed in waiting list";
            }
            return "Course Ready";
        }

        public Client RetrieveClientInformation(int clientID)
        {
            using (var context = new Context())
            {
                return context.Clients.First(cli => cli.ClientId == clientID);
            }
        }

        public List<Management> RetrieveAllManagement()
        {
            using (var context = new Context())
            {
                return context.Managements.ToList();
            }
        }

        public Management RetrieveOneManagement(int managementID)
        {
            using (var context = new Context())
            {
                return context.Managements.First(m => m.ManagementId == managementID);
            }
        }

        public void AddNewBooking(int clientID, int managementID, int duration, DateTime date)
        {
            using (var context = new Context())
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
        }

        public void DropBooking(int clientID, int bookingID)
        {
            using (var context = new Context())
            {
                Client client = context.Clients.First(cli => cli.ClientId == clientID);
                int duration = context.Bookings.First(bk => bk.BookingID == bookingID).BookingDuration;
                context.Bookings.Remove(context.Bookings.First(bk => bk.BookingID == bookingID));
                client.ClientBill -= (duration / 15) * 40;
                context.SaveChanges();
            }
        }

        public List<Booking> RetrieveAllBooking(int clientID)
        {
            using (var context = new Context())
            {
                return context.Bookings.Where(bk => bk.ClientId == clientID).ToList();
            }
        }

        public String RetrieveManagementName(int managementID)
        {
            using (var context = new Context())
            {
                return context.Managements.First(m => m.ManagementId == managementID).ManagementName.ToString();
            }
        }
    }
}
