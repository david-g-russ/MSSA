using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1. Write a function that takes an integer minutes and converts it to seconds. 

        convert(5) ➞ 300 

        convert(3) ➞ 180 

        convert(2) ➞ 120 

2. Write a function that takes the base and height of a triangle and return its area. 

        triArea(3, 2) ➞ 3 

        triArea(7, 4) ➞ 14 

        triArea(10, 10) ➞ 50 

3. Given two numbers, return true if the sum of both numbers is less than 100. Otherwise return false. 

        lessThan100(22, 15) ➞ true 

        // 22 + 15 = 37 

        lessThan100(83, 34) ➞ false 

        // 83 + 34 = 117 

        lessThan100(3, 77) ➞ true 

4. Create a function that returns true if a number is a palindrome. 

        IsPalindrome(838) ➞ true 

        IsPalindrome(4433) ➞ false 

        IsPalindrome(443344) ➞ true 

5. Given a string, create a function to reverse the case. All lower-cased letters should be upper-cased, and vice versa. 

        ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY" 

        ReverseCase("MANY THANKS") ➞ "many thanks" 

        ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS" 

6. Write a C# Sharp program to check whether a given number is even or odd.  
        Test Data : 15 
        Expected Output : 
        15 is an odd integer 

7. Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.   
        Test Data : 
        Input the Roll Number of the student :784 
        Input the Name of the Student :James 
        Input the marks of Physics, Chemistry and Computer Application : 70 80 90 
        Expected Output : 
        Roll No : 784 
        Name of Student : James 
        Marks in Physics : 70 
        Marks in Chemistry : 80 
        Marks in Computer Application : 90 
        Total Marks = 240 
        Percentage = 80.00 
        Division = First 

8. Write a program in C# Sharp to find maximum and minimum element in an array.   
        Test Data : 
        Input the number of elements to be stored in the array :3 
        Input 3 elements in the array : 
        element - 0 : 45 
        element - 1 : 25 
        element - 2 : 21 
        Expected Output : 
        Maximum element is : 45 
        Minimum element is : 21 
 */

namespace Extra1
{
    internal class Program
    {
        #region Program Menu
        static bool CallMenu() //creates the Call Menu for the functions
        {
            int choice; // initialize user choice variable

            Console.WriteLine("Please select a menu option: \n"); // read out options to user
            Console.WriteLine(" 1. Convert integer minutes to seconds \n" +
                              " 2. Calculate area of a triangle \n" +
                              " 3. Determine whether the sum of two numbers is less than 100 \n" +
                              " 4. Determine whether a number is a palindrome \n" +
                              " 5. Reverse the case of a string \n" +
                              " 6. Check whether a number is even or odd \n" +
                              " 7. Read roll number, name, and marks and calculate total, percentage, and division \n" +
                              " 8. Find maximum and minimum element in an array \n" +
                              " 9. Exit ");

            while (int.TryParse(Console.ReadLine(), out choice) == false) // check whether user enters a valid input that can be parsed as an int
            {
                InputErrorMsg(); // send invalid input message if user inputs a non-integer
            }
            switch (choice)
            {
                case 1:
                    Option1(); // call minutes to seconds function
                    return false; // send user back to menu
                case 2:
                    Option2(); // call triangle area function
                    return false; // send user back to menu
                case 3:
                    Option3(); // call sum less than 100 function
                    return false; // send user back to menu
                case 4:
                    Option4(); // call number palindrome function
                    return false; // send user back to menu
                case 5:
                    Option5(); // call string case reverse function
                    return false; // send user back to menu
                case 6:
                    Option6(); // call even or odd number function
                    return false; // send user back to menu
                case 7:
                    Option7(); // call grade function
                    return false; // send user back to menu
                case 8:
                    Option8(); // call max/min element function
                    return false; // send user back to menu
                case 9:
                    return true; // allow user to exit while loop in Main
                default:
                    InputErrorMsg();
                    return false; // send user back to menu
            }
        }
        #endregion

        #region Menu Functions
        static void Option1() // Convert minutes to seconds
        {
            int min;
            Console.WriteLine("Please enter how many minutes you would like to convert to seconds:"); // request minutes
            while (Int32.TryParse(Console.ReadLine(), out min) == false) // take user input for minutes
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to int32
            }
            Time time = new Time(min); // instantiate struct
            Console.WriteLine($"{min} minutes is {time.ConvertToSec()} seconds"); // display calculated seconds
        }

