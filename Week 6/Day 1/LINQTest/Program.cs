using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            { 
                new Car {VIN = "A1", Make = "Ford", Model = "Mach-E", Price = 40000, Year = 2021},
                new Car { VIN = "B2", Make = "Ford", Model = "Bronco", Price = 35000, Year = 2022},
                new Car {VIN = "C3", Make = "Ford", Model = "Mustang", Price = 38000, Year = 2021} 
            };

            // LINQ: default, deferred execution
            var model21s = from c in cars
                           where c.Year == 2021
                           select c;

            // forced query execution, happens immediately
            var makeFords = (from c in cars
                           where c.Make == "Ford" && c.Price >= 30000
                           orderby c.Price descending
                           select c);

            cars.Add(new Car() { VIN = "D4", Make = "Ford", Model = "Shelby GT500", Price = 60000, Year = 2021 });

            foreach(var car in model21s)
                Console.WriteLine($" {car.Year} {car.Model}, {car.Price:C2}");
            foreach (var car in makeFords)
                Console.WriteLine($"{ car.Year} {car.Model}, {car.Price:C2}");

            Console.Read();
        }
    }
}