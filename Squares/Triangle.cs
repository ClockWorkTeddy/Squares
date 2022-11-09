using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresLib
{
    public class Triangle : Shape
    {
        double A { get; set; }
        double B { get; set; }
        double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double GetSquare()
        {
            double semiP = (A + B + C) / 2;
            double rootValue = semiP * (semiP - A) * (semiP - B) * (semiP - C);

            if (rootValue < 0)
                throw new ArgumentException("In triangle sum of two sides must be always bigger than 3rd size!");
            //Heron's formula
            return Math.Sqrt(semiP * (semiP - A) * (semiP - B) * (semiP - C));
        }

        public bool IsTriangleRight() => 
            Pythagoras(A, B, C) || Pythagoras(B, C, A) || Pythagoras(C, A, B);

        bool Pythagoras(double a, double b, double c)
        {
            //It is too hart to be EXACTLY right traingle :)
            const double epsilon = 0.001;

            //Pythagorean theorem
            double difference = Math.Pow(c, 2) - (Math.Pow(a, 2) + Math.Pow(b, 2));

            return Math.Abs(difference) < epsilon;
        }
    }
}
