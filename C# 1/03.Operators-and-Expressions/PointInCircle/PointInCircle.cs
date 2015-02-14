using System;


namespace PointInCircle
{
    class PointInCircle
    {
        static void Main()
        {
            double pointX = 1;
            double pointY = 1.655;
            double circleX = 0;
            double circleY = 0;
            double circleR = 2;

            bool isInsideCircle = Math.Pow((pointX - circleX), 2) + Math.Pow((pointY - circleY), 2) <= Math.Pow(circleR, 2);
            Console.WriteLine("The point with coordinates ({0},{1}) is inside the circle K(({2},{3}), R={4})? : {5}",
                                pointX, pointY, circleX, circleY, circleR, isInsideCircle);                                  
        }
    }
}
