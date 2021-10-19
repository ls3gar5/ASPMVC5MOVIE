using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly IEnumerable<Customer> customers;

        public CustomersController()
        {
            this.customers = new List<Customer>()
            {
                new Customer{ Id = 1, Name = "Jose Customers 1"},
                new Customer{ Id = 2, Name = "Leo Customers 2"},
                new Customer{ Id = 3, Name = "Leo Hre is the fest 3"}
            };
        }

        // GET: Customers
        public ActionResult Index()
        {
            var movie = new Movie() { Name = "Shrek test!"};

            var customers = this.customers;

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = this.customers.ToList()
            };

            return View(viewModel);
        }
        
        public ActionResult Details(int id)
        {
            var customer = this.customers.First(w => w.Id == id);

            return View("Customer",customer);
        }

    }
}