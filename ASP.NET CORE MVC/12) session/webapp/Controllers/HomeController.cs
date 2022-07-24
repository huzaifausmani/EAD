using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
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
            string data = String.Empty;
            if(HttpContext.Session.Keys.Contains("firstRequest"))  //checking if cookie exists.
            {
                //getting session
                string yourLastTime = HttpContext.Session.GetString("firstRequest");
                data = "Welcome Back, Last time you visited: " + yourLastTime;

                //updating session
                HttpContext.Session.Remove("firstRequest");
                HttpContext.Session.SetString("firstRequest", System.DateTime.Now.ToString());
            }
            else
            {
                // defininng session.
                string now = System.DateTime.Now.ToString();
                data = "You visited first time. "+now;
                // HttpContext.Session.SetInt32("intRequest", 12);
                HttpContext.Session.SetString("firstRequest",now);
            }
            return View("Index",data);
        }

        public IActionResult Remove()
        {
            //removing session
            HttpContext.Session.Remove("firstRequest");
            return View("Index","Session Removed");
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
