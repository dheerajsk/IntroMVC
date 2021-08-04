using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroMVC.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult ViewDataSubmit()
        {
            ViewData["name"] = Request.Form["name"];
            ViewData["address"] = Request.Form["address"];
            ViewData["class"] = Request.Form["class"];
            ViewData["year"] = Request.Form["year"];

            return View();
        }
    }
}
