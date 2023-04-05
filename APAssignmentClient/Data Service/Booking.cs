using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public int ManagementId { get; set; }
        public virtual Management Management { get; set; }
        [Required]
        public int BookingDuration { get; set; }
    }
}
