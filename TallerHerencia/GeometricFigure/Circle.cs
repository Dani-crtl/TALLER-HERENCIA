using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{

    public class Circle : geometricFigure
    {
       private double _r;
        public double R
        {
            get => _r;
            set => ValidateR(value);
        }

        public Circle(string Name, double r) : base(Name)
        {
           _r = r;
            Name = "Circle";
        }

        private void ValidateR(double r)
        {
          if (r <= 0) throw new ArgumentException("Radius must be positive.");
        }

        public override double GetArea() => Math.PI * _r * _r;
        public override double GetPerimeter() => 2 * Math.PI * _r;
    }
    

}


