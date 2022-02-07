using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Interfaces;
using WebApplication2.Models;

namespace WebApplication2.Data.MockRepos
{
    public class MockInstructorRepo : IInstructor
    {
        private static List<Instructor> _instructors = new List<Instructor> { 
            new Instructor { InstructorId = 1, FirstName = "John", LastName = "Smith", EmailAddress = "john@yahoo.com", CourseId = 101 },
            new Instructor { InstructorId = 2, FirstName = "Bill", LastName = "O'hara", EmailAddress = "bill@yahoo.com", CourseId = 102 },
            new Instructor { InstructorId = 3, FirstName = "Sara", LastName = "Brown", EmailAddress = "sara@yahoo.com", CourseId = 103 },
        };

        public void Create(Instructor input)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Instructor> GetAll()
        {
            return _instructors;
        }

        public Instructor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Instructor input)
        {
            throw new NotImplementedException();
        }
    }
}
