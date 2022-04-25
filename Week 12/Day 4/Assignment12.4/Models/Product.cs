using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment12._4.Models
{
    public class Product
    {
        [Display(Name = "Product ID")]
        [Required(ErrorMessage = "You must create a Product ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "Product name must be less than 50 characters")]
        [Display(Name = "Product Name")]
        [Required]
        [NameValidation]
        public string Name { get; set; }

        [MaxLength(100)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "You must list a price for the product")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string ImageName { get; set; }

        [Display(Name = "Product Type")]
        [TypeValidation]
        public ProdType ProdType { get; set; }

        public int TypeId { get; set; }
    }

    public enum ProdType
    {
        None = 1,
        Best,
        Okay,
        Worst,
        Casual
    }
}