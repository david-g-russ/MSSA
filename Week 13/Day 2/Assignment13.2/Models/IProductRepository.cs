using System.Collections.Generic;

namespace Assignment12._4.Models
{
    public interface IProductRepository
    {
        List<Product> Products { get; set; }

        IEnumerable<Product> InitializeProducts();

        Product GetProduct(int? id);

        void AddProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(int? id);
    }
}
