using System;
using System.Globalization;
using System.Threading;

namespace _03.CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter the radius of a circle.");
            Console.Write("r=");
            string line = Console.ReadLine();
            double r = double.Parse(line);
            double perimeter = 2 *  Math.PI * r ;
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("The perimeter of the circle is {0}", perimeter.ToString("F2"));
            Console.WriteLine("The area of the circle is {0}", area.ToString("F2"));
        }
    }
}
