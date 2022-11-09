using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresLib
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        double Radius { get; set; }

        public override double GetSquare() => 
            Math.PI * Math.Pow(Radius, 2);

    }
}
