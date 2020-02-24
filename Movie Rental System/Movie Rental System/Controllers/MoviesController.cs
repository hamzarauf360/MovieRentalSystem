using Movie_Rental_System.Models;
using Movie_Rental_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movie_Rental_System.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shawshank"
            };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer1" },
                new Customer {Name = "Customer2" }

            };

            var viewmodel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers


            };



                 return View(viewmodel);

        }

    }
}
