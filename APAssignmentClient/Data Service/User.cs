using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient.DataService
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        public String UserName { get; set; }

        [Required]
        public byte[] UserPassword { get; set; }

        [Required]
        public int UserType { get; set; }
    }
}
