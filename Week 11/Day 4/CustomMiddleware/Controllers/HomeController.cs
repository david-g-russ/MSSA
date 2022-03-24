using Microsoft.AspNetCore.Mvc;
using CustomMiddleware.Services;

namespace CustomMiddleware.Controllers
{
    public class HomeController : Controller
    {
        private IRandomService _randomService;
        // dependency injection

        public HomeController(IRandomService randomService)
        {
            // get an object of random service
            _randomService = randomService;
        }


        public IActionResult Index()
        {
            ViewBag.number = _randomService.GetNumber();
            return View();
        }
    }
}
