using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu mymenu = new Menu();
            for (int i = 0; i < mymenu.Length; i++)
            {
                Console.WriteLine(mymenu[i]);
            }

            string[] menuarray = new string[] { "Soda", "Lime soda" };
            Menu sodamenu = new Menu(menuarray);
            for (int i = 0; i < sodamenu.Length; i++)
            {
                Console.WriteLine(sodamenu[i]);
            }

            Console.ReadLine();
        }
    }
}
