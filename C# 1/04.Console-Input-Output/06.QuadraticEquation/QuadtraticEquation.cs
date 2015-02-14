using System;
using System.Globalization;
using System.Threading;


namespace _06.QuadraticEquation
{
    class QuadtraticEquation
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter three numbers for the quadratic equation ax^2 + bx + c = 0");
            Console.Write("a=");
            string line = Console.ReadLine();
            double a = double.Parse(line);
            Console.Write("b=");
            line = Console.ReadLine();
            double b = double.Parse(line);
            Console.Write("c=");
            line = Console.ReadLine();
            double c = double.Parse(line);            
            double d = Math.Pow(b, 2) - (4 * a * c);
            if (d < 0)
            {
                Console.WriteLine("The equation has no real roots.");
            }
            else
            {
                double res1 = (-b - Math.Sqrt(d)) / (2 * a);
                double res2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("The roots of the quation are: x1 = {0}; x2 = {1}", res1, res2);
            }            
        }
    }
}
