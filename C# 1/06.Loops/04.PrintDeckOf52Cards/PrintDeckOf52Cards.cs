using System;


namespace _04.PrintDeckOf52Cards
{
    class PrintDeckOf52Cards
    {
        static void Main()
        {
            //Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
            //The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).

            //    The card faces should start from 2 to A.
            //    Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

            string[] suits = new string[] { "spades", "clubs", "hearts", "diamonds" };
            string[] faces = new string[13];
            for (int i = 0; i < 9 ; i++)
            {
                faces[i] = Convert.ToString(i + 2);
            }
            faces[9] = "J";
            faces[10] = "Q";
            faces[11] = "K";
            faces[12] = "A";

            for (int i = 0; i < faces.Length; i++)
            {
                for (int j = 0; j < suits.Length ; j++)
                {
                    if (j == suits.Length - 1)
                    {
                        Console.WriteLine("{0} of {1}", faces[i], suits[j]);
                    }
                    else
                    {
                        Console.Write("{0} of {1}, ", faces[i], suits[j]);
                    }                    
                }
            }            
        }
    }
}
