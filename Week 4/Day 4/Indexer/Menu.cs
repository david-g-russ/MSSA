using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Menu
    {
        private string[] beverages;
        public string this[int index]
        {
            get { return this.beverages[index]; }
        }
        public int Length
        {
            get { return this.beverages.Length;}
        }
        public Menu(string s)
        {
            beverages = new string[] { "Americano", "Latte", "Espressso", "Capuccino" };

        }

        public Menu()
        {
            beverages = new string[] { "Americano", "Latte", "Espressso", "Capuccino" };
        }
        public Menu(string[] s)
        {
            beverages = new string[s.Length];
            Array.Copy(s, beverages, s.Length);
        }
    }
}
