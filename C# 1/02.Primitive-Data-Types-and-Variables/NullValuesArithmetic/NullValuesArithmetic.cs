using System;


namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? nullInt = null;
            double? nullDouble = null;
            Console.WriteLine(nullInt);
            Console.WriteLine(nullDouble);
            Console.WriteLine(nullInt + null);
            Console.WriteLine(nullDouble + 5);
        }
    }
}
