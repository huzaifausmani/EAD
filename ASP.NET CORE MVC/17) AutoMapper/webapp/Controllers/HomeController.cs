using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapp.Models;
using webapp.Models.ViewModels;
using AutoMapper;                        //must have to add this line

namespace webapp.Controllers
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
            User u = new User{ID = 1, Name="Hassan Raza", Age = 22, Height=6.8, Gender = "Male", Weight = 70};
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
