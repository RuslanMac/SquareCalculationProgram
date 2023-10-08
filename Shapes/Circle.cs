using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        private  double _radius;
        public double Radius
        {
            private set
            {
                if (value < 0)
                    throw new ArgumentException("The Radius must be more or equal to zero!");
                _radius = value;
            }

            get { return _radius; }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateSquare()
        {
            return Math.Round( Math.PI * Math.Pow(Radius, 2), 4);
        }
    }
}
