using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseNumber { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
    }
}
