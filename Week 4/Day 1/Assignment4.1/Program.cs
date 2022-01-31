using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1. Return even numbers:

Write a method that returns a string of even numbers greater than 0 and less than 100.

Expected input and output

ReturnEvenNumbers() → "2 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46 48 50 52 54 56 58 60 62 64 66 68 70 72 74 76 78 80 82 84 86 88 90 92 94 96 98"

2. If year is leap:

Given a year as integer, write a method that checks if year is leap.

Expected input and output

IfYearIsLeap(2016) → true IfYearIsLeap(2018) → false

3. String in reverse order:

Given a string, write a method that returns that string in reverse order.

Expected input and output

StringInReverseOrder("qwerty") → "ytrewq" StringInReverseOrder("oe93 kr") → "rk 39eo"

4. Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.

Test Data : Please input a string : This is a test string.

Expected Output : "This is a test string." contains 4 spaces 
*/

namespace Assignment4._1
{
    internal class Program
    {

        #region Program Menu
        static bool CallMenu() //creates the Call Menu for the functions
        {
            int choice; // initialize user choice variable

            Console.WriteLine("Please select a menu option: \n"); // read out options to user
            Console.WriteLine(" 1. Return even numbers \n" +
                              " 2. Determine if a year is a year leap \n" +
                              " 3. Reverse a string \n" +
                              " 4. Count number of spaces in a string \n" +
                              " 5. Exit");

            while (int.TryParse(Console.ReadLine(), out choice) == false) // check whether user enters a valid input that can be parsed as an int
            {
                InputErrorMsg(); // send invalid input message if user inputs a non-integer
            }
            switch (choice)
            {
                case 1:
                    Option1(); // call even numbers function
                    return false; // send user back to menu
                case 2:
                    Option2(); // call leap year function
                    return false; // send user back to menu
                case 3:
                    Option3(); // call reverse string function
                    return false; // send user back to menu
                case 4:
                    Option4(); // call number of spaces function
                    return false; // send user back to menu
                case 5:
                    return true; // allow user to exit while loop in Main
                default:
                    InputErrorMsg();
                    return false; // send user back to menu
            }
        }
        #endregion

        #region Menu Functions
        static void Option1() // Return even numbers
        {
            int minnum, maxnum;
            Console.WriteLine("Please enter lower bound for even numbers:"); // request lower bound
            while (Int32.TryParse(Console.ReadLine(), out minnum) == false) // take user input for upper bound
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to int32
            }
            Console.WriteLine("Please enter upper bound for even numbers:"); // request upper bound
            while (Int32.TryParse(Console.ReadLine(), out maxnum) == false) // take user input for upper bound
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to int32
            }
            if (minnum > maxnum) // ensure that the lower bound is beneath the upper bound
            {
                Console.ForegroundColor = ConsoleColor.Red; // set font to red
                Console.WriteLine("You cannot choose an upper bound that is less than the lower bound."); // display bounding error
            }
            else // if bounds are good, complete logic
            {
                Console.ForegroundColor = ConsoleColor.Green;
                EvenNum evennum = new EvenNum(minnum, maxnum); // instantiate struct
                Console.WriteLine($"The even numbers ranging from {minnum} to {maxnum} are:\n{evennum.EvenRange()}"); // display even numbers
            }
            Console.ForegroundColor = ConsoleColor.White; // reset font to white
        }

        static void Option2() // Determine if a year is a leap year
        {
            int year;
            Console.WriteLine("Please enter the desired year (use positive numbers for AD, negative for BC):"); // request year
            while (Int32.TryParse(Console.ReadLine(), out year) == false) // take user input for year
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to int32
            }
            LeapYear leapYear = new LeapYear(year); // instantiate struct
            if (leapYear.LeapTruth() == true) // check if it is a leap year
            {
                Console.ForegroundColor = ConsoleColor.Green; // set font to green
                Console.WriteLine($"The year {year} is a Leap Year"); // display that it is a leap year
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow; // set font to yellow
                Console.WriteLine($"The year {year} is not a Leap Year"); // display that it is not a leap year
            }
            Console.ForegroundColor= ConsoleColor.White; // reset font to white
        }

        static void Option3() // Reverse a string
        {
            Console.WriteLine("Please enter the desired string:"); // request string
            string str = Console.ReadLine(); // set string to user input
            ReverseString reverseString = new ReverseString(str); // instantiate struct
            Console.ForegroundColor = ConsoleColor.Green; // set font to green
            Console.WriteLine($"Your string \"{str}\" reversed, is:\n{reverseString.RevString()}"); // display result of reversal
            Console.ForegroundColor = ConsoleColor.White; // reset font to white
        }
        static void Option4() // Count spaces in a string
        {
            Console.WriteLine("Please enter the desired string:"); // request string
            string str = Console.ReadLine(); // take user input for string
            StringSpaces stringSpaces = new StringSpaces(str);
            Console.ForegroundColor = ConsoleColor.Green; // set font to green
            Console.WriteLine($"The number of spaces in the string \"{str}\" is: {stringSpaces.CheckSpaces()}"); // display results
            Console.ForegroundColor = ConsoleColor.White; // reset font to white
        }
       
        static void InputErrorMsg() // make code easier to read by compacting function to display an invalid input
        {
            Console.ForegroundColor = ConsoleColor.Red; // set font to red
            Console.WriteLine("Invalid input, try again:"); // lets user know they entered an invalid input
            Console.ForegroundColor = ConsoleColor.White; // reset font to white
        }

        #endregion
        static void Main(string[] args)
        {
            while (CallMenu() == false)
            {
                // :)
            }
            Console.ReadLine();

        }
    }
}
