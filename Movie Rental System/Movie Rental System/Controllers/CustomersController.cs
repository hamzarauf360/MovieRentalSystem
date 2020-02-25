using Movie_Rental_System.Models;
using Movie_Rental_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movie_Rental_System.Controllers
{
    

    public class CustomersController : Controller
    {

      static List<Customer> custs = new List<Customer>
            {
               new Customer {Id=1,Name= "John Smith"},
               new Customer {Id=2,Name="Mary Williams"}
            };

    RandomMovieViewModel viewmod = new RandomMovieViewModel
    {
        Customers = custs,
        Movies = null
    };
// GET: Customers
public ActionResult Index()
        {
            


            return View(viewmod);
        }

        [Route("Customers/Details/{Id}")]
        public ActionResult Details(int Id)
        {
            string name="Not Found";

            foreach (var cus in viewmod.Customers)
            {
                if(Id==cus.Id)
                {
                    name = cus.Name;
                    ViewBag.name = name;
                    return View();
                }
            }

            return HttpNotFound();



        }

    }
}