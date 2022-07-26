using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L.Shapes
{
    public class BadRectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public BadRectangle()
        {

        }

        public BadRectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
        }
    }
}
