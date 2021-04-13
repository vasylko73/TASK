using System;
using System.Collections.Generic;
using System.Linq;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double width, height, triangleBase, side, radius, area;
            Random random = new Random((int)DateTime.UtcNow.Ticks);

            var expected = new List<Shape>();

            height = 3;
            triangleBase = 4;
            expected.Add(new Triangle(triangleBase, height));

            width = 4;
            expected.Add(new Rectangle(width, height));

            side = 1.1234;
            expected.Add(new Square(side));

            radius = 1.1234;
            expected.Add(new Circle(radius));

            triangleBase = 5;
            height = 2;
            expected.Add(new Triangle(triangleBase, height));

           

           
          

           // Act
           expected.Sort();
           foreach (var sh in expected)
           {
               Console.WriteLine(sh.Area);
           }


        }
    }
}
