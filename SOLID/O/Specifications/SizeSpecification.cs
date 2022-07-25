using SOLID.O.Enums;
using SOLID.O.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O.Specifications
{
    public class SizeSpecification : ISpecification<Product>
    {
        public Size Size { get; set; }

        public SizeSpecification(Size size)
        {
            Size = size;
        }

        public bool IsSatisfiedBy(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
