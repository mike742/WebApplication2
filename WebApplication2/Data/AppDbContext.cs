using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> ops): base(ops){}

        public DbSet<Student> Students { set; get; }
        public DbSet<Course> Courses { set; get; }
        public DbSet<Instructor> Instructors { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor { InstructorId = 1, FirstName = "John", LastName = "Smith", EmailAddress = "john@yahoo.com", CourseId = 101 },
                new Instructor { InstructorId = 2, FirstName = "Bill", LastName = "O'hara", EmailAddress = "bill@yahoo.com", CourseId = 102 },
                new Instructor { InstructorId = 3, FirstName = "Sara", LastName = "Brown", EmailAddress = "sara@yahoo.com", CourseId = 103 }
            );

            modelBuilder.Entity<Course>().HasData(
                  new Course { CourseId = 101, CourseName = "Java Script", CourseNumber = "orJS_2022", Description = "Java Script course" },
                  new Course { CourseId = 102, CourseName = "C#", CourseNumber = "orCS_2022", Description = "C# course" },
                  new Course { CourseId = 103, CourseName = "Python", CourseNumber = "orPy_2022", Description = "Python course" },
                  new Course { CourseId = 104, CourseName = "Type Script", CourseNumber = "orTS_2022", Description = "Type Script course" }
            );

            modelBuilder.Entity<Student>().HasData(
                  new Student { StudentId = 201, FirstName = "Mark", LastName = "Larson", EmailAddress = "", PhoneNumber = "204 123-4567", CourseId = 101 },
                  new Student { StudentId = 202, FirstName = "Mary", LastName = "Doe", EmailAddress = "", PhoneNumber = "204 123-4568", CourseId = 101 },
                  new Student { StudentId = 203, FirstName = "Bob", LastName = "Gibson", EmailAddress = "", PhoneNumber = "204 123-4569", CourseId = 101 },
                  new Student { StudentId = 204, FirstName = "Tracy", LastName = "Fender", EmailAddress = "", PhoneNumber = "204 123-4570", CourseId = 102 },
                  new Student { StudentId = 205, FirstName = "Ashly", LastName = "Paul", EmailAddress = "", PhoneNumber = "204 123-4571", CourseId = 102 }
            );
        }
    }
}
