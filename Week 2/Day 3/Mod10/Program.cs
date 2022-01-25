using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            i = 10;
            j = 20;
            Swap(ref i, ref j);
            Console.WriteLine($"i:{i},j:{j}");
            

            StructTest s1 = new StructTest();
            StructTest s2;
            s2 = s1; 
            s1.i = 100;
            Console.WriteLine($"struct1 value: {s1.i}, struct2 value: {s2.i}");
            
            ClassTest c1 = new ClassTest();
            ClassTest c2;
            c2 = c1;
            c1.i = 100;
            Console.WriteLine($"class1 value: {c1.i}, class2 value: {c2.i}");

            TestClass(c2);
            TestStruct(s2);

            Console.ReadLine();
        }

        static void TestClass(ClassTest c)
        {

        }
        static void TestStruct(StructTest t)
        {

        }
        static void Swap(ref int num1, ref int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}