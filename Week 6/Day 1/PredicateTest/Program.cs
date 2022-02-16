using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Predicate: represents the method that defines a set of criteria and determines whether the specified element meets the criteria and returns it

namespace PredicateTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(12);
            list.Add(13);
            list.Add(14);
            list.Add(0);

            int result = list.Find(n => n == 0);
            if (result == 0)
                Console.WriteLine("Number '0' not found");
            else
                Console.WriteLine($"Found number {result}");

            var list5 = list.FindAll(n =>
            {
                if (n >= 5)
                    return true;
                else
                    return false;
            });
            foreach(int i in list5)
                Console.WriteLine(i);

            List<Employee> eList = new List<Employee>();
            eList.Add(new Employee() { Age = 20, Id = 10, Name = "Bob"});
            eList.Add(new Employee() { Age = 25, Id = 11, Name = "Sam" });
            eList.Add(new Employee() { Age = 30, Id = 12, Name = "Alex" });
            eList.Add(new Employee() { Age = 22, Id = 13, Name = "Joe" });

            var liste25 = eList.FindAll(emp =>
            {
                if (emp.Age >= 25)
                    return true;
                else
                    return false;
            });

            foreach(var e in liste25)
                Console.WriteLine($"{e.Name} is {e.Age} years old.");



            Console.Read();
        }
    }
}