using IntroMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IntroMVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public ContentResult StudentAsString()
        {
            return Content("Name: Walter, Grade: 7");
        }

        public ViewResult StudentAsView()
        {
            ViewData["message"] = "Name: Walter, Grade: 7 (Coming with viewdata)";
            return View();
        }

        public RedirectResult StudentAsRedirectResult()
        {
            return new RedirectResult("https://www.google.com/search?q=walter");
        }

        public RedirectToRouteResult StudentAsRedirectToRouteResult()
        {
            return new RedirectToRouteResult(new { Controller = "Home", Action = "StudentAsView" });
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
