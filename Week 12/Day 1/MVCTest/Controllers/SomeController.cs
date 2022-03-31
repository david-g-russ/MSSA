using Microsoft.AspNetCore.Mvc;

namespace MVCTest.Controllers
{
    public class SomeController : Controller
    {
        [Route("/PrintName/{fName}/{lName}")]
        public IActionResult Print(string fName, string lName)
        {
            return Content("Hello :" + fName + " " + lName);
        }

        [Route("/BestRestaurants")]
        public IActionResult GetRestaurants()
        {
            return Content("Best restaurants");
        }
    }
}
