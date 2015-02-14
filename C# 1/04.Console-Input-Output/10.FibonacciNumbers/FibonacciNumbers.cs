using System;
using System.Globalization;
using System.Threading;


namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please state how many numbers from the Fibonacci Sequence you want to see.");
            Console.Write("n=");
            string line = Console.ReadLine();
            uint n = uint.Parse(line);
            ulong[] fibonacci = new ulong[n];
            fibonacci[0] = 0;
            fibonacci[1] = 1;            
            for (ulong i = 2; i < n; i++)
            {                
                fibonacci[i] = fibonacci[i-2] + fibonacci[i-1];              
            }
            Console.WriteLine(string.Join(", ", fibonacci));
        }
    }
}
