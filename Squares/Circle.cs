using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        double Radius { get; set; }

        public override double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
