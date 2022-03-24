using Microsoft.AspNetCore.Mvc;

namespace MVC_Test.Controllers
{
    public class HomeController : Controller
    {
        // multiple methods

        // http://localhost:3323/controller/action
        public IActionResult Index()
        {
            return View(); // by default search for Index.cshtml
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}
