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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetAll()
        {
            return _context.Courses;
        }

        public Course GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Course input)
        {
            throw new NotImplementedException();
        }
    }
}
