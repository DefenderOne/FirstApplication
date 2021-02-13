using System;
using System.Collections;
using System.Collections.Generic;
using ClassLibrary;
using ClassLibrary.Figures;

namespace ConsoleApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Shape> inputShapes = new List<Shape>()
            {
                new Circle(5f),
                new Square(10f),
                new Trapezoid(5f, 8f, 4f, 5f, 4f),
                new Rectangle(5f, 4f),
                new Triangle(3f, 4f, 5f)
            };
            Counter solution = new Counter(inputShapes);
            solution.Proceed();
        }
    }
}

