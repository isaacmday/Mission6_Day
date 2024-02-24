using Microsoft.AspNetCore.Mvc;
using Mission6_Day.Models;
using System.Diagnostics;
using Mission6_Day.Migrations;

namespace Mission6_Day.Controllers
{
    public class HomeController : Controller
    {
        private MoviesContext _context;
        public HomeController(MoviesContext instance) 
        {
            _context = instance;
        }

        public IActionResult Index() // view for the home page
        {
            return View();
        }

        public IActionResult GetToKnow() // view for Get to Know Joel
        {
            return View();
        }

        [HttpGet] // get method for Movies.cshtml
        public IActionResult AddMovies()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryId)
                .ToList();
            
            return View("AddMovies", new App());
        }

        [HttpPost] // post method for Movies.cshtml
        public IActionResult AddMovies(App response) 
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); //add record to database
                _context.SaveChanges(); //save changes

                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryId)
                .ToList();

                return View(response);
            }
        }

        public IActionResult MovieList()
        {
            var movies = _context.Movies //get all records from Movies table
                .OrderBy(x => x.MovieId).ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies //get the record being edited
                .Single(x => x.MovieId == id);
            
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryId)
                .ToList();

            return View("AddMovies", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(App updatedInfo)
        {
            _context.Update(updatedInfo); //update database
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies //get record to delete
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(App record)
        {
            _context.Movies.Remove(record); //delete record
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
