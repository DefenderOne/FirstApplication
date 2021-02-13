using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClassLibrary.Figures
{
    public class Rectangle : Shape
    {
        public Rectangle(float height, float width)
        {
            Height = height;
            Width = width;
        }

        public readonly float Height;
        public readonly float Width;

        public override float Perimeter => (Height + Width) * 2f;

        public override float Area => Height * Width;

        public override string ToString()
        {
            return $"Rectangle. Height: {Height}. Width: {Width}";
        }
    }
}
