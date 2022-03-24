using Assignment_11._4._1.Models;
using System.Collections.Generic;

namespace Assignment_11._4._1.Services
{
    public class ProductData : IData
    {
        private int _id;
        public ProductData()
        {
            _id = 0;
        }
        public void AddProduct(Product product)
        {
            // throw new System.NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            // throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            // throw new System.NotImplementedException();
            return null;
        }

        public Product GetById(int id)
        {
            // throw new System.NotImplementedException();
            return null;
        }

        public void UpdateProduct(Product product)
        {
            // throw new System.NotImplementedException();
        }
    }
}
