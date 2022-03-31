using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Assignment12._3.Models
{
    public class NameValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return ((string)value).All(char.IsLetter);
        }
        public override string FormatErrorMessage(string name)
        {
            return "Product name must consist only of letters";
        }
    }
}
