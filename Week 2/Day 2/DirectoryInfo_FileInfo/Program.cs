using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Design a tip calculator : 
 * Enter the bill total, tip % and display grand total after adding tip.
 * Use the format specifiers to display currency, % symbol. */

namespace DirectoryInfo_FileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo driveInfo = new DriveInfo(@"C:\");
            Console.WriteLine("Name: " + driveInfo.Name);
            DirectoryInfo[] cDirs = new DirectoryInfo(@"C:\").GetDirectories();
            using (StreamWriter sw = new StreamWriter("Cdriveinfo.txt"))
            {
                foreach (DirectoryInfo info in cDirs)
                {
                    sw.WriteLine(info.Name);
                }
            }

            string line;
            using (StreamReader sr = new StreamReader("Cdriveinfo.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

                DirectoryInfo dirs = new DirectoryInfo(@"C:\");
            FileInfo[] fileInfos = dirs.GetFiles();
            using (StreamWriter sw = new StreamWriter("Cdrivefiles.txt"))
            {
                foreach (FileInfo info in fileInfos)
                {
                    sw.WriteLine(info.Name + " " + info.Length);
                }
            }

            Console.ReadLine();
        }
    }
}