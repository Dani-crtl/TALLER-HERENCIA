using System.Linq.Expressions;

namespace GeometricFigure
{
    
    
        public abstract class geometricFigure
        {
            public string Name { get; set; }
            public geometricFigure(string name)
            {
                Name = name;
            }

            public abstract double GetArea();
            public abstract double GetPerimeter();

            public override string ToString()
            {
                return $"{Name,-15}=> Area.....:      {GetArea():N5}\t    Perimeter: {GetPerimeter():N5}";
            }
        }
    
}