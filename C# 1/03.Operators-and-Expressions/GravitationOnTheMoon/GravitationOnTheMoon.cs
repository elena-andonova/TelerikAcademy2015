using System;


namespace GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
            double weight = 53.7;
            double weightOnTheMoon = 0.17 * weight;
            Console.WriteLine("On Earth the weight of a man is {0}, but on the Moon it is {1}", 
                                weight, weightOnTheMoon);
        }
    }
}
