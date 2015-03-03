using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 24. Order words

    Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
*/
namespace _24.OrderWords
{
    class OrderWords
    {
        static void Main()
        {
            Console.Write("enter words separated by spaces: ");
            string line = Console.ReadLine();
            Console.WriteLine();
            string[] words = line.Split(' ');
            Array.Sort(words);
            string sortedWords = string.Join(", ", words);
            Console.WriteLine(sortedWords);
        }
    }
}
