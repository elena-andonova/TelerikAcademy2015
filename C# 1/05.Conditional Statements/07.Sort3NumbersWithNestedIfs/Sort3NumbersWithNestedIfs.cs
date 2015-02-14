using System;
using System.Globalization;
using System.Threading;

namespace _07.Sort3NumbersWithNestedIfs
{
    class Sort3NumbersWithNestedIfs
    {
        static void Main()
        {
            
        //Write a program that enters 3 real numbers and prints them sorted in descending order.
        //Use nested if statements.
        //Note: Don’t use arrays and the built-in sorting functionality.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter three numbers.");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            double biggest;
            double medium;
            double smallest;

            if (a > b)
            {
                if (a > c)
                {
                    biggest = a;
                    if (b > c)
                    {
                        medium = b;
                        smallest = c;
                    }
                    else
                    {
                        medium = c;
                        smallest = b;
                    }
                }
                else
                {
                    biggest = c;
                    medium = a;
                    smallest = b;
                }
            }
            else
            {
                if (b > c)
                {
                    biggest = b;
                    if (a > c)
                    {
                        medium = a;
                        smallest = c;
                    }
                    else
                    {
                        medium = c;
                        smallest = a;
                    }
                }
                else
                {
                    biggest = c;
                    medium = b;
                    smallest = a;
                }
            }
            Console.WriteLine("The numbers in descending order: {0} {1} {2}", biggest, medium, smallest);
        }
    }
}
