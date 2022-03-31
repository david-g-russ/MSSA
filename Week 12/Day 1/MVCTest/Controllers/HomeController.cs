using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.Controllers
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
            return View();
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
        
        public ViewResult Method1()
        {
            return View("Index");
        }

        public ContentResult Method2()
        {
            return Content("this is simple content from Method2");
        }

        public RedirectToActionResult Method3()
        {
            return RedirectToAction("Privacy");
        }

        public RedirectToRouteResult Method4()
        {
            return RedirectToRoute(new { Action = "Index", Controller = "Other" });
        }

        public StatusCodeResult Method5()
        {
            return new StatusCodeResult(500);
        }

        public RedirectResult Method6()
        {
            return Redirect("https://www.google.com");
        }
    }
}