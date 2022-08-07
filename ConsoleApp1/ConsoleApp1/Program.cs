using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaPerimeter
{
    abstract class Shape
    {
        abstract public double calcArea();
        abstract public double calcPerimeter();
    }

    class Circle : Shape
    {
        public double radius { get; set; }
        static readonly double PI = 3.14;

        public override double calcArea()
        {
            return PI * radius * radius;
        }

        public override double calcPerimeter()
        {
            return 2 * PI * radius;
        }
    }

    class Rectangle : Shape
    {
        public double length { get; set; }
        public double width { get; set; }

        public override double calcArea()
        {
            return length * width;
        }

        public override double calcPerimeter()
        {
            return 2 * (length * width);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle { length = 5, width = 6 };
            Console.WriteLine("Rectangle Area " + rec.calcArea());
            Console.WriteLine("Rectangle Perimeter " + rec.calcPerimeter());

            Circle c = new Circle { radius = 5 };
            Console.WriteLine("Circle Area " + c.calcArea());
            Console.WriteLine("Circle Perimeter " + c.calcPerimeter());


            Console.ReadKey();
        }
    }
}