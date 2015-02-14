using System;


namespace PrintASCIITable
{
    class PrintASCIITable
    {
        static void Main()
        {
            int[] ASCII;
            int i;
            char symbol;
            for (i = 0; i<255 ; i++)
            {
                ASCII[i] = i;
                symbol = (char)i;


                Console.WriteLine(ASCII);
            }
            
        }
    }
}
