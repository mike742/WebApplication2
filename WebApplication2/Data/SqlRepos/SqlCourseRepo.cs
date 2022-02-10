using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Interfaces;
using WebApplication2.Models;

namespace WebApplication2.Data.SqlRepos
{
    public class SqlCourseRepo : ICourse
    {
        private readonly AppDbContext _context;

        public SqlCourseRepo(AppDbContext context)
        {
            _context = context;
        }

        public void Create(Course input)
        {
            _context.Add(input);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var courseToDelete = _context.Courses.FirstOrDefault(c => c.CourseId == id);

            if (courseToDelete != null)
            {
                _context.Remove(courseToDelete);
                _context.SaveChanges();
            }
            
        }

        public IEnumerable<Course> GetAll()
        {
            return _context.Courses;
        }

        public Course GetById(int id)
        {
            return _context.Courses.FirstOrDefault(c => c.CourseId == id);
        }

        public void Update(int id, Course input)
        {
            var courseInDb = _context.Courses.FirstOrDefault(c => c.CourseId == id);

            if (courseInDb != null)
            {
                courseInDb.CourseName = input.CourseName;
                courseInDb.CourseNumber = input.CourseNumber;
                courseInDb.Description = input.Description;
            }
            _context.SaveChanges();
        }
    }
}
