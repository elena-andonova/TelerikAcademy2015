using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompareSimpleMaths
{
    class Program
    {
        static void Main(string[] args)
        {
    //        Task 2. Compare simple Maths

    //Write a program to compare the performance of:
    //    add, subtract, increment, multiply, divide
    //for the values:
    //    int, long, float, double and decimal

            int numInt = 5;

            Stopwatch stopwatchInt = new Stopwatch();
            stopwatchInt.Start();

            numInt = numInt + numInt;

            stopwatchInt.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatchInt.Elapsed);

            long numLong = 5;
            Stopwatch stopwatchLong = new Stopwatch();
            stopwatchLong.Start();

            numLong = numLong + numLong;

            stopwatchLong.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatchLong.Elapsed);

            float numFloat = 5;
            Stopwatch stopwatchFloat= new Stopwatch();
            stopwatchFloat.Start();

            numFloat = numFloat + numFloat;

            stopwatchFloat.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatchFloat.Elapsed);

            double numDouble = 5;
            Stopwatch stopwatchDouble = new Stopwatch();
            stopwatchDouble.Start();

            numDouble = numDouble + numDouble;

            stopwatchDouble.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatchDouble.Elapsed);

            decimal numDec = 5.0m;
            Stopwatch stopwatchDecimal = new Stopwatch();
            stopwatchDecimal.Start();

            numDec = numDec + numDec;

            stopwatchDecimal.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatchDecimal.Elapsed);
        }
    }
}
