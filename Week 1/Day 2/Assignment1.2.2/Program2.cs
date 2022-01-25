using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2._2
{
    class Program2
    {
       static bool CheckEqual(int num1, int num2) // define function to determine if two numbers are equal
        {
            if (num1 == num2) //determine equality and return boolean
                return true;
            else
                return false;
       }
       static void Main(string[] args)
       {
            // initialize variables to be used in while loop
            bool continueAnswer;
            int num1;
            int num2;
            do
            {
                Console.WriteLine("Please input the first integer you would like to compare:"); // request input for first number
                num1 = Int32.Parse(Console.ReadLine()); // convert to int32
                Console.WriteLine("Please input the second integer you would like to compare:"); // request input for second number
                num2 = Int32.Parse(Console.ReadLine()); // convert to int32
                if (CheckEqual(num1, num2) == true) // use equality function
                {    Console.ForegroundColor = ConsoleColor.Green; // set font to green if true
                     Console.WriteLine($"{num1} and {num2} are equal"); // output that they are equal if true
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red; // set font to red if false
                    Console.WriteLine($"{num1} and {num2} are not equal");  // output that they are not equal if false
                }
                Console.ForegroundColor = ConsoleColor.White; // reset font to white
                Console.WriteLine("Would you like to compare two more numbers?"); // determine whether user would like to continue
                string answerString = Console.ReadLine(); // take input from user on continuing
                switch (answerString.ToLower()) // convert their answer to lowercase
                {
                    case "yes":
                        continueAnswer = true; // set while variable to true if "yes" is input
                        break;
                    case "no":
                        continueAnswer = false; // set while variable to false if "no" is input
                        break;
                    default:
                        Console.WriteLine("I'm assuming that means no.");
                        continueAnswer = false; // set while variable to false if anything else is input
                        break;
                }
            } while (continueAnswer == true); // continue while loop as long as user answers "yes" to continuing
            Console.ReadLine(); // pause at end to allow user to view console
        }
    }
}