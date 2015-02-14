using System;
using System.Globalization;
using System.Threading;


namespace _04.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            //Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. 
            //Use a sequence of if operators.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please enter three numbers.");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            double[] numArr = { a, b, c };
            string result = "";

            if (a == 0 || b == 0 || c == 0)
            {
                result = "0";
                Console.WriteLine(result);
            }
            else
            {
                int counter = 0;
                for (int i = 0; i < numArr.Length; i++)
                {
                    if (numArr[i] < 0)
                    {
                        counter++;
                    }
                }
                // Console.WriteLine(counter);
                switch (counter)
                {
                    case 1:
                    case 3:
                        result = "-";
                        Console.WriteLine(result);
                        break;
                    case 2:
                        result = "+";
                        Console.WriteLine(result);
                        break;
                    default:
                        result = "+";
                        Console.WriteLine(result);
                        break;
                }
            }          
        }
    }
}
