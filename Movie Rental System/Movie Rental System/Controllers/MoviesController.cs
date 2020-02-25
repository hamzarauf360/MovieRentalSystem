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
            var movie = new List<Movie>
            {
               new Movie{Name="Shawshank"},
               new Movie{Name="Bad Boys"}
            };

           

            var viewmodel = new RandomMovieViewModel()
            {
                Movies = movie,
                Customers = null


            };



                 return View(viewmodel);

        }

    }
}
