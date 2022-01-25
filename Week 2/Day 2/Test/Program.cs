using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test
{
    internal class Program
    {
        static string filepath = @"C:\Users\sk8bo\source\repos\MSSA\Week 2\Log";
        static void Main(string[] args)
        {
            try
            {
                int result, i;
                i = 10;
                result = i / 0;
            }
            catch (Exception e)
            {
                // WriteToFiles(e.Message + " " + e.Source + " " + DateTime.Now);
                AppendLines(e.Message + " " + e.Source + " " + DateTime.Now);
                ReadFromLog();
            }
            Console.ReadLine();
        }
        static void WriteToFiles(string data)
        {
            StreamWriter sw = new StreamWriter(filepath);
            if (File.Exists(filepath))
            {
                sw.WriteLine(data);
                Console.WriteLine("Contents written to file.");
                sw.Close();
            }
            else
            {
                sw = File.CreateText(filepath);
                sw.WriteLine(data);
                Console.WriteLine("Contents written to file.");
                sw.Close ();
            }
        }

        static void AppendLines(string data)
        {
            if (File.Exists(filepath))
            {
                File.AppendAllText(filepath, "\n"+data);
            }
            else
            {
                WriteToFiles(data);
            }
        }

        static void ReadFromLog()
        {
            StreamReader sr = new StreamReader(filepath);
            string data = sr.ReadToEnd();
            Console.WriteLine("Contents: " + data);
            sr.Close();
        }
    }
}