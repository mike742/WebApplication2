using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Data.Interfaces
{
    public interface ICourse
    {
        IEnumerable<Course> GetAll();
        Course GetById(int id);
        void Create(Course input);
        void Update(int id, Course input);
        void Delete(int id);
    }
}
