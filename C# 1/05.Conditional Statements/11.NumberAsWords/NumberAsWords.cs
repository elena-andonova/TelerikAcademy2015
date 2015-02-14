using System;


namespace _11.NumberAsWords
{
    class NumberAsWords
    {
        static void Main()
        {
            //Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
            
            Console.WriteLine("Please enter a number in the range[0;999]: ");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            int firstPos = number / 100;
            int secPos = (number / 10) % 10;
            int thirdPos = number % 10;
            int positions = numberString.Length;
            string hundred = "hundred";

            if (number < 0 || number > 1000)
            {
                Console.WriteLine("Not a valid number!");
                return;
            }

            string[] digitsBig = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] digitsSmall = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] tensBig = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tensSmall = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] decimalsBig = { "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string[] decimalsSmall = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            switch (positions)
            {
                case 1:
                    {
                        //the number is a digit.                        
                        Console.WriteLine(digitsBig[thirdPos]);
                    }
                    break;
                case 2:
                    {
                        //the number is tens or decimals.
                        if (secPos == 1)
                        {
                            Console.WriteLine(tensBig[thirdPos]);
                        }
                        else if (secPos >= 2 && thirdPos == 0)
                        {
                            Console.WriteLine(decimalsBig[secPos - 2]);
                        }
                        else
                        {
                            Console.WriteLine(decimalsBig[secPos - 2] + " " + digitsSmall[thirdPos]);
                        }
                    }
                    break;
                case 3:
                    {
                        //the number is hundreds.
                        if (secPos == 0 && thirdPos == 0)
                        {
                            Console.WriteLine(digitsBig[firstPos] + " " + hundred);
                        }
                        else if (secPos == 0 && thirdPos != 0)
                        {
                            Console.WriteLine(digitsBig[firstPos] + " " + hundred + " and " + digitsSmall[thirdPos]);
                        }
                        else if (secPos == 1)
                        {
                            Console.WriteLine(digitsBig[firstPos] + " " + hundred + " and " + tensSmall[thirdPos]);
                        }
                        else if (secPos >= 2 && thirdPos == 0)
                        {
                            Console.WriteLine(digitsBig[firstPos] + " " + hundred + " and " + tensSmall[secPos - 2]);
                        }
                        else
                        {
                            Console.WriteLine(digitsBig[firstPos] + " " + hundred + " and " + decimalsSmall[secPos - 2] + " " + digitsSmall[thirdPos]);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Not a valid number!");
                    break;
            }
        }
    }
}
