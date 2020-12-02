using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Data;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public ViewResult Random()
        {
            return View();
        }

        public ViewResult Index()
        {
            var movie = _context.Movies.ToList();
            return View(movie);
        }

        public ActionResult Details(int id)
        {
            var movies = _context.Movies.Where(m => m.Id == id).SingleOrDefault();
            return View(movies);
        }

    }
}
