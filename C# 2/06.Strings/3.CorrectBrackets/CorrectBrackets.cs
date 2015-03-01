using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 3. Correct brackets

    Write a program to check if in a given expression the brackets are put correctly.

Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).*/ 
namespace _3.CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            string line = ")(a+b))";
            char opening = '(';
            char closing = ')';
            int counter = 0;

            for (int i = 0; i < line.Length - 2; i++)
            {
                if (line[i] == opening)
                {
                    counter++;
                }
            }

            for (int j = line.Length - 1; j > 0; j--)
            {
                if (line[j] == closing)
                {
                    counter--;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("Brackets are correct!");
            }
            else
            {
                Console.WriteLine("Brackets are NOT correct!");
            }

        }
    }
}
