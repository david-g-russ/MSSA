using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Write a console application to create a text file and save your basic details like 
 * name, age, address ( use dummy data). 
 * Read the details from same file and print on console. */

namespace Assignment2._2._1
{
    internal class Program
    {
        static string filename;
        static string path = @"C:\Users\sk8bo\source\repos\MSSA\Week 2\Day 2\";
        static void Main(string[] args)
        {
            Console.WriteLine("We are going to create a file to perform basic file IO operations.");
            Console.WriteLine("Please enter your desired file name:");
            filename = Console.ReadLine() + ".txt";
            path += filename;
            StreamWriter sw = null;

            try
            {
                if (!File.Exists(path))
                {
                    sw = File.CreateText(path);
                    Console.WriteLine("Please enter your name:");
                    sw.WriteLine("Name: " + Console.ReadLine());
                    Console.WriteLine("Please enter your age:");
                    sw.WriteLine("Age: " + Console.ReadLine());
                    Console.WriteLine("Please enter your address:");
                    sw.WriteLine("Address: "+ Console.ReadLine());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sw.Close();
            }

            Console.WriteLine("These are the file contents:");
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            File.Delete(path);
            Console.ReadLine();
        }
    }
}