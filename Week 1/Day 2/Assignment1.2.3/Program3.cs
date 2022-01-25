using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2._3
{
    class Program3
    {
        static void Main(string[] args)
        {
            int sum = 0; // initialize the sum variable
            bool keepGoing; // intialize the while variable
            
            do // begin while loop
            {
                Console.WriteLine("Starting from 1, how many natural numbers would you like to add?"); // request how many numbers the user wants to add
                int desiredNaturals = Int32.Parse(Console.ReadLine()); // take input and convert to int32
                int[] naturalArray = new int[desiredNaturals]; // initialize an array to store the natural numbers

                for (int i = 1; i < desiredNaturals + 1; i++) // begin the for loop to calculate the sum
                {
                    sum = sum + i; // add each number to the sum
                    naturalArray[i - 1] = i; // add the number to the array of naturals
                }
                Console.WriteLine($"The first {desiredNaturals} natural numbers are:");
                Console.WriteLine(string.Join(" ", naturalArray)); // convert the array of natural numbers to a string with a space delimiter
                Console.WriteLine($"The Sum is: {sum}"); // output the sum of the natural numbers
                Console.WriteLine("Would you like to do it again? Y or N"); // request if user would like to do it again
                char choice = Char.ToUpper(Char.Parse(Console.ReadLine())); // convert input to uppercase character
                if (choice == 'Y')
                    keepGoing = true; // continue while loop if user enters 'y' or 'Y'
                else
                    keepGoing = false; // stop while loop if user enters anything else
            } while (keepGoing == true);
            Console.ReadLine(); // pause the program to allow user to view console
        }
    }
}