using SOLID.O.Enums;
using SOLID.O.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.O.Specifications
{
    public class ColorSpecification : ISpecification<Product>
    {
        public Color Color { get; set; }

        public ColorSpecification(Color color)
        {
            Color = color;
        }

        public bool IsSatisfiedBy(Product p) => p.Color == Color;
    }
}
