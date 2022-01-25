using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mod10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.Dispose(); // deterministic
            GC.Collect(); // forces GC of all gens
            using (Class1 obj1 = new Class1())
            {
                // calls dispose automatically
            }

            using (SqlConnection con = new SqlConnection())
            {
                // closes connection after using block
            }
        }
    }
}