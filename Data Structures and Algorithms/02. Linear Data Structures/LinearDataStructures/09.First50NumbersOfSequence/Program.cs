namespace _09.First50NumbersOfSequence
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Console.Write("Give me your N: ");
            int n = int.Parse(Console.ReadLine());
            int members = 50;

            var queue = new Queue<int>();
            queue.Enqueue(n);
            int index = 0;

            var sequence = new List<int>();
            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                sequence.Add(current);

                index++;
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current + 1);
                queue.Enqueue(current + 2);

                if (sequence.Count == members)
                {
                    break;
                }
            }

            var result = string.Join(", ", sequence);
            Console.WriteLine(result);
        }
    }
}
