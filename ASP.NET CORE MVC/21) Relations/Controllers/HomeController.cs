using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using relation;
using relation.Models;

namespace relation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ApplicationDbContext c = new ApplicationDbContext();

            Item i = new Item 
            { 
                Name="IPhone6", 
                Description="This is a mobile",
                PurchasePrice=99M,
                Quantity=20,
                IsActive=true
            };

            c.Items.Add(i);

            int num = c.SaveChanges();
            return View("Index",num);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
