using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapp.Models;

namespace webapp.Controllers
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
            User u = new User();
            u.Name = "Hassan";
            u.Age = 21;
            u.Height = 7.8;
            string NameFromSession = "Hassan Raza";
            u.createdBy = NameFromSession;
            u.updatedBy = NameFromSession;
            u.createdDate = System.DateTime.Now;
            u.updatedOn = System.DateTime.Now;
            string str = u.add(u);
            return View("Index",str);
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
