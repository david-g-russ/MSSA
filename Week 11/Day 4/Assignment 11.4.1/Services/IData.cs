using Assignment_11._4._1.Models;
using System.Collections.Generic;

namespace Assignment_11._4._1.Services
{
    public interface IData
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
