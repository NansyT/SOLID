using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape square = new Square(4);
            Shape rectangle = new Rectangle(3, 4.5);
            Shape parallelogram = new Parallelogram(3, 5, 58);
            Shape trapezoid = new Trapezoid(10, 9, 8);
            Shape rightTriangle = new RightTriangle(6, 8);

            List<Shape> shapes = new List<Shape>();
            shapes.Add(square);
            shapes.Add(rectangle);
            shapes.Add(parallelogram);
            shapes.Add(trapezoid);
            shapes.Add(rightTriangle);

            foreach (Shape item in shapes)
            {
                Console.WriteLine(item.GetType().Name);
                Console.WriteLine("Area: " + item.CalculateArea() + "\n"
                                + "Circumference: " + item.CalculateCircumference() + "\n");
            }
            Console.ReadLine();
        }
    }
}
