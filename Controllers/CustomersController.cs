using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        [Route("Customers")]
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Ajay Sharma"},
                new Customer { Id=2, Name = "Aakash"}
            };
            return View(customers);
        }

        [Route("Customers/details/{id}")]
        public ActionResult Details(int id)
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Ajay Sharma"},
                new Customer { Id=2, Name = "Aakash"}
            };
            var customer = customers.Where(c=>c.Id == id).SingleOrDefault();
            return View(customer);
        }
    }
}