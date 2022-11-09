using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresLib
{
    public static class Manager
    {
        public static void Start(string inputData)
        {
            try
            {
                ShapeProcessing(inputData);
            }
            catch (BadValueException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong: {ex.Message}");
            }
        }

        public static void ShapeProcessing(string inputData)
        {
            Shape shape = GetShape(inputData);

            Console.WriteLine($"Square is {shape.GetSquare()}");

            if (shape is Triangle triangle)
                Console.WriteLine($"The triangle is {(triangle.IsTriangleRight() ? "right" : "not right")}");
        }

        public static Shape GetShape(string shapeData)
        {
            string[] sidesStr = shapeData.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (sidesStr.Length == 3)
                return TriangleProcessing(sidesStr);
            else if (sidesStr.Length == 1)
                return CircleProcessing(sidesStr[0]);
            else
                throw new BadValueException("Triangle can't have 2 sides, and circle can't have 2 radiuses");
        }

        public static Shape TriangleProcessing(string[] sides)
        {
            double a = double.Parse(sides[0]);
            double b = double.Parse(sides[1]);
            double c = double.Parse(sides[2]);

            ValidateValue(new double[] {a, b, c});

            Console.WriteLine("Looks like a triangle...");

            return new Triangle(a, b, c);
        }

        public static Shape CircleProcessing(string shapeData)
        {
            double radius = double.Parse(shapeData);
            ValidateValue(radius);

            Console.WriteLine("There is a nice circle!");

            return new Circle(radius);
        }

        public static void ValidateValue(double value)
        {
            if (value < 0)
                throw new BadValueException("Your value is negative!");
        }

        public static void ValidateValue(double[] values)
        {
            foreach (double value in values)
                ValidateValue(value);
        }
    }

    public class BadValueException : Exception
    {
        public BadValueException(string message) : base(message) {}
    }
}
