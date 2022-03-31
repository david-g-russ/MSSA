using Microsoft.AspNetCore.Mvc;
using Assignment12._1.Models;
using Assignment12._1.Filters;

namespace Assignment12._1.Controllers
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
    }
}