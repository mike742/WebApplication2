using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [DisplayName("Number")]
        public string CourseNumber { get; set; }
        [DisplayName("Name")]
        public string CourseName { get; set; }
        public string Description { get; set; }
    }
}
