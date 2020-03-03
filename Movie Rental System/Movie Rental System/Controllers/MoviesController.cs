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
            ViewData["Id"] = "0";
            return View("New",viewmodel);
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }

            else
            {
                var new_Movie = _context.Movies.Single(m => m.Id == movie.Id);
                new_Movie.Name = movie.Name;
                new_Movie.ReleaseDate = movie.ReleaseDate;
                new_Movie.Genre = movie.Genre;
                new_Movie.NumberInStock = movie.NumberInStock;


            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
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
        public ActionResult Edit(int Id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == Id);
            var viewmodel = new NewMovieViewModel
            {
                Movies = movie,
                Genres = _context.Genres.ToList()
            };

            if (movie == null)
            {
                return HttpNotFound();
            }
            ViewData["Id"] = "1";

            return View("New", viewmodel);
        }

    }
}
