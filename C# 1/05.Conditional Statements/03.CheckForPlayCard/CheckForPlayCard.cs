using System;


namespace _03.CheckForPlayCard
{
    class CheckForPlayCard
    {
        static void Main()
        {
            //Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
            //Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 

            Console.Write("Please enter a card sign: ");
            string card = Console.ReadLine();
            string[] cardArr = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            if (Array.IndexOf(cardArr, card) >= 0)
            {
                Console.WriteLine("Yes!");
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
