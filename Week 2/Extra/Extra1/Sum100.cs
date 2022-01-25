using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra1
{
    internal struct Sum100
    {
        public int Num1 { get; set; } // public property
        public int Num2 { get; set; } // public property
        public bool Sum() // check sum that takes no args
        {
            if (Num1 + Num2 < 100) // if the sum is less than 100 return true
                return true;
            else
                return false; // otherwise return false
        }
        public bool Sum(int num1, int num2) // check sum that takes 2 ints as args
        {
            if (num1 + num2 < 100) // if the sum is less than 100 return true
                return true;
            else
                return false; // otherwise return false
        }
        public Sum100(int num1, int num2) // constructor that takes 2 ints 
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }

    }
}
