using SOLID.O.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O.Filters
{
    public static class BadProductFilter
    {
        //Problem is that we are keep coming back to the same 'software entity' and modifying it
        public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size) => products.Where(x => x.Size == size);
        public static IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color) => products.Where(x => x.Color == color);
        public static IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color) => products.Where(x => x.Size == size && x.Color == color);
    }
}
