using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 100,2,3,49,8123};
            intList.Sort();
            foreach (int i in intList)
            {
                Console.WriteLine(i);
            }


            List<Student> studentList = new List<Student>();
            studentList.Add(new Student() { Name = "Kelly", Grades = 80, Address = "123"});
            studentList.Add(new Student() { Name = "Andrew", Grades = 60, Address = "123" });
            studentList.Add(new Student() { Name = "Will", Grades = 85, Address = "123" });
            studentList.Add(new Student() { Name = "Chris", Grades = 90, Address = "123" });

            studentList.Sort();
            foreach (var s in studentList)
            {
                Console.WriteLine($"{s.Name}, {s.Address}, {s.Grades}");
            }

            Console.ReadLine();
        }
    }
}
