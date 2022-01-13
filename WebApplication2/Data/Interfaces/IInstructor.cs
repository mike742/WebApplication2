using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Data.Interfaces
{
    public interface IInstructor
    {
        IEnumerable<Instructor> GetAll();
        Instructor GetById(int id);
        void Create(Instructor input);
        void Update(int id, Instructor input);
        void Delete(int id);
    }
}
