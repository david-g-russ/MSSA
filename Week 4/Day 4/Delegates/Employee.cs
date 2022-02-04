using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate bool IsPromotable(Employee e);

    public class Employee
    {
        public int EId { get; set; }
        public string FName { get; set; }
        public int YearsExp { get; set; }
        public char Grade { get; set; }
        public void PromoteEmployee(List<Employee> elist, IsPromotable isprom)
        {
            foreach (var emp in elist)
            {
                if (isprom(emp))
                {
                    Console.WriteLine(emp.FName + " is promoted");
                }
            }
        }
    }
}
