using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] parameters = new object[] { 20, 30 };
            string assemblyPath = @"C:\Users\sk8bo\source\repos\MSSA\Week 7\Day 1\MathDll\bin\Debug\MathDll.dll";
            var assembly = Assembly.LoadFrom(assemblyPath); // late binding
            Console.WriteLine(assembly.FullName);
            var types = assembly.GetTypes(); // read all types from assembly

            foreach (Type t in types)
            {
                Console.WriteLine(t.FullName);
                var methods = t.GetMethods();
                foreach (MethodInfo mi in methods)
                {
                    if (mi.Name == "Equals")
                    {
                        break;
                    }
                    Console.WriteLine(mi.Name);
                    var dynamic_obj = Activator.CreateInstance(t);
                    var result = t.InvokeMember(mi.Name,BindingFlags.InvokeMethod,null,dynamic_obj,parameters);
                    Console.WriteLine(result);
                }
            }

            Console.ReadLine();
        }
    }
}
