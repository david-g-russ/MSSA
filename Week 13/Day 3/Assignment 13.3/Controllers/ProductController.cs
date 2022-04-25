using Assignment_13._3.Filters;
using Assignment_13._3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Authorization;

namespace Assignment_13._3.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _tempRepository;

        public ProductController(IProductRepository tempRepository)
        {
            _tempRepository = tempRepository;
        }

        [SimpleActionFilter]
        [Authorize(Roles = "Customer")]
        public IActionResult DisplayAll()
        {
            AllProductsView allProductsView = new()
            {
                Products = _tempRepository.InitializeProducts()
            };
            return View(allProductsView);
        }

        [Authorize(Roles = "Customer")]
        public IActionResult Details(int? id)
        {
            var model = _tempRepository.GetProduct(id);
            if (model == null)
                return NotFound();
            return View(model);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        public IActionResult Update(int? id)
        {
            var model = _tempRepository.GetProduct(id);
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Update(Product obj, int id)
        {
            obj.Id = id;
            _tempRepository.UpdateProduct(obj);
            return RedirectToAction("DisplayAll");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int? id)
        {
            var model = _tempRepository.GetProduct(id);
            if (model != null)
                _tempRepository.DeleteProduct(id);
            return RedirectToAction("DisplayAll");
        }
    }
}