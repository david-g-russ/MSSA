using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Serializationdemo
{
    [Serializable] // mark the type as serializable
    public class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Address { get; set; }

    }
}
