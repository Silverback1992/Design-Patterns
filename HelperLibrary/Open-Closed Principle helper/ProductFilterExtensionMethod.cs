using SOLID.O;
using SOLID.O.Filters;
using SOLID.O.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary.Open_Closed_Principle_helper
{
    public static class ProductFilterExtensionMethod
    {
        private static ProductFilter _filter = new ProductFilter();

        public static IEnumerable<Product> FilterProduct(this IEnumerable<Product> items, ISpecification<Product> specification)
            => _filter.Filter(items, specification);
    }
}
