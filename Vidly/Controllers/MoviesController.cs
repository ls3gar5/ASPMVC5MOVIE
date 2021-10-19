using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!"};
            
            var customers = new List<Customer>()
            {
                new Customer{ Name = "Jose Customers 1"},
                new Customer{ Name = "Leo Customers 2"},
                new Customer{ Name = "Leo Hre is the fest 3"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel); 
            
        }

        public  ActionResult Edit (int id)
        {
            return Content($"Hello Worldaaa!! {id}");
        }

        public ActionResult Index(int? pageIndex = 1, string sortBy = "Name")
        {
            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year}/{month}");
        }

    }
}