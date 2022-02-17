using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares
{
    public static class Manager
    {
        public static void Start()
        {
            Console.WriteLine("Hello! Enter your data (like '1.08' for circle or '1.5 2 3.1126' for triangle)");
            string shape_data = Console.ReadLine().Trim();
            Shape shape = null;
            bool input_is_ok = true;

            if (shape_data.Contains(" "))
            {
                string[] sides_str = shape_data.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                if (sides_str.Length == 3)
                {
                    try
                    {
                        double a = double.Parse(sides_str[0]);
                        double b = double.Parse(sides_str[1]);
                        double c = double.Parse(sides_str[2]);
                        
                        Console.WriteLine("What a good triangle!");

                        shape = new Triangle(a, b, c);
                    }
                    catch (Exception ex)
                    {
                        input_is_ok = false;
                    }
                }
                else
                {
                    Console.WriteLine("Check the sides count! It must be 3");
                    input_is_ok = false;
                }
            }
            else
            {
                try
                {
                    double radius = double.Parse(shape_data);
                    Console.WriteLine("There is a nice circle!");
                    shape = new Circle(radius);
                }
                catch (Exception ex)
                {
                    input_is_ok = false;
                }

            }

            if (input_is_ok)
            {
                Console.WriteLine("Square is {0}", shape.GetSquare());

                if (shape is Triangle)
                    Console.WriteLine("The triangle is {0}", (shape as Triangle).IsTriangleRight() ? "right" : "not right");
            }
            else
            {
                Console.WriteLine("Your data is bad =(");
            }
        }
    }
}
