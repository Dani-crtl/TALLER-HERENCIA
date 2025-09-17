using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    public class Parallelogram : Rectangle
    {
        private double _h;

        public double H
        {
            get => _h;
            set => ValidateH(value);
        }

        public Parallelogram( string Name,double a, double b, double h) : base(Name, a, b)
        {
            Name = "Parallelogram";
            _h = b;
        }

        public override double GetArea()
        {
            return B * H;
        }
        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
        private void ValidateH(double value)
        {
            if (value <= 0)
                throw new Exception("The height must be greater than zero.");
        }


    }
}
