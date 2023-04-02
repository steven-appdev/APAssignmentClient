﻿using System;
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
        public Client()
        {
            Courses = new List<Course>();
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

        public virtual ICollection<Course> Courses { get; set; }
    }
}
