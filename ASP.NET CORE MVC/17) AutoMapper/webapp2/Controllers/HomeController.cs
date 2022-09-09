using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapp2.Models;
using webapp2.Models.ViewModels;
using AutoMapper;                        //must have to add this line

namespace webapp2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly  IMapper imap;

        public HomeController(ILogger<HomeController> logger, IMapper im)
        {
            _logger = logger;
            imap = im;
        }

        public IActionResult Index()
        {
            User u = new User{ID = 1, FirstName="Hassan", LastName="Raza" ,Age = 22};
            UserViewModel uvm = imap.Map<UserViewModel>(u);
            return View("Index",uvm);
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
