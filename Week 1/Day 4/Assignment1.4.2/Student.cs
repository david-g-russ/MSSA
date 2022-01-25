using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a class: “Student” with private data members: StudentId ( int), StudentFname (stirng), StudentLname (string ), StudentGrade ( char ) and public properties for each data member. 
 * Instantiate the class and assign data to properties. Call get and set properties. */

namespace Assignment1._4._2
{
    internal class Student
    {
        #region Constructors

        public Student(string studentFName, string studentLName) // constructor that accepts a first and last name for a student
        {
            this.StudentFName = studentFName; // assign student first name
            this.StudentLName = studentLName; // assign student last name
            this.StudentId = GenerateStudentID(); // call RNG to create 9 digit student ID

            StudentGrade = 'A'; // assign student grade as an 'A' to begin with
        } 
        #endregion

        #region Properties
        // set public facing properties
        public int StudentId { get; } // read-only to prevent changing after construction
        public string StudentFName { get; set; } // read/write property
        public string StudentLName { get; set; } // read/write property
        public char StudentGrade { get; private set; } // private set to allow addGrade function to set this property but prevent direct changing outside of the class
        #endregion

        #region Methods

        static Random rnd = new Random(); //initialize RNG

        static int GenerateStudentID() // use RNG to generate unique student ID
        {
            return rnd.Next(100000000, 999999999);
        }

        public override string ToString() // override the default ToString to allow useful interpretation of the Student class
        {
            return $"Student ID: {StudentId}, Name: {StudentFName} {StudentLName}, Grade: {StudentGrade}";
        }

        ArrayList GradeMatrix = new ArrayList(); // initialize the grading matrix

        public void addGrade(int grade) // function to allow input of grades for a student
        {
            GradeMatrix.Add(grade); // add the input to the grade matrix array list
            int gradeTotal = 0; // initialize the grade total in order to allow averaging
            foreach (int num in GradeMatrix) // run over each int in the array list to get sum
            {
                gradeTotal += num; // update grade total with each new grade
            }
            int gradeAvg = gradeTotal / GradeMatrix.Count; // average the grade total by the total number of grades
            switch (gradeAvg) // begin switch case to assign grade
            {
                case int n when n < 60: // assign F if below 60%
                    StudentGrade = 'F';
                    break;
                case int n when n < 70: // assign D if below 70%
                    StudentGrade = 'D';
                    break;
                case int n when n < 80: // assign C if below 80%
                    StudentGrade = 'C';
                    break;
                case int n when n < 90: // assign B if below 90%
                    StudentGrade = 'B';
                    break;
                case int n when n >= 90: // assign A if greater than or equal to 90% (to allow for extra credit)
                    StudentGrade = 'A';
                    break;
                default:
                    break;
            }
        }        
        #endregion
    }
}