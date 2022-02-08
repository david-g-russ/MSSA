using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintCls obj = new PrintCls();
            obj.PrintName("all");
            
            PrintDifferent obj2 = new PrintDifferent();
            obj2.PrintName("all");

            I2 i2 = new PrintCls(); // cross reference
        }
    }
}