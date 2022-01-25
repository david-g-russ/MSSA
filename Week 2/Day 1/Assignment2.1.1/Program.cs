using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a base class: ‘Shape’ and add properties like id, name and color and method like ‘calculate area’ .     
 * Inherit circle shape from base class and add properties like radius. override calculate area logic for circle.        
 * Inherit square class from shape and add change the calculate area logic. Add property like side of square.        
 * Take the input from user to select circle or square and display the calculated area . no hard coded values! */

namespace Assignment2._1._1
{
    internal class Program
    {
        #region Calculator Menu
        static bool CallMenu() //creates the Call Menu for the functions
        {
            int choice; // initialize user choice variable

            Console.WriteLine("Please select a menu option:"); // read out options to user
            Console.WriteLine(" 1. Calculate area of a circle \n 2. Calculate area of a square \n 3. Calculate area of a rectangle \n 4. Exit ");

            while (int.TryParse(Console.ReadLine(), out choice) == false) // check whether user enters a valid input that can be parsed as an int
            {
                InputErrorMsg(); // send invalid input message if user inputs a non-integer
            }
            switch (choice)
            {
                case 1:
                    {
                        Option1(); // call circle area function
                        return false; // send user back to call menu
                    }
                case 2:
                    {
                        Option2(); // call square area function
                        return false; // send user back to call menu
                    }
                case 3:
                    {
                        Option3(); // call rectangle area function
                        return false; // send user back to call menu
                    }
                case 4:
                    {
                        return true; // allow user to exit while loop in Main
                    }
                default:
                    {
                        InputErrorMsg();
                        return false; // send user back to call menu
                    }
            }
        }
        #endregion

        #region Menu Functions
        static void Option1() // Create new student function
        {
            double radius;
            Console.WriteLine("Please enter the radius of the circle:"); // request radius
            while (Double.TryParse(Console.ReadLine(), out radius) == false) // take user input for radius
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to double
            }
            Circle circle = new Circle(ColorChoice(),radius); // instantiate circle with color choice function
            Console.WriteLine(circle.ToString()); // use overriden ToString to display info
            Console.WriteLine($"The area of this circle is {circle.CalculateArea()}"); // display calculated area
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Option2() // Create new student function
        {
            double length;
            Console.WriteLine("Please enter the length of the square:"); // request length
            while (Double.TryParse(Console.ReadLine(), out length) == false) // take user input for length
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to double
            }
            Square square = new Square(ColorChoice(),length); // instantiate square with color choice function
            Console.WriteLine(square.ToString()); // use overriden ToString to display info
            Console.WriteLine($"The area of this square is {square.CalculateArea()}"); // display calculated area
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Option3() // Create new student function
        {
            double length, width;
            Console.WriteLine("Please enter the length of the rectangle:"); // request length
            while(Double.TryParse(Console.ReadLine(), out length) == false) // take user input for length
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to double
            }
            Console.WriteLine("Please enter the width of the rectangle:"); // request width
            while(Double.TryParse(Console.ReadLine(), out width) == false) // take user input for width
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to double
            }
            Rectangle rectangle = new Rectangle(ColorChoice(),length, width); // instantiate rectangle with color choice function
            Console.WriteLine(rectangle.ToString()); // use overriden ToString to display info
            Console.WriteLine($"The area of this rectangle is {rectangle.CalculateArea()}"); // display calculated area
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void InputErrorMsg() // make code easier to read by compacting function to display an invalid input
        {
            Console.ForegroundColor = ConsoleColor.Red; // set font to red
            Console.WriteLine("Invalid input, try again:"); // lets user know they entered an invalid input
            Console.ForegroundColor = ConsoleColor.White; // reset font to white
        }

        static string ColorChoice() // shape color choice function
        {
            bool cont;
            Console.WriteLine("Please choose a color for your shape from the following options:");
            Console.WriteLine("1. Blue, 2. Green, 3. Yellow, 4. Cyan, 5. Magenta");
            do
            {
                cont = false;
                if (Int32.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            return "blue";
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;
                            return "green";
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            return "yellow";
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            return "cyan";
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            return "magenta";
                        default:
                            cont = true;
                            break;
                    }
                }
                if (cont)
                {
                    InputErrorMsg();
                }
            } while (cont);
            return null;
            
        }

        #endregion
        static void Main(string[] args)
        {
            while (CallMenu() == false)
            {
                // :D
            }
            Console.ReadLine();

        }
    }
}
