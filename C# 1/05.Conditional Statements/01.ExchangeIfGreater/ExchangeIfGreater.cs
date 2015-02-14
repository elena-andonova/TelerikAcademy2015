using System;
using System.Globalization;
using System.Threading;


namespace _01.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            //Write an if-statement that takes two double variables a and b 
            //and exchanges their values if the first one is greater than the second one.
            //As a result print the values a and b, separated by a space.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter two numbers.");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            double temp;
            if (b < a)
            {
                temp = a;
                a = b;
                b = temp;
            }
            Console.WriteLine(a + " " + b);
        }
    }
}
