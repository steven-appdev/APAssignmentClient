using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient.DataService
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Required]
        public String AdminName { get; set; }

        [Required]
        public String AdminEmail { get; set; }

        [Required]
        public String AdminContact { get; set; }
    }
}
