using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace APAssignmentClient
{
    public class PendingList
    {
        [Key, Column(Order = 0)]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        [Key, Column(Order = 1)]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        [Key, Column(Order = 2)]
        public int ManagementId { get; set; }
        public virtual Management Management { get; set; }
        public int PendingListID { get; set; }
        public DateTime StartDate { get; set; }
    }
}
