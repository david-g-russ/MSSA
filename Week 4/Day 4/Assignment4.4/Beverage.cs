using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._4
{
    public enum Size
    {
        Small,
        Medium,
        Large,
        ExtraLarge
    }

    public enum Temp
    {
        Iced,
        Hot
    }

    public abstract class Beverage
    {
        public string Name { get; set; }
        public Double Price { get; set; }
        public Size Size { get; set; }
        public int Calories { get; set; }
    }

    public class Coffee : Beverage
    {
        public int CaffeineContent { get; set; }
        public Temp Temp { get; set; }
    }

    public class Soda : Beverage
    {
        public bool HasHighSugar { get; set; }
    }
}