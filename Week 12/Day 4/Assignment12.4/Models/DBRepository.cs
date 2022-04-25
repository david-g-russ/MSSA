using System.Collections.Generic;

namespace Assignment12._4.Models
{
    public class DBRepository : IProductRepository
    {
        private ProductContext _productContext;

        public List<Product> Products { get; set; }

        public DBRepository(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public IEnumerable<Product> InitializeProducts()
        {
            return _productContext.Products;
        }

        public void AddProduct(Product product)
        {
            product.TypeId = GetType(product);
            _productContext.Products.Add(product);
            _productContext.SaveChanges();
        }

        public Product GetProduct(int? id)
        {
            return _productContext.Products.Find(id);
        }

        public void UpdateProduct(Product product)
        {
            Product prod = _productContext.Products.Find(product.Id);
            if (prod != null)
            {
                prod.Id = product.Id;
                prod.Name = product.Name;
                prod.Description = product.Description;
                prod.Price = product.Price;
                prod.ProdType = product.ProdType;
                prod.TypeId = GetType(product);
                prod.ImageName = product.ImageName;
            }
            _productContext.SaveChanges();
        }

        public void DeleteProduct(int? id)
        {
            var prod = _productContext.Products.Find(id);
            if (prod != null)
            {
                _productContext.Products.Remove(prod);
                _productContext.SaveChanges();
            }
        }

        public int GetType(Product product)
        {
            string type = product.ProdType.ToString();
            switch (type)
            {
                case "None":
                    product.TypeId = 1;
                    break;
                case "Best":
                    product.TypeId = 2;
                    break;
                case "Okay":
                    product.TypeId = 3;
                    break;
                case "Worst":
                    product.TypeId = 4;
                    break;
                case "Casual":
                    product.TypeId = 5;
                    break;
                default:
                    break;
            }
            return product.TypeId;
        }
    }
}
