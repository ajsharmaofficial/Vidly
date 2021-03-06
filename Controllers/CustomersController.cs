﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.DAL;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Customers
        [Route("Customers")]
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c=>c.MembershipType).ToList();
            return View(customers);
        }

        [Route("Customers/details/{id}")]
        public ActionResult Details(int id)
        {
            
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            return View(customer);
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}