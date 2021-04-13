using System;
using System.Collections.Generic;
using System.Linq;

namespace task2
{
    public class Shape : IComparable<Shape>
    {
        public double Area { get; set; }

        public int CompareTo(Shape other)
        {
            return this.Area.CompareTo(other.Area);
        }

    }

    public class Square : Shape
    {
        
        public Square(double side)
        {
            Area = side * side;
            Console.WriteLine($"Area of square: {Area}");
        }
    }

    

    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Area = (radius * radius) * Math.PI;
            Console.WriteLine($"Area of circle: {Area}");
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            Area = width * height;
            Console.WriteLine($"Area of rectangle: {Area}");
        }
    }

    public class Triangle : Shape
    {
        public Triangle(double Base, double height)
        {
            Area = (Base * height) / 2;
            Console.WriteLine($"Area of triangle: {Area}");
        }
    }
}