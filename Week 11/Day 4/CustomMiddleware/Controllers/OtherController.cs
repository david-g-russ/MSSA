using Microsoft.AspNetCore.Mvc;
using CustomMiddleware.Services;

namespace CustomMiddleware.Controllers
{
    public class OtherController : Controller
    {
        private IRandomService _randomService;
        public OtherController(IRandomService randomService)
        {
            _randomService = randomService;
        }
        public IActionResult Index()
        {
            ViewBag.number = _randomService.GetNumber();
            return View();
        }
    }
}
