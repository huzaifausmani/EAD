using System.Text;
using System.Security.AccessControl;
using System.Net.Http;
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
            if(HttpContext.Request.Cookies.ContainsKey("firstRequest"))  //checking if cookie exists.
            {
                //getting cookie
                string yourLastTime = HttpContext.Request.Cookies["firstRequest"];
                data = "Welcome Back, Last time you visited: " + yourLastTime;

                //updating cookie
                HttpContext.Response.Cookies.Delete("firstRequest");
                CookieOptions option = new CookieOptions();          //for it add using Microsoft.AspNetCore.Http;
                option.Expires = System.DateTime.Now.AddDays(1);     //Now cookie will expire after a day. if you want cookies to be saved after closing browser as well.
                HttpContext.Response.Cookies.Append("firstRequest", System.DateTime.Now.ToString(),option);
            }
            else
            {
                //defining cookie
                CookieOptions option = new CookieOptions();          //for it add using Microsoft.AspNetCore.Http;
                option.Expires = System.DateTime.Now.AddDays(1);     //Now cookie will expire after a day. if you want cookies to be saved after closing browser as well.
                data = "You visited first time. "+System.DateTime.Now.ToString();
                HttpContext.Response.Cookies.Append("firstRequest", System.DateTime.Now.ToString(),option);
            }
            return View("Index",data);
        }

        public IActionResult Remove()
        {
            //removing cookie
            HttpContext.Response.Cookies.Delete("firstRequest");
            return View("Index","Cookie Removed");
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
