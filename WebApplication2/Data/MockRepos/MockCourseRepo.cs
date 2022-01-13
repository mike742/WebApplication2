using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Interfaces;
using WebApplication2.Models;

namespace WebApplication2.Data.MockRepos
{
    public class MockCourseRepo : ICourse
    {
        private static List<Course> _courses = new List<Course>
        {
            new Course { CourseId = 101, CourseName = "Java Script", CourseNumber = "orJS_2022", Description = "Java Script course" },
            new Course { CourseId = 102, CourseName = "C#", CourseNumber = "orCS_2022", Description = "C# course" },
            new Course { CourseId = 103, CourseName = "Python", CourseNumber = "orPy_2022", Description = "Python course" },
            new Course { CourseId = 104, CourseName = "Type Script", CourseNumber = "orTS_2022", Description = "Type Script course" },
        };

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
            return _courses;
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
