using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Interfaces;
using WebApplication2.Models;

namespace WebApplication2.Data.MockRepos
{
    public class MockStudentRepo : IStudent
    {
        private static List<Student> _students = new List<Student> { 
            new Student {StudentId = 201, FirstName = "Mark", LastName = "Larson", EmailAddress = "", PhoneNumber="204 123-4567", CourseId = 101 },
            new Student {StudentId = 202, FirstName = "Mary", LastName = "Doe", EmailAddress = "", PhoneNumber="204 123-4568", CourseId = 101 },
            new Student {StudentId = 203, FirstName = "Bob", LastName = "Gibson", EmailAddress = "", PhoneNumber="204 123-4569", CourseId = 101 },
            new Student {StudentId = 204, FirstName = "Tracy", LastName = "Fender", EmailAddress = "", PhoneNumber="204 123-4570", CourseId = 102 },
            new Student {StudentId = 205, FirstName = "Ashly", LastName = "Paul", EmailAddress = "", PhoneNumber="204 123-4571", CourseId = 102 },
        };
        public void Create(Student input)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Student input)
        {
            throw new NotImplementedException();
        }
    }
}
