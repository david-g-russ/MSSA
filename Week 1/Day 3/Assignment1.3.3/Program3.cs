using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to sort an integer array in ascending and descending order. Array can be created with hard coded values.

namespace Assignment1._3._3
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of elements to store in the array:"); // request number of elements the user would like in the array
            int size = Int32.Parse(Console.ReadLine()); // take input and convert to Int32
            int[] array1 = new int[size]; // initialize an array of the size requested by user
            Console.WriteLine($"Input {size} numbers to store in the array:"); // request the user to begin inputting numbers to store in the array

            for (int i = 0; i < array1.Length; i++) // begin for loop, repeating the number of times the user requested for size
            {
                Console.WriteLine($"Index {i}:"); // Let user know which array index they are inputting the number for
                array1[i] = Int32.Parse(Console.ReadLine()); // Convert the number the user inputs to Int32 and place into array at appropriate index
            }

            Console.WriteLine($"The {size} values stored into the array are:"); // announce array the user created
            Console.WriteLine(string.Join(" ", array1)); // convert array into string and display

            int temp; //initialize placeholder variable
            for (int j = 0; j <= array1.Length - 2; j++) // outside for loop to run inner loop for number of times necessary
            {
                for (int k = 0; k <= array1.Length - 2; k++) // inner for loop that performs one pass of bubble sort
                {
                    if (array1[k] > array1[k + 1]) // checks if number in array is greater or less than the next number and then swaps the numbers if true
                    {
                        temp = array1[k + 1]; // if greater, place next number value into placeholder
                        array1[k + 1] = array1[k]; // move current number to next index
                        array1[k] = temp; // take placeholder value (previously the next number) and put in current index
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Green; // set font to green
            Console.WriteLine($"The {size} values stored into the array in ascending order are:"); // announce ascending array
            Console.WriteLine(string.Join(" ", array1)); // convert sorted array into string and display
            Console.ForegroundColor = ConsoleColor.Red; // set font to red
            Console.WriteLine($"The {size} values stored into the array in descending order are:"); // announce descending array
            Console.WriteLine(string.Join(" ", array1.Reverse())); // reverse and then convert sorted array into string and display
            Console.ReadLine(); // pause to allow user to view output
        }
    }
}