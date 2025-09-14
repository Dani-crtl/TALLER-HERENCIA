using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    public class Kite : Rhombus
    {
        private double _b;
        public double B 
        { 
            get => _b; 
            set => ValidateB(value);
        }

        public Kite(string Name, double a, double b, double d1, double d2) : base(Name, a, d1, d2)
        {
            Name = "Kite";
            _b = b;
        }
        public override double GetArea()
        {
            return (D1 * D2) / 2;
        }
        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
        private void ValidateB(double value)
        {
            if (value <= 0)
                throw new Exception("El lado debe ser mayor que cero.");
        }   


        
    }
}
