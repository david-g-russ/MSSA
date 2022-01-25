using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra1
{
    internal struct OddEven
    {
        public int Num1 { get; set; } // public property
        public string CheckEven() // check even that takes no args
        {
            if (Num1 % 2 == 0) // check remainder of dividing by 2, if = 0 it's even
                return "even";
            else
                return "odd"; // otherwise it's odd
        }
        public string CheckEven(int num1) // check even that takes 1 int
        {
            if (num1 % 2 == 0) // check remainder of dividing by 2, if = 0 it's even
                return "even";
            else
                return "odd"; // otherwise it's odd
        }
        public OddEven(int num1) // constructor that takes 1 int
        {
            this.Num1 = num1;
        }
    }
}
