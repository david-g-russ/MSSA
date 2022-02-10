using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QuizTest
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            String s1 = "ALL MEN ARE CREATED EQUAL";
            String s2;
            s2 = s1.Substring(12, 3);
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }
}
