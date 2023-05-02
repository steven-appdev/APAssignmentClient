using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient.Data_Service
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        public String UserName { get; set; }

        [Required]
        public String UserPassword { get; set; }

        [Required]
        public int UserType { get; set; }
    }
}
