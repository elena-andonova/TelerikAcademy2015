namespace _02.ReversingNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Console.Write("Please enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your {0} numbers: ", n);

            
            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                stack.Push(number);
            }

            Console.WriteLine();
            Console.WriteLine("--Here are the numbers reversed --");
            stack.ToList().ForEach(num => Console.WriteLine(num));
        }
    }
}
