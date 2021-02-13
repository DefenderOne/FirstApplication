using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Figures
{
    public class Circle : Shape
    {
        public Circle(float radius)
        {
            Radius = radius;
        }

        public readonly float Radius;

        public override float Perimeter => 2 * (float)Math.PI * Radius;

        public override float Area => (float) Math.PI * Radius * Radius;
        
        public override string ToString()
        {
            return $"Circle. Radius {Radius}";
        }
    }
}
