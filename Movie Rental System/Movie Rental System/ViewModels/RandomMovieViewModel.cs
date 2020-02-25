using Movie_Rental_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Rental_System.ViewModels
{
    public class RandomMovieViewModel
    {
        public List<Movie>  Movies { get; set; }

        public List<Customer> Customers { get; set; }

    }
}