using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Create a structure named “Point” and 2 data members: X and Y coordinate. Declare 2 points: P1 and P2. 
Determine if P2 is to the right or left of P1 or on same axis , by comparing the x xoordinates. 
( if p1.x is more than p2.x , it is to the right ) */

namespace Assignment1._4._1
{
    struct Point // structure that consists of 2 data members, an X and Y coordinate
    {
        double xCoordinate; // internal member field for X coordinate
        double yCoordinate; // internal member field for Y coordinate

        public Point(double X, double Y) // constructor for Point that takes two coordinates
        {
            this.xCoordinate = X;
            this.yCoordinate = Y;
        }
    
        public double X // public read/write property for x coordinate
        { 
            get { return this.xCoordinate; }
            set 
            {
                if (value.GetType() != typeof(double)) // validate that user has entered a valid number
                    throw new ArgumentException(); // throw exception if not
                else
                    this.xCoordinate = value; // otherwise, set value of xCoordinate
            } 
        }

        public double Y // public read/write property for y coordinate
        {
            get { return this.yCoordinate; }
            set 
            {
                if (value.GetType() != typeof(double)) // validate that user has entered a valid number
                    throw new ArgumentException(); // throw exception if not
                else
                    this.yCoordinate = value; // otherwise, set value of yCoordinate
            }
        }

    }
}