using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public class Course
    {
        [Key]
        public int courseId { get; set; }

        [Required]
        public String courseName { get; set; }

        [Required]
        public String courseDescription { get; set; }

        [DefaultValue(0.00)]
        public double coursePrice { get; set; }
    }
}
