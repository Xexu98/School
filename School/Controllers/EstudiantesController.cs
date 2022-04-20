using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Models;
using Microsoft.EntityFrameworkCore;

namespace School.Controllers
{
    public class EstudiantesController : Controller
    {
        public EstudiantesController(ModelSchool context)
        {
            _context = context;
        }

        private readonly ModelSchool _context;
        public IActionResult Index()
        {
            var students = _context.People
                                .Where(r => r.HireDate == null)
                                .ToList();
            return View(students);
        }

        
        public IActionResult Ficha(int id) 
        {
            var student = _context.People
                                .Where(r => r.PersonID == id)
                                .FirstOrDefault();
            return View(student);
        }

        public IActionResult Nuevo() {
            return View("Ficha", new Person());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Nuevo(Person student) {
            if(ModelState.IsValid)
            {
                _context.People.Add(student);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            else 
            {
                return View("Ficha", new Person());
            }
        }

    }
}
