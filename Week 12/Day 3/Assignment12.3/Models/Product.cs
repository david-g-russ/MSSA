using System.ComponentModel.DataAnnotations;

namespace Assignment12._3.Models
{
    public class Product
    {
        [Display(Name = "Product ID")]
        [Required]
        public int Id { get; set; }

        [MaxLength(50)]
        [Display(Name = "Product Name")]
        [Required]
        public string Name { get; set; }

        [MaxLength(100)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string ImageName { get; set; }

        [Display(Name = "Product Category")]
        public ProductType ProductType { get; set; }
    }

    public enum ProductType
    {
        None,
        Best,
        Okay,
        Worst,
        Casual
    }
}