using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.IncAbsDiff
{
    class IncAbsDiff
    {
        static void Main()
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string line = Console.ReadLine();
                string[] numbers = line.Split(' ');

                int[] sequence = ParsingToIntArr(numbers);
                int[] differences = FindingAbsoluteDifferences(sequence);
                //Console.WriteLine(string.Join(" ", differences));
                Console.WriteLine(IsSequenceIncreasing(differences));               
            }

        }
        static int[] ParsingToIntArr(string[] numbers)
        {
            int[] sequence = new int[numbers.Length];
            for (int n = 0; n < sequence.Length; n++)
            {
                sequence[n] = int.Parse(numbers[n]);
            }
            return sequence;
        }
        static int[] FindingAbsoluteDifferences(int[] sequence)
        {
            int[] differences = new int[sequence.Length - 1];
            int difference;
            for (int j = 1; j < sequence.Length; j++)
            {
                difference = Math.Abs(sequence[j] - sequence[j - 1]);
                //Console.WriteLine(difference);
                differences[j - 1] = difference;
            }
            return differences;
        }

        static bool IsSequenceIncreasing(int[] differences)
        {
            bool isIncreasing = true;
            int differenceConsNumb;
            for (int j = 1; j < differences.Length; j++)
            {
                differenceConsNumb = differences[j] - differences[j - 1];
                if (differenceConsNumb == 0 || differenceConsNumb == 1)
                {
                    isIncreasing = true;
                }
                else
                {
                    isIncreasing = false;
                    break;
                }
            }
            //Console.WriteLine(isIncreasing);
            return isIncreasing;
        }

    }
}
