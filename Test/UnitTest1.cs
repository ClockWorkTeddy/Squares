using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquaresLib;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Circle_Rad1_Ret628()
        {
            double radius = 1.0;
            double expected = 3.14;
            Circle circle = new Circle(radius);
            double actual = circle.GetSquare();
            double delta = 0.005;

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void Triangle345_Ret6()
        {
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            double expected = 6.0;
            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.GetSquare();
            double delta = 0.005;

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void Triangle6810_isright()
        {
            double a = 6.0;
            double b = 8.0;
            double c = 10.0;

            Triangle triangle = new Triangle(a, b, c);

            bool actual = triangle.IsTriangleRight();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void BadInputTwoArgs()
        {
            string input = "1 2";
            Assert.ThrowsException<BadValueException>(() => Manager.GetShape(input));
        }

        [TestMethod]
        public void BadInputCircleString()
        {
            string input = "d";
            Assert.ThrowsException<FormatException>(() => Manager.CircleProcessing(input));
        }

        [TestMethod]
        public void BadInputTriangleString()
        {
            string[] input = "d a s".Split(new char[] { ' ' });
            Assert.ThrowsException<FormatException>(() => Manager.TriangleProcessing(input));
        }

        [TestMethod]
        public void NegativeValue()
        {
            string[] input = "-1 2 3".Split(new char[] { ' ' });
            Assert.ThrowsException<BadValueException>(() => Manager.TriangleProcessing(input));
        }

    }
}
