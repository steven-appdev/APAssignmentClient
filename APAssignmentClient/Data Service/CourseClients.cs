using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public class CourseClients
    {
        private static CourseClients _instance = null;

        private CourseClients() { }

        public static CourseClients GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CourseClients();
            }
            return _instance;
        }

        [Key]
        public int CourseClientsId { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        [Required]
        public String Status { get; set; }
    }
}
