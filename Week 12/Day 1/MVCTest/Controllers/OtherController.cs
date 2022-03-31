using Microsoft.AspNetCore.Mvc;
using System;
using MVCTest.Models;

namespace MVCTest.Controllers
{
    public class OtherController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ServerTime = DateTime.Now.ToString();
            ViewData["Message"] = "Message goes here";
            Person person = new Person();
            person.Name = "David";
            person.Id = 1;
            return View(person);
        }
    }
}
