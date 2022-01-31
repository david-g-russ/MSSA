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
            if (year > 0) // check if AD or BC
                if (year % 4 == 0) // if AD divide by 4 to check
                    return true;
                else
                    return false;
            else if (year < 0)
                if (year - 1 % 4 == 0) // if BC subtract 1 then divide by 4 to check
                    return true;
            return false;
        }
        public bool LeapTruth()
        {
            if (Year > 0) // check if AD or BC
                if (Year % 4 == 0) // if AD divide by 4 to check
                    return true;
                else
                    return false;
            else if (Year < 0)
                if (Year - 1 % 4 == 0) // if BC subtract 1 then divide by 4 to check
                    return true;
            return false;
        }

        public LeapYear(int year)
        {
            this.Year = year;
        }
    }
}
