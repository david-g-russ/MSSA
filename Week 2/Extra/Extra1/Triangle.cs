using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra1
{
    internal class Triangle
    {
        public int Height { get; set; } // public property
        public int Length { get; set; } // public property
        public int CalculateArea() // calculate area with no arguments
        {
            return (Height*Length)/2;
        }
        public int CalculateArea(int length, int height) // calculate area given 2 int
        {
            return (height*length)/2;
        }
        public Triangle(int length, int height) // constructor that takes 2 ints
        {
            this.Length = length;
            this.Height = height;
        }
    }
}
