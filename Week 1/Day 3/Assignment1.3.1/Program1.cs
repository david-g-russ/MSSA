using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program in C# to calculate area of triangle, square and rectangle.
Write 3 different functions for each shape to take dimensions of figure and display the area.
You may create menus. */

namespace Assignment1._3._1
{
    class Program1
    {
        #region Calculator Functions

        //define basic calculator functions for addition, subtraction, multiplication and division
        static float TriArea(float height, float baselength) // takes triangle height and base length and returns area
        {
            return (height * baselength) / 2; // multiply height by baselength and divide by 2
        }

        static int SquareArea(int side) // takes square side length and returns area
        {
            return side ^ 2; // square the side length
        }

        static int RectArea(int side1, int side2) // takes two rectangle sides and returns area
        {
            return side1 * side2; // multiply side 1 by side 2
        }

        #endregion

        #region Area Calculator Menu 
        // Creates the menu options and general flow of the calculator
        static void CallMenu()
        {
            Console.WriteLine("Enter the number corresponding to the operation you would like to perform:"); // query the user to enter a number that corresponds to a function of the calculator
            Console.WriteLine(" 1. Triangle Area (height, base) \n 2. Square Area \n 3. Rectangle Area");
            int choice = Int32.Parse(Console.ReadLine()); // take input from user and convert to int32
            switch (choice)
            {
                case 1: // triangle case
                    Console.WriteLine("Type the height of the triangle:");
                    float triH = Single.Parse(Console.ReadLine()); //take first input
                    Console.WriteLine("Type the base length of the triangle:");
                    float triB = Single.Parse(Console.ReadLine()); // take second input
                    Console.WriteLine($"The area of the triangle is {TriArea(triH, triB)}"); // perform operation and display result
                    break;
                case 2: // square case
                    Console.WriteLine("Type the square side length:");
                    int squareS = Int32.Parse(Console.ReadLine()); //take first input
                    Console.WriteLine($"The area of the square is {SquareArea(squareS)}"); // perform operation and display result
                    break;
                case 3: // rectangle case
                    Console.WriteLine("Type the first side length:");
                    int rectS1 = Int32.Parse(Console.ReadLine()); //take first input
                    Console.WriteLine("Type the second side length:");
                    int rectS2 = Int32.Parse(Console.ReadLine()); // take second input
                    Console.WriteLine($"The area of the rectangle is {RectArea(rectS1, rectS2)}"); // perform operation and display result
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