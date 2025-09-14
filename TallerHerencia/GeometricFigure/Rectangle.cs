using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    public class Rectangle : Square
    {
        private double _b;
        
        public double B 
        { 
            get => _b; 
            set => ValidateB(value);
        }
        public Rectangle( string Name, double b, double h) : base( Name, b)
        {
            Name = "Rectangle";
            _b = b;
            A = h;
            B = b;
        }

       

        public override double GetArea()
        {
            return A * B;
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
