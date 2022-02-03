using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace StructEnumTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList todolist = new ArrayList()
            {
                new ToDo { TaskID = 1, Description ="do assignment", EstimatedHours = 1, Status = Status.NotStarted},
                new ToDo{ TaskID = 2, Description ="study", EstimatedHours = 2, Status=Status.InProgress},
                new ToDo{ TaskID = 3, Description ="eat food", EstimatedHours = 6, Status=Status.OnHold},
                new ToDo{ TaskID = 4, Description ="keep swimming", EstimatedHours = 3, Status = Status.Deleted},
                new ToDo{ TaskID = 5, Description ="find Nemo", EstimatedHours = 12, Status = Status.Completed}
            };
            todolist.Add(new ToDo { TaskID=1, Description ="eat more burritos", EstimatedHours=1, Status=Status.Completed});
            PrintToDo(todolist);
        }

        static void PrintToDo(ArrayList todos)
        {
            foreach (var todo in todos)
            {
                ToDo task = (ToDo)todo;

                switch (task.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                }

                Console.WriteLine(task.Description);
                
            }
            Console.ReadLine();
        }
    }
}
