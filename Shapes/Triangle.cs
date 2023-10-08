using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        private double _a;
        private double _b;

        private double _c;
        public Triangle(double a, double b, double c)
        {
            if (a + b <= c || c + b <= a || a + c <= b)
                throw new ArgumentException("Triangle can not be created!");
            A = a;
            B = b;
            C = c; 
        }

        public double A
        {
            get { return _a; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException();
                _a = value; 
            }
        }
        public double C
        {
            get { return _c; }
            set
            {
                if (value <=0)
                    throw new ArgumentException();
                _c = value;
            }
        }
        public double B
        {
            get { return _b; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException();
                _b = value;
            }
        }

        public override double CalculateSquare()
        {
            var p = (A + B + C) / 2;
            return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 4, MidpointRounding.ToZero); 

        }

    }
}


