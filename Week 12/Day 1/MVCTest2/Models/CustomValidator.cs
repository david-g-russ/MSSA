using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;

namespace MVCTest2.Models
{
    public class CustomValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value != null)
                return ((string)value).All(char.IsLetter);
            return false;
        }
        public override string FormatErrorMessage(string name)
        {
            return "You must use only letters.";
        }
    }
}
