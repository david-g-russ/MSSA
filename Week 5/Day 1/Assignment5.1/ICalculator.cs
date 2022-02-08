using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._1
{
    interface ICalculator
    {
        decimal Add(decimal num1, decimal num2);
        decimal Multiply(decimal num1, decimal num2);
        decimal Divide(decimal num1, decimal num2);
        decimal Subtract(decimal num1, decimal num2);
    }

    public enum Operator
    {
        Plus,
        Minus,
        Times,
        DividedBy
    }

    public class Calculator : ICalculator
    {
        public Operator Operator { get; set; }
       
        public decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public decimal Divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }

        public decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        public decimal Subtract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
    }
}
