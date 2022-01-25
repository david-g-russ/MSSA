using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra1
{
    internal struct StringCase
    {
        public string S1 { get; set; } // public property
        public string ReverseCase(string s1) // ReverseCase function when passed a string
        {
            StringBuilder sb = new StringBuilder(); // instantiate stringbuilder
            foreach (char c in s1) // go through each char in the passed string
            {
                if (char.IsLower(c)) // check if it's lowercase
                    sb.Append(char.ToUpper(c)); // if lowercase, make uppercase
                else
                    sb.Append(char.ToLower(c)); // if uppercase, make lowercase
            }
            return sb.ToString(); // build string and return it
        }
        public string ReverseCase() // ReverseCase function when passed nothing
        {
            StringBuilder sb = new StringBuilder(); // instantiate stringbuilder
            foreach (char c in S1) // go through each char in the string property
            {
                if (char.IsLower(c)) // if lowercase, make uppercase
                    sb.Append(char.ToUpper(c));
                else // if uppercase, make lowercase
                    sb.Append(char.ToLower(c));
            }
            return sb.ToString(); // build string and return it
        }
        public StringCase(string s1) // constructor that takes a string
        {
            this.S1 = s1;
        }

    }
}
