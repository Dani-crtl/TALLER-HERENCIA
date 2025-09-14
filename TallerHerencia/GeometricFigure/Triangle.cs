using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    public class Triangle : Rectangle
    {
        private double _c; 
        private double _h;  
        public double C 
        { 
            get => _c; 
            set => ValidateC(value);
        }
        public double H 
        { 
            get => _h; 
            set => ValidateH(value);
        }


        public Triangle(string Name, double a, double b, double c, double h) : base(Name, c, h)
        {
            Name = "Triangle";
            _c = c;
            _h = h;
        }

      
        public override double GetArea()
        {
            return (A * H) / 2;
        }
        public override double GetPerimeter()
        {
            return A + B + C;
        }
        private void ValidateC(double value)
        {
            if (value <= 0)
                throw new Exception("El lado debe ser mayor que cero.");
        }
        private void ValidateH(double value)
        {
            if (value <= 0)
                throw new Exception("La altura debe ser mayor que cero.");
        }

    }
}
