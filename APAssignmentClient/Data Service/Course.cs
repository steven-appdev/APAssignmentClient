using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        public String CourseName { get; set; }

        [Required]
        public String CourseDescription { get; set; }
        [Required]
        public String CourseType { get; set; }
        public int CourseDuration { get; set; }

        [DefaultValue(0.00)]
        public double CoursePrice { get; set; }

        public virtual ICollection<CourseClients> CourseClients { get; set; }
    }
}
