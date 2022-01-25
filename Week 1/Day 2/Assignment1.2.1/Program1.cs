using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2._1
{
    class Program1
    {
        #region Calculator Functions

        //define basic calculator functions for addition, subtraction, multiplication and division
        static int addNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        static int subtractNumbers(int num1, int num2)
        {
            return num1 - num2;
        }

        static int multiplyNumbers(int num1, int num2)
        {
            return num1 * num2;
        }

        static int divideNumbers(int num1, int num2)
        {
            return num1 / num2;
        }
        #endregion

        #region Calculator Menu 
        // Creates the menu options and general flow of the calculator
        static void CallMenu()
        { 
                Console.WriteLine("Enter the number corresponding to the operation you would like to perform:"); // query the user to enter a number that corresponds to a function of the calculator
                Console.WriteLine(" 1. Addition \n 2. Subraction \n 3. Multiplication \n 4. Division");
                int choice = Int32.Parse(Console.ReadLine()); // take input from user and convert to int32
            switch (choice)
            {
                case 1: // addition case
                    Console.WriteLine("Type the first number you would like to add:");
                    int add1 = Int32.Parse(Console.ReadLine()); //take first input
                    Console.WriteLine("Type the second number you would like to add:");
                    int add2 = Int32.Parse(Console.ReadLine()); // take second input
                    Console.WriteLine($"The sum of those two numbers is {addNumbers(add1, add2)}"); // perform operation and display result
                    break;
                case 2: // subtraction case
                    Console.WriteLine("Type the number you would like to subtract from:");
                    int sub1 = Int32.Parse(Console.ReadLine()); //take first input
                    Console.WriteLine("Type the number you would like to subtract:");
                    int sub2 = Int32.Parse(Console.ReadLine()); // take second input
                    Console.WriteLine($"The difference between those two numbers is {subtractNumbers(sub1, sub2)}"); // perform operation and display result
                    break;
                case 3: // multiplication case
                    Console.WriteLine("Type the first number you would like to multiply:");
                    int mul1 = Int32.Parse(Console.ReadLine()); //take first input
                    Console.WriteLine("Type the second number you would like to multiply:");
                    int mul2 = Int32.Parse(Console.ReadLine()); // take second input
                    Console.WriteLine($"The product of those two numbers is {multiplyNumbers(mul1, mul2)}"); // perform operation and display result
                    break;
                case 4: // division case
                    Console.WriteLine("Type the number you would like to divide:");
                    int div1 = Int32.Parse(Console.ReadLine()); //take first input
                    Console.WriteLine("Type the number you would like to divide by:");
                    int div2 = Int32.Parse(Console.ReadLine()); // take second input
                    Console.WriteLine($"The quotient of those two numbers is {divideNumbers(div1, div2)}"); // perform operation and display result
                    break;
                default: // if the user does not choose one of the functions correctly
                    Console.WriteLine("That is not an option!");
                    break;
            }
        } 
        #endregion
        static void Main(string[] args)
        {
            char keepGoing; // initialize the while variable
            do
            {
                CallMenu(); // call the menu function
                Console.WriteLine("Would you like to perform another function? Y or N"); // determine if the user wants to continue
                keepGoing = Char.ToUpper(Char.Parse(Console.ReadLine())); //set the while variable and convert to uppercase
            } while (keepGoing == 'Y'); // continue as long as user types 'Y' or 'y'
            Console.ReadLine(); // pause to allow user to review console
        }
    }
}