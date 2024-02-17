using Microsoft.AspNetCore.Mvc;
using Mission6_Day.Models;
using System.Diagnostics;

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
        public IActionResult Movies()
        {
            return View();
        }

        [HttpPost] // post method for Movies.cshtml
        public IActionResult Movies(App response) 
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Index");
        }
    }
}
