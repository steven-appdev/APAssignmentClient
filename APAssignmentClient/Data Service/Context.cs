using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public class Context : DbContext
    {
        public Context() : base("name=conString") { }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<CourseClients> CourseClients { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Context>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
