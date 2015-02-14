using System;


namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string first = "Hello";
            string second = "World";
            object greeting = first + " " + second;
            string third = (string)greeting;
            Console.WriteLine(third);
        }
    }
}
