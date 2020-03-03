using System;
using System.Collections.Generic;
using Movie_Rental_System.Models;

using System.Linq;
using System.Web;

namespace Movie_Rental_System.ViewModels
{
    public class NewMovieViewModel
    {
        public List<Genre> Genres { get; set; }
        public Movie Movies { get; set; }
    }
}