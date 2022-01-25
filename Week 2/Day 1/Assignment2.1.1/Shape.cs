using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a base class: ‘Shape’ and add properties like id, name and color and method like ‘calculate area’ .     
 * Inherit circle shape from base class and add properties like radius. override calculate area logic for circle.        
 * Inherit square class from shape and add change the calculate area logic. Add property like side of square.        
 * Take the input from user to select circle or square and display the calculated area . no hard coded values! */

namespace Assignment2._1._1
{
    public abstract class Shape
    {
        public int ShapeID { get; protected set; }
        public string ShapeName { get; set; }
        public string ShapeColor { get; set; }
        public abstract double CalculateArea();

        public Random rnd = new Random(); //initialize RNG

        public virtual int GenerateShapeID() // use RNG to generate unique shape ID
        {
            return rnd.Next(10000, 99999);
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public double CalculateArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override string ToString() => $"The {ShapeColor} circle that you created, {ShapeName}, has a radius of {Radius}";
        
        public Circle(double radius)
        {
            this.Radius = radius;
            this.ShapeID = GenerateShapeID();
            this.ShapeName = "Circle#" + ShapeID;
        }
        public Circle(string color, double radius)
        {
            this.ShapeID = GenerateShapeID();
            this.ShapeName = "Circle#"+ShapeID;
            this.ShapeColor = color;
            this.Radius = radius;
        }
    }
    public class Square : Shape
    {
        public double Length { get; set; }

        public override double CalculateArea()
        {
            return Math.Pow(Length, 2);
        }
        public double CalculateArea(double length)
        {
            return Math.Pow(length, 2);
        }

        public override string ToString() => $"The {ShapeColor} square you created, {ShapeName}, has a length of {Length}";

        public Square(double length)
        {
            this.Length = length;
            this.ShapeID = GenerateShapeID();
            this.ShapeName = "Square#" + ShapeID;
        }
        public Square(string color, double length)
        {
            this.Length = length;
            this.ShapeID = GenerateShapeID();
            this.ShapeName = "Square#" + ShapeID;
            this.ShapeColor = color;
        }

    }
    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public override double CalculateArea()
        {
            return Length * Width;
        }
        public double CalculateArea(double length, double width)
        {
            return length* width;
        }

        public override string ToString() => $"The {ShapeColor} rectangle you created, {ShapeName}, has a length of {Length} and width of {Width}";

        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
            this.ShapeID = GenerateShapeID();
            this.ShapeName = "Rectangle#" + ShapeID;
        }
        public Rectangle(string color, double length, double width)
        {
            this.Length = length;
            this.Width = width;
            this.ShapeID = GenerateShapeID();
            this.ShapeName = "Rectangle#" + ShapeID;
            this.ShapeColor = color;
        }

    }
    
}