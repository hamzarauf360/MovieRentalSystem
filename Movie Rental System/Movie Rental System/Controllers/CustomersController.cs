﻿using Movie_Rental_System.Models;
using Movie_Rental_System.ViewModels;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movie_Rental_System.Controllers
{


    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {

            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult New()
        {
            var membershiptype = _context.MembershipTypes.ToList();
            var viewmodel = new NewCustomerViewModel
            {
                MembershipTypes = membershiptype
            };
            return View(viewmodel);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);

            _context.SaveChanges();

            return RedirectToAction("Index","Customers");
        }

        public ActionResult Details(int Id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == Id);

            if (customer == null)
            {
                return HttpNotFound();

            }

            return View(customer);



        }

    }
}