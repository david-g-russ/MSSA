using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Assignment12._4.Models
{
    public class TypeValidationAttribute : ValidationAttribute
    {
        public override string FormatErrorMessage(string name)
        {
            return "You must choose a valid product type";
        }
    }
}
