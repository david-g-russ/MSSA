using Microsoft.AspNetCore.Mvc;
using MVCTest2.Models;

namespace MVCTest2.Controllers
{
    // Step 5: Create controller
    public class EmployeeController : Controller
    {
        private IData _tempData;

        public EmployeeController(IData tempdata)
        {
            // Dependency injection
            _tempData = tempdata;
        }

        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Employees = _tempData.InitializeData();
            return View(model);
        }

        public IActionResult Details(int? id)
        {
            var model = _tempData.GetEmployee(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model); 
        }

        //default is Get
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            if (ModelState.IsValid)
            {
                _tempData.AddEmployee(obj);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            var model = _tempData.GetEmployee(id);
            if(model != null)
                _tempData.DeleteEmployee(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int? id)
        {
            var model = _tempData.GetEmployee(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Employee obj, int id)
        {
            obj.Id = id;
            _tempData.UpdateEmployee(obj);
            return RedirectToAction("Index");
        }
    }
}