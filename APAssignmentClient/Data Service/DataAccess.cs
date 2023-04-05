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
                return context.Managements.First(m => m.ManagementID == managementID);
            }
        }

        public void AddNewBooking(int clientID, int managementID, int duration, DateTime date)
        {
            using (var context = new Context())
            {
                Client client = context.Clients.First(cli => cli.ClientId == clientID);
                Management management = context.Managements.First(m => m.ManagementID == managementID);

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
                return context.Managements.First(m => m.ManagementID == managementID).ManagementName.ToString();
            }
        }
    }
}
