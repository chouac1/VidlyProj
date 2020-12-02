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
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var customers = _context.Customers.ToList();

            return View(customers);            
        }

        public ActionResult Details(int id)
        {
            var customers = _context.Customers.Where(c=>c.Id == id).SingleOrDefault();
            //if (customers == null)
            //    return HttpNotFound();
            return View(customers);
        }

    }
}
