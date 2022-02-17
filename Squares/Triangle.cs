using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares
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
            double semi_P = (A + B + C) / 2;

            //Heron's formula
            return Math.Sqrt(semi_P * (semi_P - A) * (semi_P - B) * (semi_P - C));
        }

        public bool IsTriangleRight()
        {
            return Pythagoras(A, B, C) || Pythagoras(B, C, A) || Pythagoras(C, A, B);
        }

        bool Pythagoras(double a, double b, double c)
        {
            //It is too hart to be EXACTLY right traingle :)
            const double epsilon = 0.001;

            //Pythagorean theorem
            double difference = Math.Pow(c, 2) - (Math.Pow(a, 2) + Math.Pow(b, 2));

            bool is_right = Math.Abs(difference) < epsilon;

            return is_right;
        }
    }
}
