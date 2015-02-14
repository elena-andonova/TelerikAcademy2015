using System;


namespace PointInsideCircleOutsideRectangle
{
    class PointInsideCircleOutsideRectangle
    {
        static void Main()
        {
            double pointX = -100;
            double pointY = -100;
            double circleX = 1;
            double circleY = 1;
            double circleR = 1.5;
            double recX1 = -1;
            double recWidth = 6;
            double recX2 = recX1 + recWidth;
            double recY2 = 1;
            double recHeight = 2;
            double recY1 = recY2 - recHeight;
            bool isInsideCircle = Math.Pow((pointX - circleX), 2) + Math.Pow((pointY - circleY), 2) <= Math.Pow(circleR, 2);
            Console.WriteLine("The point with coordinates ({0},{1}) is inside the circle K(({2},{3}), R={4})? : {5}",
                                pointX, pointY, circleX, circleY, circleR, isInsideCircle);
            bool isInsideRectangle = (pointX >= recX1) && (pointX <= recX2) && (pointY >= recY1) && (pointY <= recY2);
            Console.WriteLine("The point with coordinates ({0},{1}) is inside the rectangle R(top={2}, left={3}, width={4}, height={5}))? : {6}",
                                  pointX, pointY, recY2, recX1, recWidth, recHeight, isInsideRectangle); 
            
            if ((isInsideCircle) && (!isInsideRectangle))
            {
                Console.WriteLine("The point with coordinates ({0},{1}) is inside the circle and outside the rectangle",
                                pointX, pointY); 
            }
            else
            {
                Console.WriteLine("The point with coordinates ({0},{1}) is NOT inside the circle and outside the rectangle",
                                pointX, pointY);             
            }
        }
    }
}
