using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary.Figures
{
    public class Trapezoid : Shape
    {
        public Trapezoid(float base1, float base2, float side1, float side2, float height)
        {
            Bases = new[] {base1, base2};
            Sides = new[] {side1, side2};
            Height = height;
        }

        public readonly float[] Bases;
        public readonly float[] Sides;
        public readonly float Height;

        public override float Perimeter => Bases.Sum() + Sides.Sum();

        public override float Area => Bases.Sum() / 2f * Height;

        public override string ToString()
        {
            return $"Trapezoid. Bases: {Bases[0]}, {Bases[1]}. Sides: {Sides[0]}, {Sides[1]}. Height: {Height}";
        }
    }
}
