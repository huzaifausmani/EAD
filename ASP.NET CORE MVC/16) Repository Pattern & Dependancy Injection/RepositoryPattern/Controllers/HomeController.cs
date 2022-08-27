using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepositoryPattern.Models;
using RepositoryPattern.Models.Interfaces;

namespace RepositoryPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployee empRepo;

        public HomeController(ILogger<HomeController> logger, IEmployee ie)
        {
            _logger = logger;
            empRepo = ie;
        }

        public IActionResult Index()
        {
            return View(empRepo.GetAllEmployee());
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
