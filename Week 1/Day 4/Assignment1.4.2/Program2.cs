using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a class: “Student” with private data members: StudentId ( int), StudentFname (stirng), StudentLname (string ), StudentGrade ( char ) and public properties for each data member. 
 * Instantiate the class and assign data to properties.call get and set properties. */

namespace Assignment1._4._2
{
    internal class Program2
    {
        static Dictionary<string, Student> students = new Dictionary<string, Student>(); // initialize dictionary to store student objects

        #region Student Menu
        
        static bool CallMenu() //creates the Call Menu for the functions
        {
            int choice; // initialize user choice variable

            Console.WriteLine("Please select a menu option:"); // read out options to user
            Console.WriteLine(" 1. Create new student \n 2. View existing student \n 3. Enter student grade \n 4. Change student name \n 5. Exit ");

            while (int.TryParse(Console.ReadLine(), out choice) == false) // check whether user enters a valid input that can be parsed as an int
            {
                Console.ForegroundColor = ConsoleColor.Red; // set font to red
                Console.WriteLine("Invalid input, try again:"); // lets user know they entered an invalid input
                Console.ForegroundColor = ConsoleColor.White; // reset font to white
            }
            switch (choice) 
            {
                case 1:
                    {
                        Option1(); // call create new student function
                        return false; // send user back to call menu
                    }
                case 2:
                    {
                        Option2(); // call view existing student function
                        return false; // send user back to call menu
                    }
                case 3:
                    {
                        Option3(); // call enter student grade function
                        return false; // send user back to call menu
                    }
                case 4:
                    {
                        Option4(); // call change student name function
                        return false; // send user back to call menu
                    }
                case 5:
                    {
                        return true; // allow user to exit while loop in Main
                    }
                default:
                    {
                        Console.ForegroundColor = ConsoleColor.Red; // set font to red
                        Console.WriteLine("That is not a valid option. \nTry again."); // let user know they entered an invalid number
                        return false; // send user back to call menu
                    }
            }
        }
        #endregion

        #region Menu Options
        static void Option1() // Create new student function
        {
            Console.WriteLine("Please enter the first name of the new student:"); // request first name
            string fName = Console.ReadLine().ToUpper(); // take user input for first name and capitalize
            Console.WriteLine("Please enter the last name of the new student:"); // request last name
            string lName = Console.ReadLine().ToUpper(); // take user input for last name and capitalize
            string fullName = fName + lName; // combine first and last to create dictionary key
            students.Add(fullName, new Student(fName, lName)); // add new student object to dictionary using fullName as key
        }

        static void Option2() // View existing student function
        {
            Console.WriteLine("Please enter the first name of the student you want to view:"); // request first name
            string fName = Console.ReadLine().ToUpper(); // take user input for first name and capitalize
            Console.WriteLine("Please enter the last name:"); // request last name
            string lName = Console.ReadLine().ToUpper(); // take user input for last name and capitalize
            string fullName = fName + lName; // combine first and last to find dictionary key
            Console.WriteLine(students[fullName].ToString()); // use overridden ToString method to view relevant data in dictionary
        }

        static void Option3() // Add grade function
        {
            Console.WriteLine("Please enter the first name of the student you want to add a grade for:"); // request first name
            string fName = Console.ReadLine().ToUpper(); // take user input for first name and capitalize
            Console.WriteLine("Please enter the last name:"); // request last name
            string lName = Console.ReadLine().ToUpper(); // take user input for last name and capitalize
            string fullName = fName + lName; // combine first and last to find dictionary key
            Console.WriteLine("Please enter the grade you would like to add, in percent form:"); // request grade to add
            students[fullName].addGrade(Int32.Parse(Console.ReadLine())); // convert user input to Int32 and pass to addGrade method
            Console.WriteLine($"{students[fullName].StudentFName}'s grade is now {students[fullName].StudentGrade}"); // announce new grade
        }

        static void Option4() // Change name function
        {
            Console.WriteLine("Please enter the first name of the student you want to change:"); // request first name
            string fName = Console.ReadLine().ToUpper(); // take user input and capitalize 
            Console.WriteLine("Please enter the last name:"); // request last name
            string lName = Console.ReadLine().ToUpper(); // take user input and capitalize
            string fullName = fName + lName; // combine for dictionary key
            Console.WriteLine("Please enter whether you would like to change the first or the last name:"); // request which name they would like to change
            if (Console.ReadLine().ToLower() == "first") // if they type first
            {
                Console.WriteLine("Please enter what you would like to change their first name to:"); // request what they would like to change to
                fName = Console.ReadLine().ToUpper(); // take user input and capitalize
                students[fullName].StudentFName = fName; // set new first name
                students.Add((fName + students[fullName].StudentLName), new Student(fName, students[fullName].StudentLName)); // create new dictionary entry using new first name in key
                students.Remove(fullName); // remove old dictionary entry with old key
            }
            else if (Console.ReadLine().ToLower() == "last") // if they type last
            {
                Console.WriteLine("Please enter what you would like to change the last name to:"); // request what they would like to change to
                lName = Console.ReadLine().ToUpper(); // take user input and capitalize
                students[fullName].StudentLName = lName; // set new last name
                students.Add((students[fullName].StudentFName + lName), new Student(students[fullName].StudentFName, lName)); // create new dictionary entry using new last name in key
                students.Remove(fullName); // remove old dictionary entry with old key
            }
            else
                Console.WriteLine("Invalid input."); // report invalid input for anything but "first" or "last" and send back to call menu
        } 
        #endregion
        static void Main(string[] args)
        {
            while (CallMenu() == false) // maintain call menu until user enters exit (returns true bool)
            {
                //      :)
            }
            Console.ReadLine(); // pause to allow user to view console output
        }

    }
}