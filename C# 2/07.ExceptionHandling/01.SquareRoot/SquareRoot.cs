using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    
    //Write a program that reads an integer number and calculates and prints its square root.
    //    If the number is invalid or negative, print Invalid number.
    //    In all cases finally print Good bye.
    //Use try-catch-finally block.

    class SquareRoot
    {
        static void Main()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentException("Invalid number!");
                }

                Console.WriteLine(Math.Sqrt(number));
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
