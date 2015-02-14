using System;
using System.Globalization;
using System.Threading;


namespace _05.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter three real numbers.");
            Console.Write("a=");
            string line = Console.ReadLine();
            int a = int.Parse(line);
            if (a < 0 || a > 500)
            {
                Console.WriteLine("a must be in the interval [0;500].");
                return;
            }
            Console.Write("b=");
            line = Console.ReadLine();
            float b = float.Parse(line);
            Console.Write("c=");
            line = Console.ReadLine();
            float c = float.Parse(line);
            Console.WriteLine("{0,-10}|{1,10}|{2,10}|{3,-10}|",
                                a.ToString("X"), Convert.ToString(a, 2).PadLeft(10, '0'), b.ToString("F2"), c.ToString("F3"));
        }
    }
}
