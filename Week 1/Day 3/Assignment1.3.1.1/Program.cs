using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a simple console application to generate mathematical errors and handle them by exception handling.

namespace Assignment1._3._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            int num1, num2, result;

            while (true)
            {
                while (true)
                {
                    try
                    {
                        num1 = Int32.Parse(Console.ReadLine());
                        num2 = Int32.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Make sure you are entering an integer! Try again. \nEnter two numbers:");
                        continue;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                }

                try
                {
                    result = num1 / num2;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("You can't divide by zero! Try again. \nEnter two numbers:");
                    continue;
                }
                catch (ArithmeticException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                
                Console.WriteLine($"{num1} divided by {num2} is {result}");
                Console.ReadLine();
                break;
            }
        }
    }
}
