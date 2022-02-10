using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Interfaces;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourse _courseRepo;
        private readonly IStudent _studentsRepo;

        public CoursesController(ICourse courseRepo, IStudent studentsRepo)
        {
            _courseRepo = courseRepo;
            _studentsRepo = studentsRepo;
        }

        // GET: CoursesController
        public ActionResult Index() // GetAll
        {
            return View(_courseRepo.GetAll());
        }

        // GET: CoursesController/Details/5
        public ActionResult Details(int id)
        {
            return View(_courseRepo.GetById(id));
        }

        // GET: CoursesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CoursesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course course)
        {
            try
            {
                _courseRepo.Create(course);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CoursesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_courseRepo.GetById(id));
        }

        // POST: CoursesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Course course)
        {
            try
            {
                _courseRepo.Update(id, course);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CoursesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_courseRepo.GetById(id));
        }

        // POST: CoursesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _courseRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public List<string> GetStudentsByCourseId(int id)
        {
            var result = _studentsRepo
                .GetAll()
                .Where(s => s.CourseId == id)
                .Select(s => $"{s.StudentId}: {s.FirstName} {s.LastName} <br>")
                .ToList();
            
            return result;
        }
    }
}
