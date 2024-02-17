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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Movies(App response) 
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Index");
        }
    }
}
