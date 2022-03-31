using System.Collections.Generic;

namespace Assignment12._3.Models
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> Products {get; set;}

        public ProductRepository()
        {
            Products = new List<Product>()
            {
                new Product()
                {
                    Id = 101,
                    Name = "Xbox",
                    Description = "Homework delayer",
                    Price = 500.00m,
                    ImageName = "xbox.jpg",
                    ProductType = ProductType.Okay
                },
                new Product()
                {
                    Id = 102,
                    Name = "Playstation",
                    Description = "Inferior to Xbox",
                    Price = 600.00m,
                    ImageName = "ps.png",
                    ProductType = ProductType.Worst
                },
                new Product()
                {
                    Id = 103,
                    Name = "PC",
                    Description = "Master race",
                    Price = 1500.00m,
                    ImageName = "pc.jpg",
                    ProductType= ProductType.Best
                },
                new Product()
                {
                    Id = 104,
                    Name = "iPhone",
                    Description = "For casuals",
                    Price = 900.00m,
                    ImageName = "iphone.jpg",
                    ProductType = ProductType.Casual
                }
            };
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void DeleteProduct(int? id)
        {
            var prod = GetProduct(id);
            if( prod != null )
                Products.Remove(prod);
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
            return Products;
        }

        public void UpdateProduct(Product product)
        {
            var prod = GetProduct(product.Id);
            if (prod != null)
            {
                prod.Id = product.Id;
                prod.Name = product.Name;
                prod.Description = product.Description;
                prod.Price = product.Price;
                prod.ImageName = product.ImageName;
                prod.ProductType = product.ProductType;
            }
        }
    }
}
