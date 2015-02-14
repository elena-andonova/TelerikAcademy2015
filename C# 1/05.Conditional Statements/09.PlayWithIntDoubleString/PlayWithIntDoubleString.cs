using System;
using System.Globalization;
using System.Threading;

namespace _09.PlayWithIntDoubleString
{
    class PlayWithIntDoubleString
    {
        static void Main()
        {
            
        //Write a program that, depending on the user’s choice, inputs an int, double or string variable.
        //    If the variable is int or double, the program increases it by one.
        //    If the variable is a string, the program appends * at the end.
        //Print the result at the console. Use switch statement.

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please choose a type: \n 1-->int \n 2-->double \n 3-->string");
            Console.Write("Your choice is: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Please enter an integer:");
                    int choiceInt = int.Parse(Console.ReadLine()) + 1;
                    Console.WriteLine(choiceInt);
                    break;
                case 2:
                    Console.Write("Please enter a double:");
                    double choiceDouble = double.Parse(Console.ReadLine()) + 1;
                    Console.WriteLine(choiceDouble);
                    break;
                case 3:
                    Console.Write("Please enter a double:");
                    string choiceString = Console.ReadLine() + "*";
                    Console.WriteLine(choiceString);
                    break;
            }                
        }
    }
}
