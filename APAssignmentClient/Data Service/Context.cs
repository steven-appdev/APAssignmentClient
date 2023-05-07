using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient.DataService
{
    public class Context : DbContext
    {
        public Context() : base("name=conString") 
        {
            string relative = @"..\..\Data Service";
            string absolute = Path.GetFullPath(relative);
            absolute = Path.GetDirectoryName(@absolute);
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<CourseClients> CourseClients { get; set; }
        public DbSet<ManagementCourses> MangementCourses { get; set; }
        public DbSet<Management> Managements { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<WaitingList> WaitingLists { get; set; }
        public DbSet<PendingList> PendingLists { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Context>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
