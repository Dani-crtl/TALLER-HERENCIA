using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
     public class Square:geometricFigure
    {
        private double _a;
        public double A 
        { 
            get => _a;
            set => ValidateA(value);
        }

        public Square( string Name, double a) : base(Name)
        {
            Name = "Square";
            A = a;
            _a = a;
        }

        public override double GetArea()
        {
            return _a * _a;
        }

        public override double GetPerimeter()
        {
            return 4 * _a;
        }
        private void ValidateA (double value)
        {
            if (value <= 0)
                throw new Exception("The side must be greater than zero.");
        }
    }
   
}
