using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6JSONserialization
{
    [Serializable]
    internal class Student
    {
        [NonSerialized]
        public int Address;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        

    }
}
