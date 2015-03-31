using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._64BitArray
{
    class TestingBitArray64
    {
        static void Main()
        {
            BitArray64 num1 = new BitArray64(11);
            Console.WriteLine(num1.ToString());

            num1[0] = 0;
            num1[1] = 0;
            num1[2] = 1;
            num1[3] = 1;
            Console.WriteLine(num1.ToString());

            BitArray64 num2 = new BitArray64(12);
            Console.WriteLine(num2.ToString());

            Console.WriteLine(num2.Equals(num1));
            Console.WriteLine(num1 == num2);
            Console.WriteLine(num1 != num2);

            Console.WriteLine(num1.GetHashCode());
        }
    }
}
