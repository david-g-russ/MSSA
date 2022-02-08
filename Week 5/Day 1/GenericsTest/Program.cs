using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = 5;
            decimal num3 = 1;
            decimal num4 = 2;
            Swap<int> swapint = new Swap<int>();
            swapint.SwapNumbers(ref num1, ref num2);
            Swap<decimal> swapdecimal = new Swap<decimal>();
            swapdecimal.SwapNumbers(ref num3, ref num4);
            
            Car c1 = new Car() { VIN = "A123", Make = "BMW", Model = "Z3" };
            Car c2 = new Car() { VIN = "B456", Make = "BMW", Model = "X3" };
            Car c3 = new Car() { VIN = "C789", Make = "BMW", Model = "Z4" };

            Dictionary<string, Car> carDictionary = new Dictionary<string, Car>
            {
                { c1.VIN, c1 },
                { c2.VIN, c2 },
                { c3.VIN, c3 }
            };

            foreach (var car in carDictionary)
            {
                Console.WriteLine($"{car.Value.VIN}, {car.Value.Make}, {car.Value.Model}");
            }

            Console.WriteLine("Enter the VIN you want to search:");
            string vin = Console.ReadLine();
            if (carDictionary.ContainsKey(vin))
            {
                Console.WriteLine($"{carDictionary[vin].Make}, and {carDictionary[vin].Model}");
            }

            Console.ReadLine();
        }
    }
}
