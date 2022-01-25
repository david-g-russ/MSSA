using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra1
{
    internal struct ArrayMinMax
    {
        public int[] Arr { get; set; } // public property
        public int Min() // Min function
        {
            int min = Arr[0]; // set min to first element value
            foreach (int i in Arr) // go through each element of array
            {
                if (i < min) // if element is less than the previous min, set to min
                    min = i;
            }
            return min; // return final min value
        }
        public int Max() // Max function
        {
            int max = Arr[0]; // set max to first element value
            foreach (int i in Arr) // go through each element of array
            {
                if (i > max) // if element is greater than previous max, set to max
                    max = i;
            }
            return max; // return final max value
        }
        public ArrayMinMax(int[] arr) // constructor when given an array
        {
            this.Arr = arr;
        }
        public ArrayMinMax(int arraySize) // constructor when given an array size
        {
            Arr = new int[arraySize]; // instantiate array of size arraysize
            for (int i = 0; i < arraySize; i++) // loop for number of elements requested
            {
                Console.WriteLine($"Please enter element {i}:"); // request input
                while (Int32.TryParse(Console.ReadLine(), out Arr[i]) == false) // take user input for number and assign to appropriate element of array
                {
                    Console.ForegroundColor = ConsoleColor.Red; // set font to red
                    Console.WriteLine("Invalid input, try again:"); // lets user know they entered an invalid input
                    Console.ForegroundColor = ConsoleColor.White; // reset font to white
                }
            }
        }

    }
}
