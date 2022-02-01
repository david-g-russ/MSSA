using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 1. Create a 2D array to store integers and print them in matrix format with proper formatting.

e. g:

| 2 | 3 | 4 |

| 1 | 4 | 6 |

2. Write a program in C# Sharp for addition of two Matrices of same size.

Test Data :
Input the size of the square matrix (less than 5): 2
Input elements in the first matrix :
element - [0],[0] : 1
element - [0],[1] : 2
element - [1],[0] : 3
element - [1],[1] : 4
Input elements in the second matrix :
element - [0],[0] : 5
element - [0],[1] : 6
element - [1],[0] : 7
element - [1],[1] : 8
Expected Output:
The First matrix is:

1 2
3 4
The Second matrix is :

5 6
7 8
The Addition of two matrix is :

6 8
10 12

3. Create a console application to create following overloaded methods:

Int Add(int a, int b) , int Add(int a,int b, int c)

float Multiply(float a, float b), float Multiply(float a , float b, float c)

Call the above methods by providing a menu to user.

4. Create a console application to overload “+” and “-“ operator for adding the areas of 2 circles and getting their area difference respectively.
*/

namespace Assignment4._2
{
    internal class Program
    {

        #region Program Menu
        static bool CallMenu() //creates the Menu for the functions
        {
            int choice; // initialize user choice variable

            Console.WriteLine("Please select a menu option: \n"); // read out options to user
            Console.WriteLine(" 1. Create and view a 2D array \n" +
                              " 2. Add two square matrices of same size \n" +
                              " 3. Multiply two square matrices of same size \n" +
                              " 4. Add numbers \n" +
                              " 5. Multiply numbers \n" +
                              " 6. Add or subtract the areas of 2 circles \n" +
                              " 7. Exit");

            while (int.TryParse(Console.ReadLine(), out choice) == false) // check whether user enters a valid input that can be parsed as an int
            {
                InputErrorMsg(); // send invalid input message if user inputs a non-integer
            }
            switch (choice)
            {
                case 1:
                    Option1(); // call 2D array function
                    return false; // send user back to menu
                case 2:
                    Option2(); // call matrix addition function
                    return false; // send user back to menu
                case 3:
                    Option3(); // call matrix multiplication function
                    return false; // send user back to menu
                case 4:
                    Option4(); // call addition function
                    return false; // send user back to menu
                case 5:
                    Option5(); // call multiplication function
                    return false;
                case 6:
                    Option6(); // call circle area addition/subtraction function
                    return false;
                case 7:
                    return true; // allow user to exit the while loop in Main
                default:
                    InputErrorMsg(); // display input error if user selects an invalid option (not 1-7)
                    return false; // send user back to menu
            }
        }
        #endregion

