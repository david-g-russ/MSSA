using System.ComponentModel.DataAnnotations;

namespace MVCTest2.Models
{
    // Step 1: Object model
    public class Employee
    {
        // display annotations, data annotations
        [Display(Name = "Employee Id")]
        [Required] // server side
        public int Id { get; set; }

        [Display(Name = "Employee Name")]
        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }

        public int Age { get; set; }

        [MaxLength(100, ErrorMessage = "Address cannot exceed 100 characters")]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        public string ImageName { get; set; }

        public Dept Dept { get; set; }

        [Display(Name = "Office email")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",ErrorMessage = "Invalid email format")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }

    public enum Dept
    {
        None,
        HR,
        Finance,
        IT,
        Marketing
    }
}