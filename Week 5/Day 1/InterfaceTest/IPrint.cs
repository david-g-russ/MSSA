using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    interface IPrint
    {
        // properties, methods, event signatures
        void PrintName(string msg);

        string ErrorMsg { get; set; }
    }

    interface I2
    {
        void Test();
    }

    interface IinventoryItem
    {
        bool isFairTrade { get; }
    }

    interface IBeverage
    {
        bool isFairTrade { get; set; }
    }

    class Coffee : IBeverage, IinventoryItem
    {
        bool IBeverage.isFairTrade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        bool IinventoryItem.isFairTrade => throw new NotImplementedException();
    }
}

    class PrintCls : IPrint, I2
    {
        // logic in methods provided by implementor (class)

        string IPrint.ErrorMsg { get; set; }
        public void PrintName(string msg)
        {
            Console.WriteLine($"Welcome {msg}");
        }
        public void Test()
        {
            // logic
        }

    }

    class PrintDifferent : IPrint
    {
        public string ErrorMsg { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public void PrintName(string msg)
        {
            Console.WriteLine($"No welcome {msg}");
        }
    }
}
