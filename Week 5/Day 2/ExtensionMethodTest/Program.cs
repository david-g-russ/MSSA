using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtensionMethodTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "test";
            s.Contains("test");
            s.ContainsNumbers();
            ContainsNumbers(s);
            
            int i = 100;
            i.GreaterThan10();

            List<int> intlist = new List<int>();
            intlist.Add(i);
            intlist[0].GreaterThan10();
            intlist.By10();
        }

        static bool ContainsNumbers(string s)
        {
            return Regex.IsMatch(s, @"\d");
        }
    }
}