        #region Menu Functions
        static void Option1() // Create and view 2D array
        {
            int rows, cols;
            Console.WriteLine("Please enter desired number of rows:"); // request number of rows
            while (Int32.TryParse(Console.ReadLine(), out rows) == false) // take user input for number of rows
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to int32
            }
            Console.WriteLine("Please enter desired number of columns:"); // request number of columns
            while (Int32.TryParse(Console.ReadLine(), out cols) == false) // take user input for number of columns
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to int32
            }
            Arr2D arr = new Arr2D(rows, cols); // instantiate object
            string matrix = arr.GetMatrix();
            Console.ForegroundColor = ConsoleColor.Green; // set font to green
            Console.WriteLine($"{matrix}"); // display 2D array in matrix form
            Console.ForegroundColor = ConsoleColor.White; // reset font to white
        }

        static void Option2() // Add two matrices of same size (<5)
        {
            int size;
            Console.WriteLine("Please enter the desired size of the square matrix (less than 5):"); // request size
            while (true)
            {
                while (Int32.TryParse(Console.ReadLine(), out size) == false) // take user input for size
                {
                    InputErrorMsg(); // display error message if user input cannot be parsed to int32
                }
                if (size < 5 && size > 0) break; // check if size is in allowable limits, if so, break while loop
                else InputErrorMsg(); // if not within limits, inform use and continue while loop
            }
            Console.WriteLine("Beginning construction of the first matrix:");
            Arr2D arr1 = new Arr2D(size,size);
            string matrix1 = arr1.GetMatrix(out int[,] arrResult1);
            Console.WriteLine("Beginning construction of the second matrix:");
            Arr2D arr2 = new Arr2D(size, size);
            string matrix2 = arr2.GetMatrix(out int[,] arrResult2);
            int[,] sum = arr1.ArraySum(arrResult1, arrResult2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your first matrix is \n{matrix1}");
            Console.WriteLine($"Your second matrix is \n{matrix2}");
            Console.WriteLine($"The sum of your two matrices is \n{arr1.GetMatrix(sum)}");
            Console.ForegroundColor = ConsoleColor.White; // reset font to white
        }

        static void Option3() // Multiply two matrices of same size (<5)
        {
            int size;
            Console.WriteLine("Please enter the desired size of the square matrix (less than 5):"); // request size
            while (true)
            {
                while (Int32.TryParse(Console.ReadLine(), out size) == false) // take user input for year
                {
                    InputErrorMsg(); // display error message if user input cannot be parsed to int32
                }
                if (size < 5 && size > 0) break; // check if size is in allowable limits, if so, break while loop
                else InputErrorMsg(); // if not within limits, inform use and continue while loop
            }
            Console.WriteLine("Beginning construction of the first matrix:");
            Arr2D arr1 = new Arr2D(size, size);
            string matrix1 = arr1.GetMatrix(out int[,] arrResult1);
            Console.WriteLine("Beginning construction of the second matrix:");
            Arr2D arr2 = new Arr2D(size, size);
            string matrix2 = arr2.GetMatrix(out int[,] arrResult2);
            int[,] sum = arr1.ArrayProduct(arrResult1, arrResult2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your first matrix is \n{matrix1}");
            Console.WriteLine($"Your second matrix is \n{matrix2}");
            Console.WriteLine($"The product of your two matrices is \n{arr1.GetMatrix(sum)}");
            Console.ForegroundColor = ConsoleColor.White; // reset font to white
        }

        static void Option4() // Add 2-3 numbers
        {
            int amt, num;
            Console.WriteLine("Would you like to add 2 or 3 numbers?:"); // request amount of numbers to add
            while (true)
            {
                while (Int32.TryParse(Console.ReadLine(), out amt) == false) // take user input for amount
                {
                    InputErrorMsg(); // display error message if user input cannot be parsed to int32
                }
                if (amt == 2 || amt == 3) break; // check if amount is in allowable limits, if so, break while loop
                else InputErrorMsg(); // if not within limits, inform use and continue while loop
            }
            int[] arr = new int[amt];
            Console.WriteLine($"Please enter {amt} values:");
            for (int i = 0; i < amt; i++)
            {
                while (!Int32.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Please enter a valid number:");
                }
                arr[i] = num;
            }
            MathCls obj = new MathCls(arr);
            Console.ForegroundColor = ConsoleColor.Green; // set font to green
            if (amt == 2)
                Console.WriteLine($"The sum of your {amt} numbers is {obj.Add(arr[0],arr[1])}"); // display result of addition
            else
                Console.WriteLine($"The sum of your {amt} numbers is {obj.Add(arr[0],arr[1],arr[2])}");
            Console.ForegroundColor = ConsoleColor.White; // reset font to white
        }

        static void Option5() // Multiply 2-3 numbers
        {
            int amt;
            float num;
            Console.WriteLine("Would you like to multiply 2 or 3 numbers?:"); // request amount of numbers to add
            while (true)
            {
                while (Int32.TryParse(Console.ReadLine(), out amt) == false) // take user input for amount
                {
                    InputErrorMsg(); // display error message if user input cannot be parsed to int32
                }
                if (amt == 2 || amt == 3) break; // check if amount is in allowable limits, if so, break while loop
                else InputErrorMsg(); // if not within limits, inform use and continue while loop
            }
            float[] arr = new float[amt];
            Console.WriteLine($"Please enter {amt} values:");
            for (int i = 0; i < amt; i++)
            {
                while (!Single.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Please enter a valid number:");
                }
                arr[i] = num;
            }
            MathCls obj = new MathCls(arr);
            Console.ForegroundColor = ConsoleColor.Green; // set font to green
            if (amt == 2)
                Console.WriteLine($"The product of your {amt} numbers is {obj.Multiply(arr[0], arr[1])}"); // display result of addition
            else
                Console.WriteLine($"The product of your {amt} numbers is {obj.Multiply(arr[0], arr[1], arr[2])}");
            Console.ForegroundColor = ConsoleColor.White; // reset font to white
        }

        static void Option6() // Add or subtract the area of 2 circles
        {
            double r1, r2; // initialize radius 1 and 2
            int choice;
            Console.WriteLine("Please enter the radius of the first circle:"); // request radius
            while (Double.TryParse(Console.ReadLine(), out r1) == false) // take user input for radius
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to double
            }
            Console.WriteLine("Please enter the radius of the second circle:"); // request radius
            while (Double.TryParse(Console.ReadLine(), out r2) == false) // take user input for radius
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to double
            }
            Console.WriteLine("Would you like to:\n\n 1. Add \n 2. Subtract \n\nthe areas?"); // request operation
            Circle c1 = new Circle(r1); // initialize first circle
            Circle c2 = new Circle(r2); // initialize second circle
            while (Int32.TryParse(Console.ReadLine(), out choice) == false)
            {
                InputErrorMsg();
            }
            switch (choice)
            {
                case 1:
                    Circle c3 = c1 + c2; // use overloaded operator to add circle areas
                    Console.ForegroundColor = ConsoleColor.Green; // set font to green
                    Console.WriteLine($"The sum of the areas is {c3.Area}"); // display calculated area
                    Console.ForegroundColor = ConsoleColor.White; // reset font to white
                    break;
                case 2:
                    Circle c4 = c1 - c2; // use overloaded operator to subtract circle areas
                    Console.ForegroundColor= ConsoleColor.Green; // set font to green
                    Console.WriteLine($"The difference of the areas is {c4.Area}"); // display calculated area
                    Console.ForegroundColor = ConsoleColor.White; // reset font to white
                    break;
                default:
                    InputErrorMsg(); // display input error message
                    break;
            }
        }

        static void InputErrorMsg() // make code easier to read by compacting function to display an invalid input
        {
            Console.ForegroundColor = ConsoleColor.Red; // set font to red
            Console.WriteLine("Invalid input, try again:"); // lets user know they entered an invalid input
            Console.ForegroundColor = ConsoleColor.White; // reset font to white
        }

        #endregion
        static void Main()
        {
            while (CallMenu() == false)
            {
                // :)
            }
            Console.ReadLine();

        }
    }
}
