using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;

namespace ConsoleApplication
{
    public class Counter
    {
        public Counter(List<Shape> shapes)
        {
            Shapes = shapes;
        }
        public readonly List<Shape> Shapes;

        public void Proceed()
        {
            float perimeter = 0f;
            float square = 0f;
            foreach (var figure in Shapes)
            {
                Console.WriteLine(figure);
                perimeter += figure.Perimeter;
                square += figure.Area;
            }

            Console.WriteLine($"Sum of all perimeters of given shapes: {perimeter}");
            Console.WriteLine($"Sum of all squares of given shapes: {square}");
        }
    }
}
