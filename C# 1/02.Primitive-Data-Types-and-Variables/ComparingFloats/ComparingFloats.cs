using System;


namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            double eps = 0.000001;
            bool areEqual;
            areEqual = 5.3 - 6.01 > eps;
            Console.WriteLine("Are 5.3 and 6.01 equal? Answer:{0}", areEqual);
            areEqual = 5.00000001 - 5.00000003 < eps;
            Console.WriteLine("Are 5.00000001 and 5.00000003 equal? Answer:{0}", areEqual);
        }
    }
}
