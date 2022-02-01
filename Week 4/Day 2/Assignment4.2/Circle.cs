using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._2
{
    internal class Circle
    {
        // public property
        public double Radius { get; set; }
        public double Area { get; set; }

        // method
        public double CalcArea(double radius)
        {
            double num = Math.PI * Math.Pow(radius, 2);
            this.Area = num;
            return num;
        }

        public double CalcRadius(double area)
        {
            double num = Math.Sqrt(area/Math.PI);
            this.Radius = num;
            return num;
        }

        // operator overload
        public static Circle operator +(Circle c1, Circle c2)
        {
            Circle cnew = new Circle();
            cnew.Area = c1.Area + c2.Area;
            cnew.Radius = cnew.CalcRadius(cnew.Area);
            return cnew;
        }

        public static Circle operator -(Circle c1, Circle c2)
        {
            Circle cnew = new Circle();
            if (c1.Area > c2.Area)
            {
                cnew.Area = c1.Area - c2.Area;
                cnew.Radius = cnew.CalcRadius(cnew.Area);
                return cnew;
            }
            else return null;
        }

        // constructor
        public Circle(double radius)
        {
            this.Radius = radius;
            this.Area = CalcArea(radius);
        }

        public Circle()
        {

        }
    }
}
