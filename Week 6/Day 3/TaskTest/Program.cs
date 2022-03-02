using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating task using Action delegate
            Task task1 = new Task(new Action(Method1));

            // anonymous method
            Task task2 = new Task(delegate 
            {
                Console.WriteLine("Start2");
                Thread.Sleep(3000);
                Console.WriteLine("Stop2");
            });

            Task task3 = new Task(() =>
            {
                Console.WriteLine("Start3");
                Thread.Sleep(3000);
                Console.WriteLine("Stop3");
            });

            Task<decimal> task4 = Task.Run<decimal>(() =>
            {
                // long-running complex calculation
                Thread.Sleep(3000);
                return 5.6m;
            });
            Console.WriteLine(task4.Result);

            // parallel method invocation
            Parallel.Invoke(() => Method1(),
                () => Method1()
                );

            int start = 0;
            int end = 1000;
            int[] arr = new int[end+1];

            // sequential for loop
            for(int i=start; i<end; i++)
                arr[i] = i*i;

            // parallel for loop
            Parallel.For(start, end, index =>
            {
                arr[index] = index * index;
            });

            var studlist = new List<Student>();
            studlist.Add(new Student { Id = 11, Name = "ABC"});
            studlist.Add(new Student { Id = 12, Name = "BCD" });
            studlist.Add(new Student { Id = 13, Name = "CDE" });

            // Sequential LINQ
            var students = from stud in studlist
                           where stud.Name.StartsWith("A")
                           select stud;

            // Parallel LINQ (pLINQ)
            var studentsnew = from stud in studlist.AsParallel()
                              where stud.Name.StartsWith("A")
                              select stud;

            task1.Start();
            task2.Start();
            task3.Start();

            Console.ReadLine();
        }
        static void Method1()
        {
            Console.WriteLine("Start1");
            Thread.Sleep(3000);
            Console.WriteLine("Stop1");
        }
    }
}
