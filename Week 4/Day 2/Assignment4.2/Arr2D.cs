using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._2
{
    internal class Arr2D
    {
        // public properties
        public int Rows { get; set; }
        public int Cols { get; set; }
        public int[,] Arr { get; set; }

        // public methods

        public string GetMatrix() // create and return array in string form with no params
        {
            int[,] arr = new int[Rows, Cols]; // initialize array to appropriate size
            StringBuilder sb = new StringBuilder(); // initialize stringbuilder
            sb.Append(("").PadRight(17+(Cols-1)*8, '-') + "\n"); // adds top of box for array
            for (int i = 0; i < Rows; i++) // for loop that begins iterating for length of requested rows
            {
                Console.WriteLine($"Please enter {Cols} numbers for Row {i}:"); // request number input
                sb.Append("|\t"); // add left side of box for each row
                for (int j = 0; j < Cols; j++) // for loop that iterates for length of requested columns
                {
                    while (!Int32.TryParse(Console.ReadLine(), out arr[i, j])) // verify that input is of int32 type
                    {
                        Console.WriteLine("Please enter a valid number:"); // give error message if input is not int32
                    }
                    sb.Append($"[{arr[i, j]}]\t"); // place input into appropriate index with formatting and a tab
                }
                sb.Append("|\n"); // add right side of box and go to new line
            }
            sb.Append(("").PadRight(17 + (Cols - 1) * 8, '-')); // add bottom of box for array
            return sb.ToString(); // build and return string
        }

        public string GetMatrix(out int[,] arrResult) // create and return a matrix in string form, as well as the int[,] array
        {
            int[,] arr = new int[Rows, Cols]; // initialize array to appropriate size
            StringBuilder sb = new StringBuilder(); // initialize stringbuilder
            sb.Append(("").PadRight(17 + (Cols - 1) * 8, '-') + "\n"); // adds top of box for array
            for (int i = 0; i < Rows; i++) // for loop that begins iterating for length of requested rows
            {
                Console.WriteLine($"Please enter {Cols} numbers for Row {i}:"); // request number input
                sb.Append("|\t"); // add left side of box for each row
                for (int j = 0; j < Cols; j++) // for loop that iterates for length of requested columns
                {
                    while (!Int32.TryParse(Console.ReadLine(), out arr[i, j])) // verify that input is of int32 type
                    {
                        Console.WriteLine("Please enter a valid number:"); // give error message if input is not int32
                    }
                    sb.Append($"[{arr[i, j]}]\t"); // place input into appropriate index with formatting and a tab
                }
                sb.Append("|\n"); // add right side of box and go to new line
            }
            arrResult = arr; // set out parameter to result
            sb.Append(("").PadRight(17 + (Cols - 1) * 8, '-')); // add bottom of box for array
            return sb.ToString(); // build and return string
        }

        public string GetMatrix(int[,] arr) // takes an input array and returns the array in string form
        {
            StringBuilder sb = new StringBuilder(); // initialize stringbuilder
            sb.Append(("").PadRight(17 + (Cols - 1) * 8, '-') + "\n"); // adds top of box for array

            for (int i = 0; i < arr.GetLength(0); i++) // for loop that begins iterating for length of input rows
            {
                sb.Append("|\t"); // add left side of box for each row
                for (int j = 0; j < arr.GetLength(1); j++) // for loop that iterates for length of input columns
                {
                    sb.Append($"[{arr[i, j]}]\t"); // place input into appropriate index with formatting and a tab
                }
                sb.Append("|\n"); // add right side of box and go to new line
            }
            sb.Append(("").PadRight(17 + (Cols - 1) * 8, '-')); // add bottom of box for array
            return sb.ToString(); // build and return string
        }

        public int[,] ArraySum(int[,] arr1, int[,] arr2) // adds two arrays given as parameters
        {
            int row = arr1.GetLength(0);
            int col = arr1.GetLength(1);
            int[,] sumArr = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sumArr[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            return sumArr;
        }

        public int[,] ArrayProduct(int[,] arr1, int[,] arr2) // multiplies two arrays given as parameters
        {
            int row = arr1.GetLength(0);
            int col = arr1.GetLength(1);
            int[,] prodArr = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    prodArr[i, j] = arr1[i, j] * arr2[i,j];
                }
            }
            return prodArr;
        }

        // constructor

        public Arr2D(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
        }

    }
}