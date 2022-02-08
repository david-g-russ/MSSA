using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest
{
    interface I1
    {

    }

    internal class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Grades { get; set; }

        public int CompareTo(Student other)
        {
            return String.Compare(this.Name, other.Name);
        }
    }

    class StudentComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return (y.Grades.CompareTo(x.Grades));
        }
    }
}
