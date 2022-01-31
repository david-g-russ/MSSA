using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._1
{
    internal struct StringSpaces
    {
        public string Str { get; set; } // public property

        public int CheckSpaces(string str) // check spaces function with 1 str parameter
        {
            int count = 0; // set initial count to 0
            foreach (char c in str) // go through each char in the string
            {
                if (c == ' ') count++; // if the char is a space, increase the count
            }
            return count; // return the final count
        }

        public int CheckSpaces() // check spaces function with no parameters
        {
            int count = 0; // set initial count to 0
            foreach (char c in Str) // go through each char in the string
            {
                if (c == ' ') count++; // if the char is a space, increase the count
            }
            return count; // return the final count
        }

        public StringSpaces(string str) // constructor taking 1 string
        {
            this.Str = str;
        }

    }
}
