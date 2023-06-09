﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAssignmentClient.DataService
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

        public String[] ToStringArray()
        {
            String[] array = { CourseId.ToString(), CourseName, CourseDescription, CourseType, CourseDuration.ToString(), CoursePrice.ToString() };
            return array;
        }

        public virtual ICollection<CourseClients> CourseClients { get; set; }
        public virtual ICollection<ManagementCourses> ManagementCourses { get; set; }
        public virtual ICollection<WaitingList> WaitingLists { get; set; }
        public virtual ICollection<PendingList> PendingLists { get; set; }
    }
}
