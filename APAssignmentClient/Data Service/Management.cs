using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient.DataService
{
    public class Management
    {
        [Key]
        public int ManagementId { get; set; }

        [Required]
        public String ManagementName { get; set; }

        [Required]
        public String ManagementSupportSession { get; set; }

        public String[] ToStringArray()
        {
            String[] management = { ManagementId.ToString(), ManagementName, ManagementSupportSession};
            return management;
        }

        public virtual ICollection<ManagementCourses> ManagementCourses { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<PendingList> PendingLists { get; set; }
    }
}
