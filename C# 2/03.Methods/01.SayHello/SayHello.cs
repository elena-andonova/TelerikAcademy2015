using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SayHello
{
    class SayHello
    {
        //Write a method that asks the user for his name and prints “Hello, <name>”
        //Write a program to test this method.

        static string[] SayHelloMethod()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            string[] forTest = new string[2];
            forTest[0] = name;
            string output = "Hello " + name + "!";
            forTest[1] = output;
            Console.WriteLine(output);
            return forTest;
        }
        static void Main(string[] args)
        {
            string[] forTest = SayHelloMethod();
            string correctOutput = "Hello " + forTest[0] + "!";
            if (forTest[1] == correctOutput)
            {
                Console.WriteLine("The method works correctly!");
            }
            else
            {
                Console.WriteLine("The method does NOT work correctly!");
            }

        }
    }
}
