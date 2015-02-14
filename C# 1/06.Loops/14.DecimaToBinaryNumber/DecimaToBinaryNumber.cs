using System;


namespace _14.DecimaToBinaryNumber
{
    class DecimaToBinaryNumber
    {
        static void Main()
        {
            
    //Using loops write a program that converts an integer number to its binary representation.
    //The input is entered as long. The output should be a variable of type string.
    //Do not use the built-in .NET functionality.

            Console.Write("Please enter an integer number: ");
            long num = long.Parse(Console.ReadLine());
            string[] bin = new string[32];
            int baseNum = 2;

            do
            {
                //num = num / baseNum;
                //Console.WriteLine(num);
                for (int i = 0; i < bin.Length; i++)
                {
                    if (num % baseNum == 0)
                    {
                        num = num / baseNum;
                        bin[(bin.Length - 1) - i] = "0";
                    }
                    else
                    {
                        num = num / baseNum;
                        bin[(bin.Length - 1) - i] = "1";
                    }
                }
            }
            while (num != 0);

            Console.WriteLine(string.Join("", bin));
        }
    }
}
