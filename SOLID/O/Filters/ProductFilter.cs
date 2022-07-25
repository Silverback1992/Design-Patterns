using SOLID.O.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O.Filters
{
    public static class ProductFilter : IFilter<Product>
    {
        public static IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specification) 
            => items.Where(x => specification.IsSatisfiedBy(x));
    }
}