        static void Option2() // Triangle area function
        {
            int length, height;
            Console.WriteLine("Please enter the base length of the triangle:"); // request base length
            while (Int32.TryParse(Console.ReadLine(), out length) == false) // take user input for length
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to int32
            }
            Console.WriteLine("Please enter the height of the triangle:"); // request height
            while (Int32.TryParse(Console.ReadLine(), out height) == false) // take user input for height
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to int32
            }
            Triangle triangle = new Triangle(length, height); // instantiate triangle
            Console.WriteLine($"The area of this triangle is {triangle.CalculateArea()}"); // display calculated area
        }

        static void Option3() // Determine if two numbers are less than 100
        {
            int num1, num2;
            Console.WriteLine("Please enter the first number:"); // request first number
            while (Int32.TryParse(Console.ReadLine(), out num1) == false) // take user input for first number
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to int32
            }
            Console.WriteLine("Please enter the second number:"); // request second number
            while (Int32.TryParse(Console.ReadLine(), out num2) == false) // take user input for second number
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to int32
            }
            Sum100 sum100 = new Sum100(num1,num2); // instantiate
            Console.WriteLine($"It is {sum100.Sum()} that those two numbers are less than 100"); // display result
        }
        static void Option4() // Number palindrome function
        {
            int num1;
            Console.WriteLine("Please enter the number:"); // request number
            while (Int32.TryParse(Console.ReadLine(), out num1) == false) // take user input for number
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to int32
            }
            Palindrome palindrome = new Palindrome(num1); // instantiate
            Console.WriteLine($"It is {palindrome.Palin()} that this is a palindrome"); // display results
        }
        static void Option5() // String reverse case function
        {
            Console.WriteLine("Please enter the string you would like to reverse case for:"); // request input
            string s1 = Console.ReadLine(); // take input and place into string
            StringCase stringCase = new StringCase(s1); // instantiate
            Console.WriteLine($"Your string reversed in case is: {stringCase.ReverseCase()}"); // display result
        }
        static void Option6() // Odd/even function
        {
            int num1;
            Console.WriteLine("Please enter the number:"); // request number
            while (Int32.TryParse(Console.ReadLine(), out num1) == false) // take user input for number
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to int32
            }
            OddEven oddEven = new OddEven(num1); // instantiate
            Console.WriteLine($"This is an {oddEven.CheckEven()} number"); // display result
        }
        static void Option7() // student function
        {
            int rollNo, physics, chemistry, computerApplication; string name;
            Console.WriteLine("Please enter the Roll Number:"); // request roll number
            while (Int32.TryParse(Console.ReadLine(), out rollNo) == false) // take user input for number
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to int32
            }
            Console.WriteLine("Please enter the student name:"); // request student name
            name = Console.ReadLine(); // take input for student name
            Console.WriteLine("Please enter the grade in Physics:"); // request grade
            while (Int32.TryParse(Console.ReadLine(), out physics) == false) // take user input for grade
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to int32
            }
            Console.WriteLine("Please enter the grade in Chemistry::"); // request grade
            while (Int32.TryParse(Console.ReadLine(), out chemistry) == false) // take user input for grade
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to int32
            }
            Console.WriteLine("Please enter the grade in Computer Application:"); // request grade
            while (Int32.TryParse(Console.ReadLine(), out computerApplication) == false) // take user input for grade
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to int32
            }
            Student student = new Student(rollNo,name,physics, chemistry, computerApplication); // instantiate
            Console.ForegroundColor = ConsoleColor.Green; // set font to green
            Console.WriteLine($"Roll Number: {student.RollNo} \n" + // display results
                              $"Name of Student: {student.Name} \n" +
                              $"Marks in Physics: {student.Physics} \n" +
                              $"Marks in Chemistry: {student.Chemistry} \n" +
                              $"Marks in Computer Application: {student.ComputerApplication} \n" +
                              $"Total Marks: {student.TotalMarks()} \n" +
                              $"Percentage: {student.Percentage()} \n" +
                              $"Division: {student.Division()}");
            Console.ForegroundColor = ConsoleColor.White; // reset font to white
        }
        static void Option8() // array min/max function
        {
            int arraySize;
            Console.WriteLine("Please enter the number of elements to be stored in the array"); // request input
            while (Int32.TryParse(Console.ReadLine(), out arraySize) == false) // take user input for number
            {
                InputErrorMsg(); // display error message if user input cannot be parsed to int32
            }
            ArrayMinMax arr = new ArrayMinMax(arraySize); // instantiate
            Console.WriteLine($"The minimum number in that array is: {arr.Min()}"); // display min result
            Console.WriteLine($"The maximum number in that array is: {arr.Max()}"); // display max result
        }
        static void InputErrorMsg() // make code easier to read by compacting function to display an invalid input
        {
            Console.ForegroundColor = ConsoleColor.Red; // set font to red
            Console.WriteLine("Invalid input, try again:"); // lets user know they entered an invalid input
            Console.ForegroundColor = ConsoleColor.White; // reset font to white
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
