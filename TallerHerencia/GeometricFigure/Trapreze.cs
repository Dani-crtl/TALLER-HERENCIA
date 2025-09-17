using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    public class Trapeze : Triangle
    {
        private double _d;
        public double D 
        { 
            get => _d; 
            set => ValidateD(value);
        }
        public Trapeze( string Name, double a, double b, double c, double h, double d) : base(Name, a, b, c, h)
        {
            Name = "Trapeze";
            _d = d;
        }
        public override double GetArea()
        {
            return ((A + B) * H) / 2;
        }
        public override double GetPerimeter()
        {
            return A + B + C + D;
        }
        private void ValidateD(double value)
        {
            if (value <= 0)
                throw new Exception("The side must be greater than zero.");
        }

    }
}
