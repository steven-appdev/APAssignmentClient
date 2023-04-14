using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        public String ClientName { get; set; }

        [Required]
        public String ClientAddress { get; set; }

        [Required]
        public String ClientEmail { get; set; }

        [Required]
        public String ClientContact { get; set; }

        [Required]
        public double ClientBill { get; set; }

        public virtual ICollection<CourseClients> CourseClients { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<WaitingList> WaitingLists { get; set; }
        public virtual ICollection<PendingList> PendingLists { get; set; }
    }
}
