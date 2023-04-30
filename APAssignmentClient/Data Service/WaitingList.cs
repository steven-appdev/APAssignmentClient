using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient.DataService
{
    public class WaitingList
    {
        [Key, Column(Order = 0)]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        [Key, Column(Order = 1)]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
