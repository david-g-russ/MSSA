using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create employee class and use type safe collections like stack, dictionary etc. to store employee records and to use basic methods like add, delete on these collections.

// Create an interface for ICalculator for methods like add, subtract, divide, multiply and implement them in a class.etc.

namespace Assignment5._1
{
    enum Department
    {
        Administration,
        Intelligence,
        Operations,
        Logistics,
        TrooperResources,
        Communications,
        Fiscal,
        Sith
    }

    internal class Employee
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public Department Department { get; set; }
        public DateTime Dob { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }

        static Random rnd = new Random();

        public void GenerateID()
        {
            this.ID = rnd.Next(100000,999999);
        }

    }
}