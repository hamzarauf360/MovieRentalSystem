using Movie_Rental_System.Models;
using Movie_Rental_System.ViewModels;
using System;
using System.Data.Entity;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movie_Rental_System.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        

        public MoviesController ()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies
        public ActionResult Index()
        {

            var movies = _context.Movies.Include(c => c.Genre).ToList();




                 return View(movies);

        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();
            var viewmodel = new NewMovieViewModel
            {
                Genres = genres
            };

            return View("New",viewmodel);
        }

        public ActionResult MovieDetails(int Id)
        {

            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == Id);

            if (movie == null)
            {
                return HttpNotFound();

            }

            return View(movie);
        }

    }
}
