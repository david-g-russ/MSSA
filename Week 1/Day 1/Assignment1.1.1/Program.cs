using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White; //set console background to white
            Console.ForegroundColor = ConsoleColor.DarkBlue; //set console foreground to dark blue
            float age; //init age variable
            string firstName; //init first name variable
            string address; //init address variable
            Console.WriteLine("Please enter your name:"); //request input for name
            firstName = Console.ReadLine(); //user inputs first name
            Console.WriteLine("Please enter your age using a number with one decimal place:"); //request input for age
            age = Convert.ToSingle(Console.ReadLine()); //converts user string input to float
            Console.WriteLine("Enter your street address:"); //request input for address
            address = Console.ReadLine(); //user inputs address
            Console.WriteLine("Your information:"); //begins display of info
            Console.WriteLine($"Name is {firstName}, age is {age}, address is {address}"); //uses string interpolation to display info
            Console.ReadLine(); //pauses program to allow user to view output
        }
    }
}