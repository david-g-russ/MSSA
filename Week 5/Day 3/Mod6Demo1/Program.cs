using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Mod6Demo1
{
    class Program
    {

        static void Main(string[] args)
        {
            string filepath = "C:\\Files\\data2.txt";
            string[] lines = null; 
           
            if (File.Exists(filepath))
            {
                File.AppendAllText(filepath, "this is new line on feb 9th");
                lines = File.ReadAllLines(filepath);
            }
            else
            {
               // File.Create(filepath);
                FileStream fs = new FileStream(filepath, FileMode.Create);
                fs.Close();
                File.WriteAllText(filepath, "this is new line on feb 9th");
                lines = File.ReadAllLines(filepath);


            }
            foreach (string s in lines)
            {
                Console.WriteLine(s);
            }
            //  File.Copy()
            //  File.Delete(filepath);
            FileInfo fileInfo = new FileInfo(filepath);
            Directory.CreateDirectory(@"C:\febdemos");
            var files= Directory.EnumerateFiles(@"C:\Files"); //1
            IEnumerable<string> fileslist = Directory.EnumerateFiles(@"C:\Files"); // 2
            foreach(var file in fileslist)
            {
                Console.WriteLine(file);
            }

            Console.ReadLine();

        }
    }
}
