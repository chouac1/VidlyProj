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
        public ViewResult Random()
        {
            //var movie = new Movie() { Name = "Shrek!" };

            //List<Movie> movies = new List<Movie>
            //{
            //    new Movie {Name = "Shrek", Id = 1},
            //    new Movie {Name = "Wall-e", Id = 2}
            //};

            //var customers = new List<Customer>
            //{
            //    new Customer {Name = "Customer 1"},
            //    new Customer {Name = "Customer 2"}
            //};

            //var viewModel = new RandomMovieViewModel
            //{
            //    Movies = movies,
            //    Customers = customers
            //};

            return View();
        }

        public ViewResult Index()
        {
            var movie = GetMovies();
            return View(movie);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{ Id = 1, Name = "Shrek" },
                new Movie{ Id = 2, Name = "Wall-e" }
            };
        }
    }
}
