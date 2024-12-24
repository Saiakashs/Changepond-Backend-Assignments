using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    public abstract class Shape
    {
        public Shape() {
            Location location = new Location();
        }
        public override string ToString()
        {
            return "Please call any methods";   
        }

        public abstract double Area();

        public abstract double Perimeter();
    }

    public class Location() {
        private double x;
        private double y;

        public double X { get; set; }

        public double Y { get; set; }

    }

    public class Rectangle:Shape
    {
        protected double side1;
        protected double side2;

        public Rectangle(double side1,double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public override double Area()
        {
            double result = side1 * side2;
            return result;
        }

        public override double Perimeter()
        {
            double result = 2 * (side1 + side2);
            return result;
        }
    }

    public class Circle : Shape
    {
        protected double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            double result = 3.14 * (radius*radius);
            return result;
        }

        public override double Perimeter()
        {
            double result = 2 * 3.14 * radius;
            return result;
        }
    }

}
