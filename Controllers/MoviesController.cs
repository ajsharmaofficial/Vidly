using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie { Name="Hum Dil De Chuke Sanam!" };
            var customers = new List<Customer> 
            {
                new Customer {Name = "Ajay Sharma"},
                new Customer { Name = "Aakash"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };


            
            return View(viewModel);
        }
    }
}