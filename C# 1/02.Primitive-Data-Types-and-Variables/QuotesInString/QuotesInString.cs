using System;


namespace QuotesInString
{
    class QuotesInString
    {
        static void Main()
        {
            string howToEscapeQuotes1 = @"The ""use"" of quotations causes difficulties.";
            string howToEscapeQuotes2 = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(howToEscapeQuotes1);
            Console.WriteLine(howToEscapeQuotes2);
        }
    }
}
