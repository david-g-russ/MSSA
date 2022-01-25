using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._1._2
{
    class Program2
    {
        static void Main(string[] args)
        {
            // set font to blue
            Console.ForegroundColor = ConsoleColor.Blue;
            // declare the datatype variables
            byte byteMin; byte byteMax;
            sbyte sbyteMin; sbyte sbyteMax;
            int intMin; int intMax;
            uint uintMin; uint uintMax;
            short shortMin; short shortMax;
            ushort ushortMin; ushort ushortMax;
            long longMin; long longMax;
            ulong ulongMin; ulong ulongMax;
            float floatMin; float floatMax;
            double doubleMin; double doubleMax;
            decimal decimalMin; decimal decimalMax;
            // set variables equal to their appropriate min or max values
            byteMin = byte.MinValue; byteMax = byte.MaxValue;
            sbyteMin = sbyte.MinValue; sbyteMax = sbyte.MaxValue;
            intMin = int.MinValue; intMax = int.MaxValue;
            uintMin = uint.MinValue; uintMax = uint.MaxValue;
            shortMin = short.MinValue; shortMax = short.MaxValue;
            ushortMin = ushort.MinValue; ushortMax = ushort.MaxValue;
            longMin = long.MinValue; longMax = long.MaxValue;
            ulongMin = ulong.MinValue; ulongMax = ulong.MaxValue;
            floatMin = float.MinValue; floatMax = float.MaxValue;
            doubleMin = double.MinValue; doubleMax = double.MaxValue;
            decimalMin = decimal.MinValue; decimalMax = decimal.MaxValue;
            // print min and max values
            Console.WriteLine($"The minimum value of the byte datatype is {byteMin} and the maximum value of the byte datatype is {byteMax}");
            Console.WriteLine($"The minimum value of the sbyte datatype is {sbyteMin} and the maximum value of the sbyte datatype is  {sbyteMax}");
            Console.WriteLine($"The minimum value of the int datatype is {intMin} and the maximum value of the int datatype is {intMax}");
            Console.WriteLine($"The minimum value of the uint datatype is {uintMin} and the maximum value of the uint datatype is {uintMax}");
            Console.WriteLine($"The minimum value of the short datatype is {shortMin} and the maximum value of the short datatype is {shortMax}");
            Console.WriteLine($"The minimum value of the ushort datatype is {ushortMin} and the maximum value of the ushort datatype is {ushortMax}");
            Console.WriteLine($"The minimum value of the long datatype is {longMin} and the maximum value of the long datatype is {longMax}");
            Console.WriteLine($"The minimum value of the ulong datatype is {ulongMin} and the maximum value of the ulong datatype is {ulongMax}");
            Console.WriteLine($"The minimum value of the float datatype is {floatMin} and the maximum value of the float datatype is {floatMax}");
            Console.WriteLine($"The minimum value of the double datatype is {doubleMin} and the maximum value of the double datatype is {doubleMax}");
            Console.WriteLine($"The minimum value of the decimal datatype is {decimalMin} and the maximum value of the decimal datatype is {decimalMax}");
            //pause program for user to observe output
            Console.ReadLine();
        }
    }
}
