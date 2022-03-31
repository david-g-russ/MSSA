using Microsoft.AspNetCore.Mvc;

namespace FilterTest.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.EmployeeNames = new string[] { "iPhone", "pc", "ps", "xbox"};
            return View();
        }

        public IActionResult Details(string employeename)
        {
            ViewBag.SelectedEmployee = employeename;
            return View();
        }

        public IActionResult GetImage(string empName)
        {
            return File($@"\img\{empName}.jpg", "image/jpg");
        }
    }
}
