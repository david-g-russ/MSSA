using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtensionMethodTest
{
    public static class Extension
    {
        public static bool ContainsNumbers(this string s)
        {
            return Regex.IsMatch(s, @"\d");
        }

        public static bool GreaterThan10(this int i)
        {
            if (i > 10)  return true;
            else return false;
        }

        public static int By10(this List<int> l)
        {
            return l.Count * 10;
        }
    }
}
