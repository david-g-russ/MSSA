using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program in C# to read n number of values in an array and display it in reverse order.
//Test Data :
//Input the number of elements to store in the array :3
//Input 3 number of elements in the array :
//element - 0 : 2
//element - 1 : 5
//element - 2 : 7
//Expected Output:
//The values store into the array are:
//2 5 7
//The values store into the array in reverse are :
//7 5 2

namespace Assignment1._3._2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of elements to store in the array:"); // request that user inputs number of elements for an array
            int size = Int32.Parse(Console.ReadLine()); // convert number to Int32 and store in size variable
            int[] array1 = new int[size]; // initialize array using requested size variable
            Console.WriteLine($"Input {size} numbers to store in the array:"); // request that user inputs the numbers for the array

            for (int i = 0; i < array1.Length; i++) // begin for loop, repeating for the requested number of elements in array
            {
                Console.WriteLine($"Index {i}:"); // request that user inputs number for the current index
                array1[i] = Int32.Parse(Console.ReadLine()); // convert input to Int32 and place in appropriate index
            }

            Console.WriteLine($"The {size} values stored into the array are:"); // announce stored array
            Console.WriteLine(string.Join(" ", array1)); // convert array to string
            Console.WriteLine($"The {size} values stored into the array in reverse are:"); // announce reversed array
            Console.WriteLine(string.Join(" ", array1.Reverse())); // reverse and convert array to string
            Console.ReadLine(); // pause to allow user to view output

        }
    }
}
