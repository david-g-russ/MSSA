using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Create a structure named “Point” and 2 data members: X and Y coordinate. Declare 2 points: P1 and P2. 
Determine if P2 is to the right or left of P1 or on same axis , by comparing the x xoordinates. 
( if p1.x is more than p2.x , it is to the right ) */

namespace Assignment1._4._1
{
    internal class Program1
    {
        static string XComparison(Point P1, Point P2) // function that checks whether point P2's X coordinate is to the left or right of P1's X coordinate
        {
            if (P2.X < P1.X) // returns a string according to the result of the comparison of P2 and P1 X coordinates
                return "left"; 
            else
                return "right";
        }

        static void Main(string[] args)
        {
            string choice; // initialize while variable
            int x1, y1, x2, y2; // initialize coordinate variables
            
            while (true) // begin while loop to enable user to keep going as long as desired
            {
                Console.WriteLine("Please enter the first point x-coordinate:"); // request first point x-coordinate
                while (int.TryParse(Console.ReadLine(), out x1) == false) // force user to enter an integer with TryParse and a while loop
                {
                    Console.WriteLine("Invalid input, try again:"); // inform of invalid input
                }
                Console.WriteLine("Please enter the first point y-coordinate:"); // request first point y-coordinate
                while (int.TryParse(Console.ReadLine(), out y1) == false) // force user to enter an integer with TryParse and a while loop
                {
                    Console.WriteLine("Invalid input, try again:"); // inform of invalid input
                }
                Console.WriteLine("Please enter the second point x-coordinate:"); // request second point x-coordinate
                while (int.TryParse(Console.ReadLine(), out x2) == false) // force user to enter an integer with TryParse and a while loop
                {
                    Console.WriteLine("Invalid input, try again:"); // inform of invalid input
                }
                Console.WriteLine("Please enter the second point y-coordinate:"); // request second point y-coordinate
                while (int.TryParse(Console.ReadLine(), out y2) == false) // force user to enter an integer with TryParse and a while loop
                { 
                    Console.WriteLine("Invalid input, try again:"); // inform of invalid input
                }

                Point P1 = new Point(x1, y1); // initialize struct P1 with x1 and y1 coordinates
                Point P2 = new Point(x2, y2); // initialize struct P2 with x2 and y2 coordinates

                Console.WriteLine($"Point P1 is at coordinates {P1.X}, {P1.Y}"); // display coordinates for P1
                Console.WriteLine($"Point P2 is at coordinates {P2.X}, {P2.Y}"); // display coordinates for P2

                if (XComparison(P1, P2) == "left") // determines whether the font will be red or green based off of the comparison of X coordinates
                    Console.ForegroundColor = ConsoleColor.Red; // if P2's X coordinate is to the left of P1's X coordinate, font will be red
                else
                    Console.ForegroundColor = ConsoleColor.Green; // if P2's X coordinate is to the right of P1's X coordinate, font will be green

                Console.WriteLine($"Point P2 is to the {XComparison(P1, P2)} of Point P1"); // display result of comparison of X coordinates

                Console.ForegroundColor = ConsoleColor.White; // reset font color to white
                Console.WriteLine("Would you like to run it again?"); // query user to keep going

                while (true) // while loop that enables the program to continue if an exception is thrown
                {
                    try
                    { 
                        choice = Console.ReadLine(); // assign choice string based on user input
                        break; // continue to if statement if success
                    }
                    catch (Exception ex) // catches any exception that may be thrown by user input
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // set font to red
                        Console.WriteLine(ex.Message); // display exception message
                        Console.WriteLine("I don't know how you managed to mess that up \nTry again:"); // instruct user to try again
                        continue; // send user back to input
                    }
                    finally
                    {
                        Console.ForegroundColor = ConsoleColor.White; // reset font to white
                    }
                }

                if (choice.ToLower() == "yes" || choice.ToLower() == "yep" || choice.ToLower() == "yeah" || choice.ToLower() == "y") // check whether user wants to continue
                {
                    Console.ForegroundColor= ConsoleColor.Green; // set font to green
                    Console.WriteLine("Sweet, let's run it back!"); // display message if they want to continue
                    Console.ForegroundColor=ConsoleColor.White; // reset font to white
                    continue; // send user back to start of program with new points
                }
                else if (Int32.TryParse(choice, out int result)) // check whether they wrote a number instead of a word
                {
                    Console.ForegroundColor= ConsoleColor.Red; // change font to red
                    Console.WriteLine("That is clearly a number, so I'm assuming you don't want to keep going."); // inform user that they wrote a number
                    break; // end program
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red; // change font to red
                    Console.WriteLine("So that's a no, then."); // inform user that the program is ending
                    break; // end program
                }

            }
            Console.ReadLine(); // pause to allow user to view output
        }
    }
}