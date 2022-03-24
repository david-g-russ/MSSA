using Microsoft.AspNetCore.Mvc;
using Assignment_11._4._1.Services;

namespace Assignment_11._4._1.Controllers
{
    public class HomeController : Controller
    {
        private IData _data;

        public HomeController(IData data)
        {
            _data = data;
        }
        public IActionResult Index()
        {
            ViewBag.products = _data.GetAll();
            return View();
        }
    }
}