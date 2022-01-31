using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._1
{
    internal struct LeapYear
    {
        public int Year { get; set; }

        public bool LeapTruth(int year)
        {
            if (year % 4 == 0)
                return true;
            return false;
        }
        public bool LeapTruth()
        {
            if (Year % 4 == 0)
                return true;
            return false;
        }

        public LeapYear(int year)
        {
            this.Year = year;
        }
    }
}
