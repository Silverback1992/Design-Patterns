using SOLID.L.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public static class RectanglePropertyCalculator
    {
        public static int Area(BadRectangle r) => r.Width * r.Height;
        public static int Area(Rectangle r) => r.Width * r.Height;
    }
}
