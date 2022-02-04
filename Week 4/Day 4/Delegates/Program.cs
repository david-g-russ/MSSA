using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {

        public delegate void PostMsgDelegate(string msg); // delegate, type-safe function pointer

        static void Message(string s)
        {
            Console.WriteLine($"Hello {s}");
        }

        static bool IsPromotableEmpByGradeXP(Employee emp)
        {
            if ((emp.Grade == 'A' || emp.Grade == 'B') && emp.YearsExp >= 5)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            //PostMsgDelegate p = new PostMsgDelegate(Message);
            //p("all"); // delegate call

            //Queue<decimal> q = new Queue<decimal>();
            //q.Enqueue(7m);

            IsPromotable del = new IsPromotable(IsPromotableEmpByGradeXP);

            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { EId = 1, FName = "John", Grade = 'A', YearsExp = 5});
            emplist.Add(new Employee() { EId = 2, FName = "Max", YearsExp=1, Grade = 'B'});
            emplist.Add(new Employee() { EId = 3, FName = "Ethan", Grade = 'C', YearsExp = 6 });

            //List<int> intlist = new List<int>();
            //intlist.Add(1);

            foreach (var emp in emplist)
            {
                Console.WriteLine($"Name: {emp.FName}, ID: {emp.EId}");
            }

            Employee e = new Employee();
            e.PromoteEmployee(emplist, del);



            Console.ReadLine();
        }
    }
}