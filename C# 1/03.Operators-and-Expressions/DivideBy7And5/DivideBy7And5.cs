using System;


namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main()
        {
            int number = 0;
            bool divide;
            if (number > 0)
            {
                divide = (number % 5 == 0) && (number % 7 == 0);
                Console.WriteLine("The number {0} can be divided by 5 and 7? : {1}",
                                    number, divide);
            } 
            else
            {
                divide = false;
                Console.WriteLine("The number {0} can be divided by 5 and 7? : {1}",
                                    number, divide);
            }
        }
    }
}
