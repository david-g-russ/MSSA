using System.Collections.Generic;

namespace Assignment12._3.Models
{
    public interface IProductRepository
    {
        List<Product> Products { get; set; }

        List<Product> InitializeProducts();

        Product GetProduct(int? id);

        void AddProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(int? id);
    }
}
