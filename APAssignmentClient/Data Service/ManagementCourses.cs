using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient.DataService
{
    public class ManagementCourses
    {
        [Key, Column(Order = 0)]
        public int ManagementID { get; set; }
        public virtual Management Management { get; set; }

        [Key, Column(Order = 1)]
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
    }
}
