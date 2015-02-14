using System;


namespace Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            double a = 0.222;
            double b = 0.333;
            double h = 0.555;
            double area = (a + b) * h / 2;
            Console.WriteLine("The area of the trapezoid with sides a={0}, b={1} and height h={2} is: {3}",
                                a, b, h, area);
        }
    }
}
