﻿using Movie_Rental_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Rental_System.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
       
    }
}
