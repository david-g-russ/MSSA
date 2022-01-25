using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra1
{
    internal class Student
    {
        // public properties
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int ComputerApplication { get; set; }

        // public functions
        public int TotalMarks() // returns sum of the 3 int grades
        {
            return Physics + Chemistry + ComputerApplication;
        }
        public double Percentage() // returns the average of the 3 int grades and converts to double type
        {
            return Convert.ToDouble(TotalMarks()) / 3;
        }
        public string Division() // returns the division
        {
            double percentage = Percentage(); // calculate percentage from marks
            switch(percentage) // return appropriate division as a string
            {
                case double n when n >= 75.0:
                    return "Distinctive";
                case double n when n >= 60.0:
                    return "First class";
                case double n when n >= 45.0:
                    return "Second Class";
                case double n when n >= 35.0:
                    return "Passing Grade";
                default:
                    return "Fail";

            }    
        }
        // constructor that takes 4 int and 1 string
        public Student(int rollNo, string name, int physics, int chemistry, int computerApplication)
        {
            this.RollNo = rollNo;
            this.Name = name;
            this.Physics = physics;
            this.Chemistry = chemistry;
            this.ComputerApplication = computerApplication;
        }
    }
}