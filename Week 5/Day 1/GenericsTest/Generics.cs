using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{
    internal class Swap<T>
    {
        public void SwapNumbers(ref T num1, ref T num2)
        {
            T temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}
