using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2._2
{
    internal class Program
    {
        private const double tipRate = 0.18;
        static void Main(string[] args)
        {
            double billTotal;
            if(args.Length == 0 || !Double.TryParse(args[0], out billTotal))
            {
                Console.WriteLine("Please enter the bill total as an argument.");
                return;
            }
            double tip = billTotal * tipRate;
            Console.WriteLine($"\nBill total:\t{billTotal,10:c}");
            Console.WriteLine($"Tip total/rate:\t{tip,10:c} ({tipRate:p1})");
            Console.WriteLine(("").PadRight(26, '-'));
            Console.WriteLine($"Grand total:\t{billTotal + tip,10:c}");
        }
    }
}