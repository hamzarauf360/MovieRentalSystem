﻿using Movie_Rental_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Rental_System.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}