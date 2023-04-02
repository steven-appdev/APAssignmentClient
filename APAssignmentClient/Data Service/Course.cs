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
        public Course()
        {
            Clients = new List<Client>();
        }

        [Key]
        public int CourseId { get; set; }

        [Required]
        public String CourseName { get; set; }

        [Required]
        public String CourseDescription { get; set; }

        [DefaultValue(0.00)]
        public double CoursePrice { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
