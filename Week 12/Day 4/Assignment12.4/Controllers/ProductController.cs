using Microsoft.AspNetCore.Mvc;
using Assignment12._4.Models;
using Assignment12._4.Filters;

namespace Assignment12._4.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _tempRepository;

        public ProductController(IProductRepository tempRepository)
        {
            _tempRepository = tempRepository;
        }

        [SimpleActionFilter]
        public IActionResult DisplayAll()
        {
            AllProductsView allProductsView = new AllProductsView();
            allProductsView.Products = _tempRepository.InitializeProducts();
            return View(allProductsView);
        }

        public IActionResult Details(int? id)
        {
            var model = _tempRepository.GetProduct(id);
            if(model == null)
                return NotFound();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product obj)
        {
            if (ModelState.IsValid)
            {
                _tempRepository.AddProduct(obj);
                return RedirectToAction("DisplayAll");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int? id)
        {
            var model = _tempRepository.GetProduct(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Product obj, int id)
        {
            obj.Id = id;
            _tempRepository.UpdateProduct(obj);
            return RedirectToAction("DisplayAll");
        }

        public IActionResult Delete(int? id)
        {
            var model = _tempRepository.GetProduct(id);
            if (model != null)
                _tempRepository.DeleteProduct(id);
            return RedirectToAction("DisplayAll");
        }
    }
}