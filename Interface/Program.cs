using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Enter your data (like '1.08' for circle or '1.5 2 3.1126' for triangle) or input \"Quit\" for exit...");

            while (true)
            {
                string inputData = Console.ReadLine().Trim();

                if (inputData == "Quit")
                    break;

                SquaresLib.Manager.Start(inputData);
            }
        }
    }
}
