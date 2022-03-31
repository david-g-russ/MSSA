using System.Collections.Generic;

namespace Assignment12._1.Models
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> Products {get; set;}

        public void AddProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteProduct(int? id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetAll(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Product GetProduct(int? id)
        {
            if (id == null)
                return null;
            else
                return Products.Find(x => x.Id == id);
        }

        public List<Product> InitializeProducts()
        {
            Products = new List<Product>()
            {
                new Product()
                {
                    Id = 101,
                    Name = "Xbox",
                    Description = "Homework delayer",
                    Price = 500.00m,
                    ImageName = "xbox.jpg"
                },
                new Product()
                {
                    Id = 102,
                    Name = "Playstation",
                    Description = "Inferior to Xbox",
                    Price = 600.00m,
                    ImageName = "ps.png"
                },
                new Product()
                {
                    Id = 103,
                    Name = "PC",
                    Description = "Master race",
                    Price = 1500.00m,
                    ImageName = "pc.jpg"
                },
                new Product()
                {
                    Id = 104,
                    Name = "iPhone",
                    Description = "For casuals",
                    Price = 900.00m,
                    ImageName = "iphone.jpg"
                }
            };
            return Products;
        }

        public void UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
