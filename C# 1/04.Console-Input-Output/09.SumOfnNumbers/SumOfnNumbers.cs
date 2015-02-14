using System;
using System.Globalization;
using System.Threading;

namespace _09.SumOfnNumbers
{
    class SumOfnNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please state how many numbers you want to enter.");
            Console.Write("n=");
            string line = Console.ReadLine();
            int n = int.Parse(line);
            double[] nums = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Number {0} = ", (i+1));
                string num = Console.ReadLine();
                nums[i] = Convert.ToDouble(num);
            }
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine("The sum of the numbers is: {0}", sum);
        }
    }
}
