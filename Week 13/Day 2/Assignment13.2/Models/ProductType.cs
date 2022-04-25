using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment12._4.Models
{
    public class ProductType
    {
        [Key]
        public int TypeId { get; set; }

        public string TypeName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
