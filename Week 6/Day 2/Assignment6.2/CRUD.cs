using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a table “Cars”. Add columns like VIN, Make, Model, Year, Price etc.

// Create a Windows forms app to display records in grid. Perform basic CRUD.

namespace Assignment6._2
{
    interface ICRUD
    {
        string GenerateVIN();
        void AddRecord(Car obj);
        void DeleteRecord(Car obj);
        ICollection<Car> GetCars();
        Car FindCar(string vin);
        void UpdateRecord(string vin, Car carchanges);
    }

    class CarRepository : ICRUD
    {
        CarsDBEntities entities; // representing db
        Random rnd = new Random();
        public CarRepository() // constructor
        {
            entities = new CarsDBEntities();
        }

        public void AddRecord(Car obj)
        {
            entities.Cars.Add(obj); // update list
            entities.SaveChanges(); // update db (actual table)
        }

        public void DeleteRecord(Car obj)  
        {
            entities.Cars.Remove(obj);
            entities.SaveChanges();
        }

        public Car FindCar(string vin)
        {
            try
            {
                var car = entities.Cars.First(n => n.VIN == vin);
                if (car != null)
                    return car;
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }

        public ICollection<Car> GetCars()
        {
            return entities.Cars.ToList();
        }

        public string GenerateVIN()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(rnd.Next(1, 9)); // random number 1-9
            for(int i = 0; i < 4; i++)
                sb.Append(Convert.ToChar(rnd.Next(65, 90))); // 4 random characters A-Z
            sb.Append(rnd.Next(1, 9)); // random number 1 - 9
            for (int i = 0; i < 2; i++)
                sb.Append(Convert.ToChar(rnd.Next(65, 90))); // 2 random characters A-Z
            sb.Append(rnd.Next(1, 9)); // random number 1-9
            for (int i = 0; i < 3; i++)
                sb.Append(Convert.ToChar(rnd.Next(65, 90))); // 3 random characters A-Z
            for (int i = 0; i < 5; i++)
                sb.Append(rnd.Next(0,9)); // 5 random numbers 0-9

            return sb.ToString();
        }

        public void UpdateRecord(string vin, Car carchanges)
        {
            var cartoupdate = entities.Cars.Find(vin);
            cartoupdate.VIN = carchanges.VIN;
            cartoupdate.Make = carchanges.Make;
            cartoupdate.Model = carchanges.Model;
            cartoupdate.Year = carchanges.Year;
            cartoupdate.Cylinders = carchanges.Cylinders;
            cartoupdate.Price = carchanges.Price;
            cartoupdate.EngineDisplacement = carchanges.EngineDisplacement;
            entities.SaveChanges();
        }
    }
}
