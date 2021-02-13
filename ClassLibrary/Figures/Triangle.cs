using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary.Figures
{
    public class Triangle : Shape
    {
        public Triangle(float side1, float side2, float side3)
        {
            Sides = new[] {side1, side2, side3};
        }

        public readonly float[] Sides;

        public override float Perimeter => Sides.Sum();

        public override float Area
        {
            get
            {
                float p = Sides.Sum() / 2f;
                return (float)Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
            }
        }

        public override string ToString()
        {
            return $"Triangle. Sides: {Sides[0]}, {Sides[1]}, {Sides[2]}.";
        }
    }
}
