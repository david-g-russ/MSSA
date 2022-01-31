using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._1
{
    internal struct EvenNum
    {
        // public properties
        public int MaxNum { get; set; }
        public int MinNum { get; set; }

        public string EvenRange() // even number range given no parameters
        {
            StringBuilder sb = new StringBuilder(); // create stringbuilder
            MinNum = MinNum % 2 == 0 ? MinNum + 2 : MinNum + 1; // check if MinNum is even, if not add 1 to get to next even number in the range, if it is skip to the next even number (range does not include bounds)

            for (int i = MinNum; i < MaxNum; i+=2) // iterate by 2 from lower bound to upper bound
            {
                sb.Append(i.ToString()+' '); // append each number to stringbuilder
            }

            return sb.ToString(); // return completed string from stringbuilder
        }

        public string EvenRange(int minnum, int maxnum) // even number range given 2 int parameters
        {
            StringBuilder sb = new StringBuilder(); // create stringbuilder
            minnum = minnum % 2 == 0 ? minnum + 2 : minnum + 1; // check if minnum is even, if not add 1 to get to next even number in the range, if it is skip to the next even number (range does not include bounds)

            for (int i = minnum; i < maxnum; i += 2) // iterate by 2 from lower bound to upper bound
            {
                sb.Append(i.ToString() + ' '); // append each number to stringbuilder
            }

            return sb.ToString(); // return completed string from stringbuilder
        }

        public EvenNum(int minnum, int maxnum) // constructor that takes 2 ints
        {
            this.MaxNum = maxnum;
            this.MinNum = minnum;
        }
    }
}
