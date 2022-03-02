using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathDll; // early/design-time binding

namespace DllUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathlib mathlib = new Mathlib();
            
            // uses of reflection
            // 1. Late/runtime binding; automating the attachment of dlls to the frontend
            // 2. Editor development; i.e. Visual Studio intellisense
            // 3. Reading the metadata at runtime
        }
    }
}
