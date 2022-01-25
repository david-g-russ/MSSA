using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra1
{
    public struct Time
    {
        public int Min { get; set; } // public property
        public int ConvertToSec (int min) // function that converts to seconds with 1 int argument
        {
            return min * 60;
        }
        public int ConvertToSec() // function that converts to seconds with no argument
        {
            return Min * 60;
        }
        public Time(int min) // constructor that takes 1 int
        {
            this.Min = min;
        }
    }
}
