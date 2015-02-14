using System;
using System.Globalization;
using System.Threading;


namespace _05.TheBiggestOf3Numbers
{
    class BiggestOf3Numbers
    {
        static void Main()
        {
            //Write a program that finds the biggest of three numbers.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter three numbers.");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("The biggest number is: {0}", a);
                }
                else
                {
                    Console.WriteLine("The biggest number is: {0}", c);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("The biggest number is: {0}", b);
                }
                else
                {
                    Console.WriteLine("The biggest number is: {0}", c);
                }
            }
        }
    }
}
