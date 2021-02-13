using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Figures
{
    public class Square : Shape
    {
        public Square(float side)
        {
            Side = side;
        }

        public readonly float Side;

        public override float Perimeter => Side * 4f;

        public override float Area => Side * Side;

        public override string ToString()
        {
            return $"Square. Side: {Side}";
        }
    }
}
