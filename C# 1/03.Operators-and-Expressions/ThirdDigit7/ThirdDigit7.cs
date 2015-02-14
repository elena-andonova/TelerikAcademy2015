using System;


namespace ThirdDigit7
{
    class ThirdDigit7
    {
        static void Main()
        {
            int number = 9999799;
            int thirdDigit = (number / 100) % 10;
            Console.WriteLine(thirdDigit);
            bool is7 = thirdDigit == 7;            
            Console.WriteLine("The third digit in the number {0} from right to left is 7 : {1}",
                                number, is7);
        }
    }
}
