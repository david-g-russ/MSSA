using System.Collections.Generic;
using CustomMiddleware.Models;

namespace CustomMiddleware.Services
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
