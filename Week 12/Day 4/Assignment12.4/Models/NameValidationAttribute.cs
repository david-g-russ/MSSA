using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Assignment12._4.Models
{
    public class NameValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value != null)
                return ((string)value).All(char.IsLetter);
            return false;
        }
        public override string FormatErrorMessage(string name)
        {
            return "Product name must consist only of letters";
        }
    }
}
