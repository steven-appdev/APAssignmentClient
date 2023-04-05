using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public class Management
    {
        public Management()
        {
            Courses = new List<Course>();
        }

        [Key]
        public int ManagementID { get; set; }

        [Required]
        public String ManagementName { get; set; }

        [Required]
        public String ManagementSupportSession { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
