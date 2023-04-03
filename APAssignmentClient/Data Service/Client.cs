using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient
{
    public class Client
    {
        private static Client _instance = null;

        private Client() { }

        public static Client GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Client();
            }
            return _instance;
        }

        [Key]
        public int ClientId { get; set; }

        [Required]
        public String ClientName { get; set; }

        [Required]
        public String ClientAddress { get; set; }

        [Required]
        public String ClientEmail { get; set; }

        [Required]
        public int ClientContact { get; set; }

        public virtual ICollection<CourseClients> CourseClients { get; set; }
    }
}
