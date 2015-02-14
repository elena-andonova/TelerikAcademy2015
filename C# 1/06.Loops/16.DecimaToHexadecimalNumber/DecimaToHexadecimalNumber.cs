using System;


namespace _16.DecimaToHexadecimalNumber
{
    class DecimaToHexadecimalNumber
    {
        static void Main()
        {
            //Using loops write a program that converts an integer number to its hexadecimal representation.
            //The input is entered as long. The output should be a variable of type string.
            //Do not use the built-in .NET functionality.

            Console.Write("Please enter an integer number: ");
            long num = long.Parse(Console.ReadLine());
            string[] hex = new string[32];
            int baseNum = 16;
            long rem;

            if (num == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                do
                {
                    //num = num / baseNum;
                    //Console.WriteLine(num);
                    for (int i = 0; i < hex.Length; i++)
                    {
                        if (num % baseNum < 10)
                        {
                            rem = num % baseNum;
                            num = num / baseNum;
                            hex[(hex.Length - 1) - i] = rem.ToString();
                        }
                        else
                        {
                            rem = num % baseNum;
                            num = num / baseNum;
                            switch (rem)
                            {
                                case 10: hex[(hex.Length - 1) - i] = "A"; break;
                                case 11: hex[(hex.Length - 1) - i] = "B"; break;
                                case 12: hex[(hex.Length - 1) - i] = "C"; break;
                                case 13: hex[(hex.Length - 1) - i] = "D"; break;
                                case 14: hex[(hex.Length - 1) - i] = "E"; break;
                                case 15: hex[(hex.Length - 1) - i] = "F"; break;
                            }
                        }
                    }
                }
                while (num != 0);

                string hexStr = string.Join("", hex);
                string hexStrTr = hexStr.Trim('0');
                Console.WriteLine(hexStrTr);
            }
        }
    }
}
