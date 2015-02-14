using System;
using System.Globalization;
using System.Threading;


namespace _04.NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter two numbers.");
            Console.Write("a=");
            string line = Console.ReadLine();
            double a = double.Parse(line);
            Console.Write("b=");
            line = Console.ReadLine();
            double b = double.Parse(line);
            Console.WriteLine("The biggest number is: {0}", Math.Max(a, b));
        }
    }
}
