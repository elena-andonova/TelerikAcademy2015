using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    //Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.
    class TestingShapes
    {
        static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Square(4),
                new Rectangle(4, 5),
                new Triangle(4, 4)
            };

            foreach (var sh in shapes)
            {
                Console.WriteLine("The surface of the shape {0} is {1:F2}", sh.GetType().Name, sh.CalculateSurface());
            }
        }
    }
}
