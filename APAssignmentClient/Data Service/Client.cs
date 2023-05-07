using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient.DataService
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

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

        public String[] ToStringArray()
        {
            String[] client = { ClientId.ToString(), ClientName, ClientAddress, ClientEmail, ClientContact, ConvertBill(ClientBill) };
            return client;
        }

        private String ConvertBill(double bill)
        {
            if (bill % 1 != 0)
            {
                return bill.ToString() + "0";
            }

            return bill.ToString() + ".00";
        }

        public virtual ICollection<CourseClients> CourseClients { get; set; }
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual ICollection<WaitingList> WaitingLists { get; set; }
        public virtual ICollection<PendingList> PendingLists { get; set; }
    }
}
