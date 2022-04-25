using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment_13._3.Models
{
    public class ProductType
    {
        [Key]
        public int TypeId { get; set; }

        public string TypeName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
