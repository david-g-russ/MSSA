using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._1
{
    internal struct ReverseString
    {
        public string Str { get; set; }

        public string RevString()
        {
            StringBuilder sb = new StringBuilder();

            for(int i = Str.Length-1; i >= 0; i--)
            {
                sb.Append(Str[i]);
            }

            return sb.ToString();
        }
        public string RevString(string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }

        public ReverseString(string str)
        {
            this.Str = str;
        }
            

    }
}
