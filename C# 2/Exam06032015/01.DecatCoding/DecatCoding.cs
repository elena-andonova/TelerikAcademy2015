using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.DecatCoding
{
    class DecatCoding
    {
        static int base21 = 21;
        static int base26 = 26;
        static char baseChar = 'a';
        static void Main()
        {
            string line = Console.ReadLine();
            string[] wordsIn21 = line.Split(' ');

            //Console.WriteLine((int)baseChar);

            BigInteger[] wordsInDecimal = WordsFrom21ToDecimal(wordsIn21);
            //for (int i = 0; i < wordsInDecimal.Length; i++)
            //{
            //    Console.WriteLine(wordsInDecimal[i]);
            //}
            string[] wordsIn26 = WordsFromDecimalTo26(wordsInDecimal);
            //Array.Reverse(wordsIn26);
            string forPrint = string.Join(" ", wordsIn26);
            Console.WriteLine(forPrint);
            //for (int i = 0; i < wordsIn26.Length; i++)
            //{
            //    Console.WriteLine(wordsIn26[i]);
            //}

        }

        static BigInteger[] WordsFrom21ToDecimal(string[] wordsIn21)
        {
            BigInteger[] wordsInDecimal = new BigInteger[wordsIn21.Length];

            BigInteger pow = 1;
            BigInteger decNum = 0;
            int index = 0;

            for (int i = 0; i < wordsIn21.Length; i++)
            {
                string word = wordsIn21[i];
                int zeroTempChar = (int)word[word.Length - 1] - (int)baseChar;

                for (int j = 1; j < word.Length; j++)
                {
                    pow = pow * base21;
                    //Console.WriteLine(pow);
                    char tempChar = word[(word.Length - 1) - j];
                    //Console.WriteLine(tempChar);
                    int tempValueChar = (int)tempChar - (int)baseChar;
                    //Console.WriteLine(tempValueChar);
                    //pow = (long)(Math.Pow(baseNum, (num.Length - i)));
                    //Console.WriteLine(pow);
                    //decNum += pow * num[i];
                    decNum += (pow * tempValueChar);
                    //Console.WriteLine(decNum);
                }

                //Console.WriteLine(zeroTempChar);
                decNum = zeroTempChar + decNum;
                //Console.WriteLine(decNum);
                wordsInDecimal[index] = decNum;
                decNum = 0;
                pow = 1;
                index++;
            }
            return wordsInDecimal;
        }

        static string[] WordsFromDecimalTo26(BigInteger[] wordsInDecimal)
        {
            string[] wordsIn26 = new string[wordsInDecimal.Length];
            int rem;
            StringBuilder temp = new StringBuilder();

            for (int i = 0; i < wordsInDecimal.Length; i++)
            {

                BigInteger num = wordsInDecimal[i];
                while(num != 0)
                {
                    rem = (int)(num % base26);
                    char tempChar = (char)(rem + (int)baseChar);
                    //Console.WriteLine(rem);
                    //Console.WriteLine(tempChar);
                    num = num / base26;
                    temp.Append(tempChar);
                }

                string tempNum = temp.ToString();
                temp.Clear();
                char[] tempArr = tempNum.ToCharArray();
                Array.Reverse(tempArr);
                string newTemp = new string(tempArr);
                //Console.WriteLine(tempNum);
                wordsIn26[i] = newTemp; 
            }

            return wordsIn26;
        }
    }
}
