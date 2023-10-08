using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.ExtensionMethods
{
    public static class TypeDeterminateExtention
    {
        public static bool IsRight(this Triangle triangle)
        {
            double[] sides = { triangle.A, triangle.B, triangle.C };
            sides.Order();
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2); 
        }
    }
}
