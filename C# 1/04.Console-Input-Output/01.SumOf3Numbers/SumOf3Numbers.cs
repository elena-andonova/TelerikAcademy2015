using System;
using System.Globalization;
using System.Threading;


namespace _01.SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter three real numbers.");
            Console.Write("a=");
            string line = Console.ReadLine();
            double a = double.Parse(line);
            Console.Write("b=");
            line = Console.ReadLine();
            double b = double.Parse(line);
            Console.Write("c=");
            line = Console.ReadLine();
            double c = double.Parse(line);
            double sum = a + b + c;
            Console.WriteLine("The sum of the numbers is: {0}", sum);
        }
    }
}
