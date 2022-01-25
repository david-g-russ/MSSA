using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod10_2
{
    internal class Class1 : IDisposable
    {

        ~Class1() // finalizer/destructor, non-deterministic
        {
            // cleaning
        }

        public void Dispose() // deterministic
        {
            // cleaning unmanaged resources
            GC.SuppressFinalize(this);
            
        }
    }
}
