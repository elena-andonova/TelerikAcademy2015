using System;
using System.Globalization;
using System.Threading;

namespace _06.TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            //Write a program that finds the biggest of five numbers by using only five if statements.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter five numbers.");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("d = ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("e = ");
            double e = double.Parse(Console.ReadLine());
            if (a >= b && a >= c && a >= d  && a >= e)
            {
                Console.WriteLine("The biggest number is: " + a);
            }
            else if (b >= a && b >= c && b >= d && b >= e)
            {
                Console.WriteLine("The biggest number is: " + b);
            }
            else if (c >= a && c >= b && c >= d && c >= e)
            {
                Console.WriteLine("The biggest number is: " + c);
            }
            else if (d >= a && d >= b && d >= c && d >= e)
            {
                Console.WriteLine("The biggest number is: " + d);
            }
            else if (e >= a && e >= b && e >= c && e >= d)
            {
                Console.WriteLine("The biggest number is: " + e);                
            }
        }
    }
}
