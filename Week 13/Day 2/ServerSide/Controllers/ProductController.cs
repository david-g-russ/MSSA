using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ServerSide.Models;

namespace ServerSide.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private List<Product> products = new List<Product>();

        public ProductController()
        {
            products.Add(new Product
            {
                Id = 101,
                Name = "Xbox",
                Description = "Homework delayer",
                Price = 500.00m,
                ImageName = "xbox.jpg"
            });
            products.Add(new Product
            {
                Id = 102,
                Name = "Playstation",
                Description = "Inferior to Xbox",
                Price = 600.00m,
                ImageName = "ps.png"
            });
            products.Add(new Product
            {
                Id = 103,
                Name = "PC",
                Description = "Master race",
                Price = 1500.00m,
                ImageName = "pc.jpg"
            });
            products.Add(new Product
            {
                Id = 104,
                Name = "iPhone",
                Description = "For casuals",
                Price = 900.00m,
                ImageName = "iphone.jpg"
            });
        }

        [HttpGet()]
        public List<Product> GetProducts()
        {
            return this.products;
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = this.products.Find(x => x.Id == id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }
    }
}
